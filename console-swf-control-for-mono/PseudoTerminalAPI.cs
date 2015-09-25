using System;
using System.Runtime.InteropServices;

namespace ConsoleControlAPI
{
	/*
	public static class PseudoTerminalAPI
	{
		//int open(const char *pathname, int flags);
		[DllImport("libc")]
		public static extern int open(string name, int flags);

		//ssize_t read(int fd, void *buf, size_t count);
		[DllImport("libc")]
		public static extern int read(int fd, byte[] buffer, int length);

		//ssize_t write(int fd, const void *buf, size_t count); 
		[DllImport("libc")]
		public static extern int write(int fd, byte[] buffer, int length);

		//int grantpt(int fd);
		[DllImport("libc")]
		public static extern int grantpt(int fd);

		//int unlockpt(int fd);
		[DllImport("libc")]
		public static extern int unlockpt(int fd);

		//i later marshall the pointer to a string
		//char *ptsname(int fd);
		[DllImport("libc")]
		public static extern IntPtr ptsname(int fd);
	}
	*/
}

