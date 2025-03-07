using Avatar_Explorer.Forms;
using Avatar_Explorer.Classes;
using System.Diagnostics;

namespace Avatar_Explorer
{
    internal static class Program
    {
        private static readonly string REG_PROTCOL = "VRCAE";
        private static readonly string SCHEME_FILE_PATH = "./Datas/VRCAESCHEME.txt";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.

                //���΃p�X���擾���A�J�����g�f�B���N�g����ݒ�
                var currentDirectory = Path.GetDirectoryName(Process.GetCurrentProcess()?.MainModule?.FileName);
                if (currentDirectory != null) Directory.SetCurrentDirectory(currentDirectory);

                if (!File.Exists("./Datas/Fonts/NotoSansJP-Regular.ttf") ||
                    !File.Exists("./Datas/Fonts/NotoSans-Regular.ttf") ||
                    !File.Exists("./Datas/Fonts/NotoSansKR-Regular.ttf"))
                {
                    MessageBox.Show("�K�v�ȃt�H���g���t�H���_���ɑ��݂��܂���ł����B�\�t�g��������x���꒼���Ă��������B", "�G���[",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!File.Exists(SCHEME_FILE_PATH))
                {
                    var result = MessageBox.Show("�J�X�^��URL�X�L�[����o�^���܂����H\n\n" +
                                                 "�o�^����ƁA�u���E�U����u" + REG_PROTCOL + "://�v�ł��̃\�t�g���N���ł��܂��B\n" +
                                                 "�o�^���Ȃ��ꍇ�́AURL�X�L�[���ł̋N���͂ł��܂��񂪁A�ʏ�̋N���͉\�ł��B",
                        "�J�X�^��URL�X�L�[���o�^", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        string? exePath = Process.GetCurrentProcess()?.MainModule?.FileName;

                        if (exePath != null)
                        {
                            try
                            {
                                if (!Helper.IsRunAsAdmin())
                                {
                                    var result2 = MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�ɂ͊Ǘ��Ҍ������K�v�ł��B\n" +
                                                                  "�ċN�����ĊǗ��Ҍ����ŋN�����܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (result2 == DialogResult.Yes)
                                        Helper.RestartAsAdmin();
                                    return;
                                }

                                Helper.RegisterCustomScheme(REG_PROTCOL, exePath);
                                File.WriteAllText(SCHEME_FILE_PATH, exePath);
                                MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�ɐ������܂����B", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�Ɏ��s���܂����B\n\n" + ex,
                                    "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^���X�L�b�v���܂����B\n�����o�^��������΁ADatas�t�H���_����VRCAESCHEME.txt���폜���Ă�����x�N�����Ă��������I", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        File.WriteAllText(SCHEME_FILE_PATH, "false");
                    }
                }
                else
                {
                    string path = File.ReadAllText(SCHEME_FILE_PATH);

                    string? exePath = Process.GetCurrentProcess()?.MainModule?.FileName;

                    if (path != "false" && exePath != null && path != exePath)
                    {
                        var result = MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�悪�ύX����Ă��邽�߁A�ēo�^���܂����H\n\n" +
                                                     "�o�^����ƁA�u���E�U����u" + REG_PROTCOL + "://�v�ł��̃\�t�g���N���ł��܂��B\n" +
                                                     "�o�^���Ȃ��ꍇ�́AURL�X�L�[���ł̋N���͂ł��܂��񂪁A�ʏ�̋N���͉\�ł��B",
                            "�J�X�^��URL�X�L�[���o�^", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            try
                            {
                                if (!Helper.IsRunAsAdmin())
                                {
                                    var result2 = MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�ɂ͊Ǘ��Ҍ������K�v�ł��B\n" +
                                                                  "�ċN�����ĊǗ��Ҍ����ŋN�����܂����H", "�m�F", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                    if (result2 == DialogResult.Yes)
                                        Helper.RestartAsAdmin();
                                    return;
                                }

                                Helper.RegisterCustomScheme(REG_PROTCOL, exePath);
                                File.WriteAllText(SCHEME_FILE_PATH, exePath);
                                MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�ɐ������܂����B", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("�J�X�^��URL�X�L�[���̓o�^�Ɏ��s���܂����B\n\n" + ex,
                                    "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("�J�X�^��URL�X�L�[���̍ēo�^���X�L�b�v���܂����B\n����������x�o�^��������΁ADatas�t�H���_����VRCAESCHEME.txt���폜���Ă�����x�N�����Ă��������I", "���", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.WriteAllText(SCHEME_FILE_PATH, "false");
                        }
                    }
                }

                var launchInfo = args.Length > 0 ? Helper.GetLaunchInfo(args[0]) : new LaunchInfo();

                ApplicationConfiguration.Initialize();
                Application.Run(new Main(launchInfo));
            }
            catch (Exception ex)
            {
                MessageBox.Show("�\�t�g�̋N�����ɃG���[���������܂����B\n\n" + ex,
                    "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}