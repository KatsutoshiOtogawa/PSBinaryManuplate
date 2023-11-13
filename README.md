
cargo build --target x86_64-apple-darwin
cargo build --target aarch64-apple-darwin

cargo build --target x86_64-unknown-linux-gnu
cargo build --target aarch64-unknown-linux-gnu


--releaseをつける。

debugビルド
target/x86_64-apple-darwin/debug/libpsbinary_manuplate.dylib
releaseビルド
target/x86_64-apple-darwin/release/libpsbinary_manuplate.dylib

cargo build --target x86_64-pc-windows-msvc

powershell 7.2 LTS net6.0ベース

powershell 7.3 current net7.0ベース
