                       --aCADEMY ADLI BAZA YARADIRIQ VE ONUN  PARAMETRLERINI VERIRIK
--CREATE DATABASE Academy
--on(
--Name='Academy.mfd',
--FileName='D:\Academy.mfd',
--Size=10MB,
--MaxSize=100MB,
--FileGrowth=10MB
--)

--USE Academy --        Academy BAZASINA KECHIRIK (AKTIV EDIRIK)

--exec sp_helpdb Academy   --Academy BAZASI HAQQINDA INFORMASIYA ELDE EDIRIK




                            --STUDEND ADLI TABLE YARDIRIQ ,DATA-LATIN ADINI TIPINI ,NULL DEYERI QEBUL EDIB ETMEDIYINI TEYIN EDIRIK
--CREATE TABLE Student(
--ID INT IDENTITY NOT NULL,
--Grade INT NOT NULL,
--FullName VARCHAR(50) NOT NULL,
--Birthday DATE NOT NULL DEFAULT 'BIRTDAY',
--[GROUP] VARCHAR(10)  NULL
--)
                               -- STUDENT TABLE-A DATALAR DAXIL EDIRIK

--INSERT INTO Student

--(Grade,FullName,Birthday,[Group])   --data yerleshdirme ardicilligini gostere bilerik,gostermeye de bilerik

--values
--( 4,'Ramin Semedov','07-07-1983','c-charp3'), --Table-a data-lari daxil edirik
--( 2,'Isa Qasimov','10-12-2000','JS-2'),
--( 3,'Nofel','10-12-1998','JS-2')


--UPDATE Student                               --Table daxilinde deyishiklik edirik
 --SET FullName='RAMIN' WHERE ID=1



 --DELETE Student                         --Table daxilinde row silirik
-- WHERE FullName='Nofel'



--Select * from Student       -- Butun setirleri gostermek

-- Select FullName,ID from Student -Student daxilindki butun setirlerin ID  ne FullName  gostermek

--Select ID, FullName from Student     -- ID 3-den boyuk olanlarin ID-sini ve FullNmae gostermek
--where ID>3

--Select ID,FullName from Student      -- GRADE 1-den boyuk ve 5 kichik olanlarin ID-sini ve FullNmae gostermek 
--where Grade>1  and Grade<5




--Select ID,[Group] from Student     --Grade 2 il2 5 arasinda olanlari goster
--where Grade between  2 and  5 


--Select ID,FullName from Student     --2000-ci ilde anadan olanlarin siyahisini goster
--where Birthday LIKE '2000%'

--Select ID,FullName from Student     --Uzunlugu 4-e beraber olan gruplarin  siyahisini goster
--where [GROUP] LIKE '____'


--Select ID,FullName from Student         --ID-si 1,3 ve ya 5 olmayanlari goster
--where ID NOT IN(1,3,5)

--Select * from Student                     --ID -ye gore artan sirada siralama
--ORDER BY ID

--Select * from Student                      --Birtday-e gore azalan sirada siralama
--ORDER BY Birthday DESC


--Select sum(ID) AS summ from Student     ---Grade 4 ve ya 2 olanlarin id-ni toplayib FullName gore qruplashdirmaq
--where Grade IN (4,2)
--Group by FullName

--Select COUNT(*) as Rows from Student        --Setielerin sayini goster




--Select FullName,sum(Grade) as Grades from Student
--where ID>3
--group by FullName
--having FullName='Ramin Semedov'

--Select TOP 3  * from Student 


   --Select * from Student
   --order by ID 
   --offset 3 rows
   --fetch next 2 rows only


  










 

