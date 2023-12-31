﻿-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
-- SELECT column_name,data_type 
-- FROM information_schema.columns 
-- WHERE table_schema = 'tech-jobs' and table_name = 'Jobs';

-- EmplyerId: INT
-- Id : INT
-- Name: LONGTEXT 

--Part 2: Write a query to list the names of the employers in St. Louis City.

-- SELECT Name 
-- FROM Employers
-- WHERE Location like	'St. Louis';

--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.
    --If a skill does not have a job listed, it should not be included in the results of this query.

-- SELECT skillname 
-- FROM Skills 
-- Inner Join JobSkills On Skills.Id = JobSkills.SkillsId
-- Order By Skillname ASC