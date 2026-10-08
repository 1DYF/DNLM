using System;
using System.Windows.Forms;
using 运动控制项目.Model;
using 运动控制项目.Motion;

namespace 运动控制项目
{
    public partial class FormSetIni : Form
    {
        private string currentAxis = "X";

        public FormSetIni()
        {
            InitializeComponent();
        }

        private void FormSetIni_Load(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.LoadFile();

                txtIp.Text = Config.Instance.IpAddr ?? "192.168.5.11";

                if (Config.Instance.Axes.ContainsKey("X"))
                    numXAxisNo.Value = Config.Instance.Axes["X"].AxisNo;
                if (Config.Instance.Axes.ContainsKey("Y"))
                    numYAxisNo.Value = Config.Instance.Axes["Y"].AxisNo;
                if (Config.Instance.Axes.ContainsKey("Z"))
                    numZAxisNo.Value = Config.Instance.Axes["Z"].AxisNo;

                cbbAxisName.Items.Clear();
                cbbAxisName.Items.Add("X");
                cbbAxisName.Items.Add("Y");
                cbbAxisName.Items.Add("Z");
                cbbAxisName.SelectedIndex = 0;

                LoadAxisToUI("X");
                chkSoftLimit_CheckedChanged(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("配置窗体初始化失败：" + ex.Message);
            }
        }

        private void LoadAxisToUI(string axisName)
        {
            if (!Config.Instance.Axes.ContainsKey(axisName)) return;
            var c = Config.Instance.Axes[axisName];

            numEquiv.Value = (decimal)c.Equiv;
            numStartVel.Value = (decimal)c.MinVel;
            numMaxVel.Value = (decimal)c.MaxVel;
            numStopVel.Value = (decimal)c.StopVel;
            numAccTime.Value = (decimal)c.Acc;
            numDecTime.Value = (decimal)c.Dec;

            chkSoftLimit.Checked = c.SoftLimitEnable;
            numPosLimit.Value = (decimal)c.PosLimit;
            numNegLimit.Value = (decimal)c.NegLimit;

            numHomeMode.Value = c.HomeMode;
            numHomeLowVel.Value = (decimal)c.HomeMinVel;
            numHomeHighVel.Value = (decimal)c.HomeMaxVel;
            numHomeAccTime.Value = (decimal)c.HomeAcc;
            numHomeDecTime.Value = (decimal)c.HomeDec;
            numHomeOffset.Value = (decimal)c.HomeOff;
        }

        private void SaveAxisFromUI(string axisName)
        {
            if (!Config.Instance.Axes.ContainsKey(axisName)) return;
            var c = Config.Instance.Axes[axisName];

            c.Equiv = (double)numEquiv.Value;
            c.MinVel = (double)numStartVel.Value;
            c.MaxVel = (double)numMaxVel.Value;
            c.StopVel = (double)numStopVel.Value;
            c.Acc = (double)numAccTime.Value;
            c.Dec = (double)numDecTime.Value;

            c.HomeMode = (ushort)numHomeMode.Value;
            c.HomeMinVel = (double)numHomeLowVel.Value;
            c.HomeMaxVel = (double)numHomeHighVel.Value;
            c.HomeAcc = (double)numHomeAccTime.Value;
            c.HomeDec = (double)numHomeDecTime.Value;
            c.HomeOff = (double)numHomeOffset.Value;

            c.SoftLimitEnable = chkSoftLimit.Checked;
            c.PosLimit = (double)numPosLimit.Value;
            c.NegLimit = (double)numNegLimit.Value;
        }

        private void cbbAxisName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbAxisName.SelectedItem == null) return;

            // 先保存旧轴，再切到新轴
            SaveAxisFromUI(currentAxis);

            currentAxis = cbbAxisName.SelectedItem.ToString();
            LoadAxisToUI(currentAxis);
            chkSoftLimit_CheckedChanged(null, null);
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.IpAddr = txtIp.Text;

                Config.Instance.Axes["X"].AxisNo = (ushort)numXAxisNo.Value;
                Config.Instance.Axes["Y"].AxisNo = (ushort)numYAxisNo.Value;
                Config.Instance.Axes["Z"].AxisNo = (ushort)numZAxisNo.Value;

                SaveAxisFromUI(currentAxis);
                Config.Instance.SaveFile();

