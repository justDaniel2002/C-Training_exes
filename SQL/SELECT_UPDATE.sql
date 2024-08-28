--Tìm sinh viên có mã SV0001
SELECT * FROM Student WHERE CODE LIKE 'SV0001';
--Tìm SV có điểm vật lý < 4
SELECT * FROM Student WHERE Phys < 4;
--Tìm SV có cả 2 điểm < 5
SELECT * FROM Student WHERE Phys < 5 AND MATH < 5;
--5.	Update tất cả điểm toán thêm 1
UPDATE Student SET MATH = MATH + 1;
--6.	Update điểm vật lý thêm 1 nếu < 4
UPDATE STUDENT SET PHYS = PHYS + 1;

--7.	Update điểm vật lý và toán thêm 1 nếu cả 2 < 5
UPDATE Student SET MATH = MATH + 1, PHYS = PHYS + 1 WHERE Phys < 5 AND MATH < 5;
--8.	Xóa sinh viên có mã "SV0001"
DELETE FROM STUDENT WHERE CODE = 'SV0001';
-- 1.	Đếm số SV có điểmvật lý< 4
SELECT COUNT(*) FROM STUDENT WHERE PHYS < 4;
-- 2.	Đếm số SV có cả 2 điểm < 5
SELECT COUNT(*) FROM STUDENT WHERE Phys < 5 AND MATH < 5;
-- 3.	Đếm số SV có tổng 2 điểm < 10

SELECT COUNT(*) FROM STUDENT WHERE Phys + MATH < 10;
-- 4.	Tính tổng số điểm của mỗi SV
SELECT CODE, NAME, (MATH + PHYS) AS SUM FROM STUDENT ;
-- 5.	Tính tổng số điểm toán của tất cả SV
SELECT SUM(MATH) FROM STUDENT;
-- 6.	Tính điểm toán trung bình của tất cả SV
SELECT CODE, NAME, (MATH + PHYS)/2 AS AVERAGE FROM STUDENT;
-- 7.	Tìm 2 SV có điểm toán cao nhất
SELECT * FROM STUDENT ORDER BY MATH DESC FETCH FIRST 2 ROWS ONLY;
-- 8.	Tìm 2 SV có điểm lý thấp nhất
SELECT * FROM STUDENT ORDER BY PHYS FETCH FIRST 2 ROWS ONLY;

-- 9.	Tìm 2 SV có tổng điểm cao nhất
SELECT CODE, NAME, (MATH + PHYS) AS SUM FROM STUDENT ORDER BY SUM DESC FETCH FIRST 2 ROWS ONLY;


-- 1.	Đưa ra danh sách sinh viên theo từng lớp (Bao gồm cả lớp ko có SV). Hiển thị: Tên lớp, Tất cả thông tin còn lại của SV
SELECT
    c.Name AS ClassName,
    s.StudentID,
    s.Name AS StudentName,
    s.DOB,
    s.Code,
    s.Math,
    s.Phys
FROM
    Class c
LEFT JOIN
    Student s
ON
    c.ClassID = s.ClassID
ORDER BY
    c.Name, s.Name;

-- 2.	Đếm số lượng sinh viên theo từng lớp. HIển thị: Tên lớp, Số sinh viên
SELECT
    c.Name AS ClassName,
    count(s.StudentID) as NUMBEROFSTUDENT
FROM
    Class c
LEFT JOIN
    Student s
ON
    c.ClassID = s.ClassID
GROUP BY
    c.Name
ORDER BY c.Name;
