/*1. Вывести все возможные пары строк преподавателей и групп. */

select Teachers.Name+' '+Teachers.Surname as [ФИО преподавателя], Groups.Name as [Шифр группы]
from Teachers, Groups, Lectures, GroupsLectures
where Teachers.Id = Lectures.TeacherId and Lectures.Id=GroupsLectures.LectureId and Groups.Id=GroupsLectures.GroupId
order by Groups.Name, Teachers.Surname;

/*2. Вывести названия факультетов, фонд финансирования кафедр 
которых превышает фонд финансирования факультета. */

select Faculties.Name as [Название факультета], Faculties.Financing as [Фонд финансирования факультета], 
SUM (Departments.Financing) as [Суммарный фонд кафедр]
from Faculties, Departments
where Faculties.Id=Departments.FacultyId
group by Faculties.Name, Faculties.Financing
having SUM (Departments.Financing) > Faculties.Financing;

/*3. Вывести фамилии кураторов групп и названия групп, которые они курируют.*/ 

select Curators.Name + ' ' + Curators.Surname as [ФИО куратора группы], Groups.Name as [Шифр группы]
from Curators, Groups, GroupsCurators
where Curators.Id=GroupsCurators.CuratorId and Groups.Id=GroupsCurators.GroupId
order by Groups.Name, Curators.Surname;

/*4. Вывести имена и фамилии преподавателей, которые читают лекции у группы “Comp_17”. */

select Teachers.Name + ' ' + Teachers.Surname as [ФИО преподавателя], Groups.Name as [Шифр группы], Subjects.Name as 'Предмет'
from Teachers, Groups, Subjects, Lectures, GroupsLectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Lectures.Id=GroupsLectures.LectureId 
and Groups.Id=GroupsLectures.GroupId and Groups.Name= 'Comp_17';

/*5. Вывести фамилии преподавателей и названия факультетов 
на которых они читают лекции. */

select Teachers.Name + ' ' + Teachers.Surname as [ФИО преподавателя], Faculties.Name as [Название факультета]
from Teachers, Groups, Lectures, GroupsLectures, Faculties, Departments
where Teachers.Id=Lectures.TeacherId and Lectures.Id=GroupsLectures.LectureId and Groups.Id=GroupsLectures.GroupId 
and Departments.Id=Groups.DepartmentId and Faculties.Id=Departments.FacultyId
group by Teachers.Name, Teachers.Surname, Faculties.Name
order by Faculties.Name, Teachers.Surname;

/*6. Вывести названия кафедр и названия групп, которые к ним относятся. */

select Departments.Name as [Название кафедры], Groups.Name as 'Группы'
from Departments, Groups
where Departments.Id=Groups.DepartmentId
group by Departments.Name, Groups.Name
order by Groups.Name;

/*7. Вывести названия дисциплин, которые читает преподаватель “Samantha Adams”. */

select Teachers.Name + ' ' + Teachers.Surname as [ФИО преподавателя], Subjects.Name as [Учебные дисциплины]
from Teachers, Subjects, Lectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Teachers.Name='Samantha' and Teachers.Surname='Adams'
group by Teachers.Name, Teachers.Surname, Subjects.Name;

/*8. Вывести названия кафедр, на которых читается дисциплина “Database Theory”. */

select Departments.Name as [Название кафедры], Subjects.Name as [Учебные дисциплины]
from Departments, Subjects, Groups, GroupsLectures, Lectures
where Departments.Id=Groups.DepartmentId and Groups.Id=GroupsLectures.GroupId and Lectures.Id=GroupsLectures.LectureId 
and Subjects.Id=Lectures.SubjectId and Subjects.Name='Database_Theory';


/*9. Вывести названия групп, которые относятся к факультету “Computer Science”. */

select Faculties.Name as [Название факультета], Groups.Name as [Шифр группы]
from Faculties, Groups, Departments
where Faculties.Id=Departments.FacultyId and Departments.Id=Groups.DepartmentId and Faculties.Name='Faculty_of_Computer_science'
group by Faculties.Name, Groups.Name;


/*10. Вывести названия групп 5-го курса, а также название факультетов, 
к которым они относятся. */

select Groups.Year as [Курс обучения], Groups.Name as [Шифр группы], Faculties.Name as [Название факультета]
from Groups, Faculties, Departments
where Faculties.Id=Departments.FacultyId and Departments.Id=Groups.DepartmentId and Groups.Year=5
group by Groups.Year, Groups.Name, Faculties.Name
order by Faculties.Name, Groups.Name;


/*11. Вывести полные имена преподавателей и лекции, которые они читают 
(названия дисциплин и групп), причем отобрать только те лекции, которые 
читаются в аудитории “b103”.*/

select Teachers.Name + ' ' + Teachers.Surname as [ФИО преподавателей], Subjects.Name as [Учебные дисциплины], 
Groups.Name as [Шифр группы], Lectures.LectureRoom as [Аудитория]
from Teachers,  Subjects, Groups, Lectures, GroupsLectures
where Teachers.Id=Lectures.TeacherId and Subjects.Id=Lectures.SubjectId and Lectures.Id=GroupsLectures.LectureId 
and Groups.Id=GroupsLectures.GroupId and Lectures.LectureRoom='b103'
group by Teachers.Name, Teachers.Surname, Subjects.Name, Groups.Name, Lectures.LectureRoom
order by Groups.Name, Teachers.Name;