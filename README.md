# BÁO CÁO BÀI TẬP CHƯƠNG 3 - UNITY BASIC

## THÔNG TIN SINH VIÊN
- **Họ và tên:** Dư Văn Sang
- **MSSV:** BIT230361
- **Lớp:** 23IT-SOFT5
- **Môn học:** Lập trình Game
- **Phiên bản Unity:** 2022.3.62f3

---

## NỘI DUNG THỰC HIỆN

### Lab 1: Component Lifecycle Debugger
- **Mục tiêu:** Hiểu thứ tự chạy các hàm Awake, Start, Update, OnEnable, OnDisable.
- **Cách test:**
  1. Mở Console trong Unity.
  2. Bấm Play để xem log khởi tạo.
  3. Tắt/Bật checkbox của script để xem OnEnable/OnDisable.
  4. Stop game để xem log OnDestroy.

### Lab 2: Vector Movement & Gizmos
- **Mục tiêu:** Di chuyển nhân vật bằng Vector và vẽ Gizmos hướng nhìn.
- **Tính năng:**
  - Di chuyển bằng phím WASD.
  - Sử dụng `.normalized` để tránh lỗi đi chéo nhanh hơn đi thẳng.
  - Hiển thị tia Gizmos màu vàng trong cửa sổ Scene/Game.

### Lab 3: Quaternion Rotation
- **Mục tiêu:** Xoay Turret theo Target (Instant vs Smooth).
- **Tính năng:**
  - Chế độ Instant: Xoay tức thì theo mục tiêu.
  - Chế độ Smooth: Xoay mượt có độ trễ (Slerp).
  - **Cách test:** Tích/Bỏ tích ở ô "Use Smooth" trên Inspector.

### Lab 4: Signed Angle
- **Mục tiêu:** Tính góc có dấu giữa hướng nhân vật và mục tiêu/chuột.
- **Tính năng:**
  - Hiển thị góc chính xác trên UI.
  - Góc Dương (+): Mục tiêu bên trái (Màu Xanh).
  - Góc Âm (-): Mục tiêu bên phải (Màu Đỏ).
  - Nhân vật tự động xoay mượt theo con trỏ chuột.

### Lab 5 & 6: Observer Pattern
- **Mục tiêu:** Quản lý sự kiện máu (HP) bằng C# Action và UnityEvent.
- **Cách test:**
  - Nhấn phím **H**: Trừ máu Player.
  - Quan sát: UI Text cập nhật HP, Console báo "Game Over" khi HP về 0.

### Mini Project: Turret Defense Dummy
- **Mô tả:** Tổng hợp kiến thức Chương 3.
- **Cơ chế:** Player di chuyển tránh né, Turret tự động xoay.

---

## HƯỚNG DẪN CÀI ĐẶT & CHẠY
1. Mở Project bằng Unity Hub (Version 2022.3.x).
2. Vào thư mục **Scenes**.
3. Chọn Scene tương ứng với từng bài Lab (VD: `Lab4`) để chạy thử nghiệm.