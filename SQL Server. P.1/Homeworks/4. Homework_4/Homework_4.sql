/*1. ������� ��� ��������� ���� ����� �������������� � �����. */

select Teachers.Name+' '+Teachers.Surname as [��� �������������], Groups.Name as [���� ������]
from Teachers, Groups, Lectures, GroupsLectures
where Teachers.Id = Lectures.TeacherId and Lectures.Id=GroupsLectures.LectureId and Groups.Id=GroupsLectures.GroupId
order by Groups.Name, Teachers.Surname;

/*2. ������� �������� �����������, ���� �������������� ������ 
������� ��������� ���� �������������� ����������. */

select Faculties.Name as [�������� ����������], Faculties.Financing as [���� �������������� ����������], 
SUM (Departments.Financing) as [��������� ���� ������]
from Faculties, Departments
where Faculties.Id=Departments.FacultyId
group by Faculties.Name, Faculties.Financing
having SUM (Departments.Financing) > Faculties.Financing;

/*3. ������� ������� ��������� ����� � �������� �����, ������� ��� ��������.*/ 

select Curators.Name + ' ' + Curators.Surname as [��� �������� ������], Groups.Name as [���� ������]
from Curators, Groups, GroupsCurators
where Curators.Id=GroupsCurators.CuratorId and Groups.Id=GroupsCurators.GroupId
order by Groups.Name, Curators.Surname;

/*4. ������� ����� � ������� ��������������, ������� ������ ������ � ������ �Comp_17�. */

select Teachers.Name + ' ' + Teachers.Surname as [��� �������������], Groups.Name as [���� ������], Subjects.Name as '�������'
from Teachers, Groups, Subjects, Lectures, GroupsLectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Lectures.Id=GroupsLectures.LectureId 
and Groups.Id=GroupsLectures.GroupId and Groups.Name= 'Comp_17';

/*5. ������� ������� �������������� � �������� ����������� 
�� ������� ��� ������ ������. */

select Teachers.Name + ' ' + Teachers.Surname as [��� �������������], Faculties.Name as [�������� ����������]
from Teachers, Groups, Lectures, GroupsLectures, Faculties, Departments
where Teachers.Id=Lectures.TeacherId and Lectures.Id=GroupsLectures.LectureId and Groups.Id=GroupsLectures.GroupId 
and Departments.Id=Groups.DepartmentId and Faculties.Id=Departments.FacultyId
group by Teachers.Name, Teachers.Surname, Faculties.Name
order by Faculties.Name, Teachers.Surname;

/*6. ������� �������� ������ � �������� �����, ������� � ��� ���������. */

select Departments.Name as [�������� �������], Groups.Name as '������'
from Departments, Groups
where Departments.Id=Groups.DepartmentId
group by Departments.Name, Groups.Name
order by Groups.Name;

/*7. ������� �������� ���������, ������� ������ ������������� �Samantha Adams�. */

select Teachers.Name + ' ' + Teachers.Surname as [��� �������������], Subjects.Name as [������� ����������]
from Teachers, Subjects, Lectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Teachers.Name='Samantha' and Teachers.Surname='Adams'
group by Teachers.Name, Teachers.Surname, Subjects.Name;

/*8. ������� �������� ������, �� ������� �������� ���������� �Database Theory�. */

select Departments.Name as [�������� �������], Subjects.Name as [������� ����������]
from Departments, Subjects, Groups, GroupsLectures, Lectures
where Departments.Id=Groups.DepartmentId and Groups.Id=GroupsLectures.GroupId and Lectures.Id=GroupsLectures.LectureId 
and Subjects.Id=Lectures.SubjectId and Subjects.Name='Database_Theory';


/*9. ������� �������� �����, ������� ��������� � ���������� �Computer Science�. */

select Faculties.Name as [�������� ����������], Groups.Name as [���� ������]
from Faculties, Groups, Departments
where Faculties.Id=Departments.FacultyId and Departments.Id=Groups.DepartmentId and Faculties.Name='Faculty_of_Computer_science'
group by Faculties.Name, Groups.Name;


/*10. ������� �������� ����� 5-�� �����, � ����� �������� �����������, 
� ������� ��� ���������. */

select Groups.Year as [���� ��������], Groups.Name as [���� ������], Faculties.Name as [�������� ����������]
from Groups, Faculties, Departments
where Faculties.Id=Departments.FacultyId and Departments.Id=Groups.DepartmentId and Groups.Year=5
group by Groups.Year, Groups.Name, Faculties.Name
order by Faculties.Name, Groups.Name;


/*11. ������� ������ ����� �������������� � ������, ������� ��� ������ 
(�������� ��������� � �����), ������ �������� ������ �� ������, ������� 
�������� � ��������� �b103�.*/

select Teachers.Name + ' ' + Teachers.Surname as [��� ��������������], Subjects.Name as [������� ����������], 
Groups.Name as [���� ������], Lectures.LectureRoom as [���������]
from Teachers,  Subjects, Groups, Lectures, GroupsLectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Lectures.Id=GroupsLectures.LectureId 
and Groups.Id=GroupsLectures.GroupId and Lectures.LectureRoom='b103'
group by Teachers.Name, Teachers.Surname, Subjects.Name, Groups.Name, Lectures.LectureRoom
order by Groups.Name, Teachers.Name;