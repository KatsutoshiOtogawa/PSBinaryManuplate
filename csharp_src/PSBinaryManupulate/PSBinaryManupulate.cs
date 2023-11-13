using System;
using System.Runtime.InteropServices;

public enum SystemArch {
    Unknown,
    X64,
    Aarch64
}


public static class PSBinaryManupulate
{
#if NET6_0_OR_GREATER

    [DllImport("../x86_64-apple-darwin/libpsbinary_manuplate.dylib", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_x86_64_apple_darwin(in IntPtr input_paths, in Int32 num_files, in string output_path );

    [DllImport("../aarch64-apple-darwin/libpsbinary_manuplate.dylib", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_aarch64_apple_darwin(in IntPtr input_paths, in Int32 num_files, in string output_path );

    [DllImport("../x86_64-unknown-linux-gnu/libpsbinary_manuplate.so", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_x86_64_linux(in IntPtr input_paths, in Int32 num_files, in string output_path );

    [DllImport("../aarch64-unknown-linux-gnu/libpsbinary_manuplate.so", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_aarch64_linux(in IntPtr input_paths, in Int32 num_files, in string output_path );

    [DllImport("../x86_64-pc-windows-msvc/libpsbinary_manuplate.dll", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_x86_64_windows(in IntPtr input_paths, in Int32 num_files, in string output_path );

    [DllImport("../aarch64-pc-windows-msvc/libpsbinary_manuplate.dll", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_aarch64_windows(in IntPtr input_paths, in Int32 num_files, in string output_path );
#elif net48

    [DllImport("../x86_64-pc-windows-msvc/libpsbinary_manuplate.dll", EntryPoint = "join_binary")]
    public static extern Int32 JoinBinary_x86_64_windows(in IntPtr input_paths, in Int32 num_files, in string output_path );
#endif

}
