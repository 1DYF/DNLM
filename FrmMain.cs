using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using 运动控制项目.Model;
using 运动控制项目.Motion;

namespace 运动控制项目
{
    public partial class FrmMain : Form
    {
        private BindingList<JobConfig> jobs = new BindingList<JobConfig>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuConfig_Click(object sender, EventArgs e)
        {
            FormSetIni f = new FormSetIni();
            f.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                Config.Instance.LoadFile();
                LoadJobs();
                try
                {
                    LS.Instance.Connect(Config.Instance.IpAddr);
                    LS.Instance.WriteConfig();   // 把 config 里的参数下发到卡
                    lblStatus.Text = "已连接 " + Config.Instance.IpAddr;
                }
                catch (Exception exConn)
                {
                    lblStatus.Text = "未连接：" + exConn.Message;
                }

                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("初始化失败：" + ex.Message);
                lblStatus.Text = "初始化失败";
            }
        }

        private void LoadJobs()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "points.json");

            if (!File.Exists(path))
            {
                jobs = new BindingList<JobConfig>();
                dgvPoints.AutoGenerateColumns = false;
                dgvPoints.DataSource = jobs;
                return;
            }
            try
            {
                string str = File.ReadAllText(path);
                List<JobConfig> list = JsonConvert.DeserializeObject<List<JobConfig>>(str);
                jobs = (list != null) ? new BindingList<JobConfig>(list)
                                      : new BindingList<JobConfig>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("点位表加载失败：" + ex.Message);
            }

            dgvPoints.AutoGenerateColumns = false;
            dgvPoints.DataSource = jobs;
        }

        private void SaveJobs()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "points.json");

            try
            {
                string str = JsonConvert.SerializeObject(jobs.ToList(), Formatting.Indented);
                File.WriteAllText(path, str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存点位失败：" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!isJobRunning)
                {
                    string s = "";
                    if (LS.Instance.AxisPos.TryGetValue("X", out double xPos))
                        s += $"X: {xPos:F2}   ";
                    if (LS.Instance.AxisPos.TryGetValue("Y", out double yPos))
                        s += $"Y: {yPos:F2}   ";
                    if (LS.Instance.AxisPos.TryGetValue("Z", out double zPos))
                        s += $"Z: {zPos:F2}";

                    lblStatus.Text = "无错误   " + s;
                }
                UpdateAxisLamps();
            }
            catch { }
        }
        private void UpdateAxisLamps()
        {
            UpdateOneAxisLamp("X", panelXMove, panelXAlarm);
            UpdateOneAxisLamp("Y", panelYMove, panelYAlarm);
            UpdateOneAxisLamp("Z", panelZMove, panelZAlarm);
        }
        private void UpdateOneAxisLamp(string axisName, Panel moveLamp, Panel alarmLamp)
        {
            if (!LS.Instance.isConnected)
            {
                moveLamp.BackColor = Color.Gray;
                alarmLamp.BackColor = Color.Gray;
                return;
            }
            if (!Config.Instance.Axes.ContainsKey(axisName)) return;
            ushort axisNo = Config.Instance.Axes[axisName].AxisNo;
            try
            {
                short done = LTDMC.dmc_check_done(LS.Instance.cardNo, axisNo);
                moveLamp.BackColor = (done == 0) ? Color.LimeGreen : Color.Gold;
                ushort state = 0;
                LTDMC.nmc_get_axis_state_machine(LS.Instance.cardNo, axisNo, ref state);
                alarmLamp.BackColor = (state == 6 || state == 7) ? Color.Red : Color.LimeGreen;
            }
            catch
            {
                moveLamp.BackColor = Color.Gray;
                alarmLamp.BackColor = Color.Gray;
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                SaveJobs();
                LS.Instance.DisConnect();
            }
            catch { }
        }

        private void btnXPlus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("X", 1, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXPlus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("X"); } catch { }
        }
        private void btnXMinus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("X", 0, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnXMinus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("X"); } catch { }
        }

        private void btnYPlus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("Y", 1, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnYPlus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("Y"); } catch { }
        }
        private void btnYMinus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("Y", 0, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnYMinus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("Y"); } catch { }
        }

        private void btnZPlus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("Z", 1, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnZPlus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("Z"); } catch { }
        }
        private void btnZMinus_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                double vel = (double)numManualSpeed.Value;
                LS.Instance.Jog("Z", 0, vel);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnZMinus_MouseUp(object sender, MouseEventArgs e)
        {
            try { LS.Instance.Stop("Z"); } catch { }
        }

        private async void btnMoveX_Click(object sender, EventArgs e)
        {
            try
            {
                double target = (double)numPosX.Value;
                await LS.Instance.MoveAbs("X", target);
                MessageBox.Show($"X 轴已到 {target}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("X 轴移动失败：" + ex.Message);
            }
        }

        private async void btnMoveY_Click(object sender, EventArgs e)
        {
            try
            {
                double target = (double)numPosY.Value;
                await LS.Instance.MoveAbs("Y", target);
                MessageBox.Show($"Y 轴已到 {target}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Y 轴移动失败：" + ex.Message);
            }
        }
        private async void btnMoveZ_Click(object sender, EventArgs e)
        {
            try
            {
                double target = (double)numPosZ.Value;
                await LS.Instance.MoveAbs("Z", target);
                MessageBox.Show($"Z 轴已到 {target}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Z 轴移动失败：" + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                LS.Instance.GoHome();
                MessageBox.Show("已启动回零");
            }
            catch (Exception ex)
            {
                MessageBox.Show("回零失败：" + ex.Message);
            }
        }

        private void btnClearError_Click(object sender, EventArgs e)
        {
            try
            {
                if (!LS.Instance.isConnected)
                {
                    MessageBox.Show("控制卡未连接");
                    return;
                }

                short r1 = LTDMC.nmc_clear_axis_errcode(LS.Instance.cardNo, Config.Instance.Axes["X"].AxisNo);
                short r2 = LTDMC.nmc_clear_axis_errcode(LS.Instance.cardNo, Config.Instance.Axes["Y"].AxisNo);
                short r3 = LTDMC.nmc_clear_axis_errcode(LS.Instance.cardNo, Config.Instance.Axes["Z"].AxisNo);

                if (r1 == 0 && r2 == 0 && r3 == 0)
                    MessageBox.Show("X/Y/Z 错误已清除");
                else
                    MessageBox.Show($"清除结果：X={r1}, Y={r2}, Z={r3}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("清除异常：" + ex.Message);
            }
        }
        private void btnStopJob_Click(object sender, EventArgs e)
        {
            try
            {
                jobCts?.Cancel();    
                LS.Instance.Stop("X"); 
                LS.Instance.Stop("Y");
                LS.Instance.Stop("Z");
                MessageBox.Show("已停止所有轴");
            }
            catch (Exception ex)
            {
                MessageBox.Show("停止失败：" + ex.Message);
            }
        }
        private bool isJobRunning = false;
        private CancellationTokenSource jobCts = null;
        private async void btnStartJob_Click(object sender, EventArgs e)
        {
            if (isJobRunning)
            {
                MessageBox.Show("作业正在运行中");
                return;
            }
            if (jobs == null || jobs.Count == 0)
            {
                MessageBox.Show("点位表为空");
                return;
            }

            isJobRunning = true;
            jobCts = new CancellationTokenSource();
            var token = jobCts.Token;

            btnStartJob.Enabled = false;
            btnStopJob.Enabled = true;

            try
            {
                int index = 0;
                foreach (var job in jobs)
                {
                    if (!job.Enable) continue;
                    if (token.IsCancellationRequested) break;

                    index++;
                    lblStatus.Text = $"作业中... 第 {index} 个点位：{job.Name}";

                    await LS.Instance.MoveAbs("X", job.X);
                    if (token.IsCancellationRequested) break;

                    await LS.Instance.MoveAbs("Y", job.Y);
                    if (token.IsCancellationRequested) break;

                    await LS.Instance.MoveAbs("Z", job.Z);
                    if (token.IsCancellationRequested) break;

                    await Task.Delay(Math.Max(0, job.WaitTime), token);
                }

                if (token.IsCancellationRequested)
                {
                    lblStatus.Text = "作业已被中断";
                }
                else
                {
                    lblStatus.Text = "作业完成";
                    MessageBox.Show("所有点位已执行完毕");
                }
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "作业已被中断";
            }
            catch (Exception ex)
            {
                MessageBox.Show("作业异常：" + ex.Message);
                lblStatus.Text = "作业异常";
            }
            finally
            {
                isJobRunning = false;
                jobCts?.Dispose();
                jobCts = null;
                btnStartJob.Enabled = true;
                btnStopJob.Enabled = false;
            }
        }

        private void menuSaveJobs_Click(object sender, EventArgs e)
        {
            SaveJobs();
            MessageBox.Show("点位表已保存到 points.json");
        }

        private void menuLoadJobs_Click(object sender, EventArgs e)
        {
            LoadJobs();
            MessageBox.Show("点位表已重新加载");
        }

        private void menuDeleteJob_Click(object sender, EventArgs e)
        {
            if (dgvPoints.SelectedRows.Count == 0)
            {
                MessageBox.Show("请先选中要删除的点位");
                return;
            }
            int count = dgvPoints.SelectedRows.Count;
            if (MessageBox.Show($"确定要删除选中的 {count} 个点位吗？", "确认",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;
            List<JobConfig> toDelete = new List<JobConfig>();
            foreach (DataGridViewRow row in dgvPoints.SelectedRows)
            {
                if (row.DataBoundItem is JobConfig job)
                    toDelete.Add(job);
            }
            foreach (var job in toDelete)
            {
                jobs.Remove(job);
            }
            MessageBox.Show($"已删除 {count} 个点位");
        }

        private void menuClearJobs_Click(object sender, EventArgs e)
        {
            if (jobs.Count == 0)
            {
                MessageBox.Show("点位表已经空了");
                return;
            }

            if (MessageBox.Show("确定要清空所有点位吗？", "确认",
                MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            jobs.Clear();
            MessageBox.Show("已清空所有点位");
        }

        private void menuAddJob_Click(object sender, EventArgs e)
        {
            var job = new JobConfig();
            jobs.Add(job);
            int lastRow = dgvPoints.Rows.Count - 1;
            if (lastRow >= 0)
            {
                dgvPoints.CurrentCell = dgvPoints.Rows[lastRow].Cells[0];
                dgvPoints.BeginEdit(true);
            }
        }
    }
}