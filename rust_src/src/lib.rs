use std::ffi::CStr;
use std::os::raw::c_char;
use std::ptr;
use std::io::{self, Read, Write};
use std::fs::{self, File, OpenOptions};

// join_binary
// _join_binary( *const c_char, *const *const c_char)

// output_pathにはファイル名まで含む。
#[no_mangle]
pub extern "C" fn join_binary(input_paths: *const *const c_char, num_files: i32, output_path: *const c_char) -> i32 {
    unsafe {
        let output_path_cstr = CStr::from_ptr(output_path);
        let output_path_str = output_path_cstr.to_str().expect("Invalid output path");

        let mut output_file = OpenOptions::new()
            .create(true)
            .write(true)
            .open(output_path_str)
            .expect("Failed to open output file");

        for i in 0..num_files {
            let input_path_ptr = *input_paths.offset(i as isize);
            let input_path_cstr = CStr::from_ptr(input_path_ptr);
            let input_path_str = input_path_cstr.to_str().expect("Invalid input path");

            let mut input_file = File::open(input_path_str).expect("Failed to open input file");
            let mut buffer = Vec::new();
            input_file.read_to_end(&mut buffer).expect("Failed to read input file");

            output_file.write_all(&buffer).expect("Failed to write to output file");
        }
    }

    0 // Return success status
}

