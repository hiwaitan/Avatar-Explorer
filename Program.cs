using Avatar_Explorer.Forms;
using Avatar_Explorer.Classes;

namespace Avatar_Explorer
{
    internal static class Program
    {
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

                if (!File.Exists("./Datas/Fonts/NotoSansJP-Regular.ttf") ||
                    !File.Exists("./Datas/Fonts/NotoSans-Regular.ttf") ||
                    !File.Exists("./Datas/Fonts/NotoSansKR-Regular.ttf"))
                {
                    MessageBox.Show("�K�v�ȃt�H���g���t�H���_���ɑ��݂��܂���ł����B�\�t�g��������x���꒼���Ă��������B", "�G���[",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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