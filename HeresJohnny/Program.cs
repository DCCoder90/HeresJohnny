using System;
using System.Runtime.InteropServices;

namespace HeresJohnny {
    class Program {

        const int SW_HIDE = 0;
        const uint KEYEVENTF_KEYUP = 0x0002;
        const byte VK_RETURN = 0x0D;
        const byte VK_LWIN = 0x5B;
        const byte VK_SPACE = 0x20;
        const byte A = 0x41;
        const byte B = 0x42;
        const byte C = 0x43;
        const byte D = 0x44;
        const byte E = 0x45;
        const byte J = 0x4A;
        const byte K = 0x4B;
        const byte L = 0x4C;
        const byte M = 0x4D;
        const byte N = 0x4E;
        const byte O = 0x4F;
        const byte P = 0x50;
        const byte R = 0x52;
        const byte S = 0x53;
        const byte T = 0x54;
        const byte U = 0x55;
        const byte W = 0x57;
        const byte Y = 0x59;



        static void Main(string[] args) {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);

            OpenNotepad();

            for (int i = 0; i < 10000; i++) {
                TypeMessage();
            }
        }

        public static void TypeMessage() {
            Random random = new Random();
            int spaces = random.Next(0, 10);

            for (int i = 0; i < spaces; i++) {
                PressAndRelease(VK_SPACE);
            }

            PressAndRelease(A);
            PressAndRelease(L);
            PressAndRelease(L);

            spaces = random.Next(0, 3);

            for (int i = 0; i < spaces; i++) {
                PressAndRelease(VK_SPACE);
            }

            PressAndRelease(W);
            PressAndRelease(O);
            PressAndRelease(R);
            PressAndRelease(K);

            spaces = random.Next(0, 2);

            for (int i = 0; i < spaces; i++) {
                PressAndRelease(VK_SPACE);
            }

            PressAndRelease(A);
            PressAndRelease(N);
            PressAndRelease(D);
            PressAndRelease(VK_SPACE);
            PressAndRelease(N);
            PressAndRelease(O);
            PressAndRelease(VK_SPACE);
            PressAndRelease(P);
            PressAndRelease(L);
            PressAndRelease(A);
            PressAndRelease(Y);
            PressAndRelease(VK_SPACE);
            PressAndRelease(M);
            PressAndRelease(A);
            PressAndRelease(K);
            PressAndRelease(E);
            PressAndRelease(S);
            spaces = random.Next(0, 4);

            for (int i = 0; i < spaces; i++) {
                PressAndRelease(VK_SPACE);
            }
            PressAndRelease(J);
            PressAndRelease(A);
            PressAndRelease(C);
            PressAndRelease(K);
            PressAndRelease(VK_SPACE);
            PressAndRelease(A);
            PressAndRelease(VK_SPACE);
            PressAndRelease(D);
            PressAndRelease(U);
            PressAndRelease(L);
            PressAndRelease(L);
            PressAndRelease(VK_SPACE);
            PressAndRelease(B);
            PressAndRelease(O);
            PressAndRelease(Y);
            spaces = random.Next(0, 2);

            for (int i = 0; i < spaces; i++) {
                PressAndRelease(VK_RETURN);
            }
        }

        public static void OpenNotepad() {
            keybd_event(VK_LWIN, 0x45, 0, (UIntPtr)0);
            keybd_event(R, 0x45, 0, (UIntPtr)0);
            System.Threading.Thread.Sleep(500);
            keybd_event(VK_LWIN, 0x45, KEYEVENTF_KEYUP, (UIntPtr)0);
            keybd_event(R, 0x45, KEYEVENTF_KEYUP, (UIntPtr)0);
            System.Threading.Thread.Sleep(500);
            PressAndRelease(N);
            PressAndRelease(O);
            PressAndRelease(T);
            PressAndRelease(E);
            PressAndRelease(P);
            PressAndRelease(A);
            PressAndRelease(D);
            PressAndRelease(VK_RETURN);
            System.Threading.Thread.Sleep(500);
            PressAndRelease(VK_RETURN);

        }

        public static void PressAndRelease(byte key) {
            keybd_event(key, 0x45, 0, (UIntPtr)0);
            keybd_event(key, 0x45, KEYEVENTF_KEYUP, (UIntPtr)0);
        }


        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);
    }
}