                MessageBox.Show("配置已保存到 config.json");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败：" + ex.Message);
            }
        }

        private void btnReloadConfig_Click(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.LoadFile();
                txtIp.Text = Config.Instance.IpAddr ?? "";
                numXAxisNo.Value = Config.Instance.Axes["X"].AxisNo;
                numYAxisNo.Value = Config.Instance.Axes["Y"].AxisNo;
                numZAxisNo.Value = Config.Instance.Axes["Z"].AxisNo;
                LoadAxisToUI(currentAxis);
                chkSoftLimit_CheckedChanged(null, null);
                MessageBox.Show("配置已重新加载");
            }
            catch (Exception ex)
            {
                MessageBox.Show("重载失败：" + ex.Message);
            }
        }

        private void btnApplyAll_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAxisFromUI(currentAxis);
                var src = Config.Instance.Axes[currentAxis];

                foreach (var kv in Config.Instance.Axes)
                {
                    if (kv.Key == currentAxis) continue;

                    kv.Value.Equiv = src.Equiv;
                    kv.Value.MinVel = src.MinVel;
                    kv.Value.MaxVel = src.MaxVel;
                    kv.Value.StopVel = src.StopVel;
                    kv.Value.Acc = src.Acc;
                    kv.Value.Dec = src.Dec;
                    kv.Value.HomeMode = src.HomeMode;
                    kv.Value.HomeMinVel = src.HomeMinVel;
                    kv.Value.HomeMaxVel = src.HomeMaxVel;
                    kv.Value.HomeAcc = src.HomeAcc;
                    kv.Value.HomeDec = src.HomeDec;
                    kv.Value.HomeOff = src.HomeOff;
                    kv.Value.SoftLimitEnable = src.SoftLimitEnable;
                    kv.Value.PosLimit = src.PosLimit;
                    kv.Value.NegLimit = src.NegLimit;
                }

                MessageBox.Show($"已把 {currentAxis} 轴参数应用到所有轴（尚未保存）");
            }
            catch (Exception ex)
            {
                MessageBox.Show("应用失败：" + ex.Message);
            }
        }

        private void btnWriteToController_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LS.Instance.isConnected)
                {
                    MessageBox.Show("控制卡未连接");
                    return;
                }

                SaveAxisFromUI(currentAxis);
                LS.Instance.WriteConfig(currentAxis);
                MessageBox.Show($"{currentAxis} 轴参数已写入控制卡");
            }
            catch (Exception ex)
            {
                MessageBox.Show("写入失败：" + ex.Message);
            }
        }

        private void btnReadFromController_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LS.Instance.isConnected)
                {
                    MessageBox.Show("控制卡未连接");
                    return;
                }

                if (!Config.Instance.Axes.ContainsKey(currentAxis)) return;
                var c = Config.Instance.Axes[currentAxis];
                ushort axisNo = c.AxisNo;

                // 读电子齿轮比
                double equiv = 0;
                if (LTDMC.dmc_get_equiv(LS.Instance.cardNo, axisNo, ref equiv) == 0)
                {
                    numEquiv.Value = (decimal)equiv;
                    c.Equiv = equiv;
                }

                // ★ 读速度曲线：必须用 5 个独立变量，不能传同一个
                double minVel = 0, maxVel = 0, tacc = 0, tdec = 0, stopVel = 0;
                short rtn = LTDMC.dmc_get_profile_unit(
                    LS.Instance.cardNo, axisNo,
                    ref minVel, ref maxVel, ref tacc, ref tdec, ref stopVel);

                if (rtn == 0)
                {
                    numStartVel.Value = (decimal)minVel;
                    numMaxVel.Value = (decimal)maxVel;
                    numStopVel.Value = (decimal)stopVel;
                    numAccTime.Value = (decimal)tacc;
                    numDecTime.Value = (decimal)tdec;

                    c.MinVel = minVel;
                    c.MaxVel = maxVel;
                    c.StopVel = stopVel;
                    c.Acc = tacc;
                    c.Dec = tdec;
                }

                MessageBox.Show($"{currentAxis} 轴参数已从控制卡读取（尚未保存）");
            }
            catch (Exception ex)
            {
                MessageBox.Show("读取失败：" + ex.Message);
            }
        }

        private void chkSoftLimit_CheckedChanged(object sender, EventArgs e)
        {
            numPosLimit.Enabled = chkSoftLimit.Checked;
            numNegLimit.Enabled = chkSoftLimit.Checked;
        }
    }
}