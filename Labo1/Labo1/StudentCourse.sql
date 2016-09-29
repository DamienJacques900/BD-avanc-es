CREATE TABLE [dbo].[StudentCourse]
		(
			[StudentId] BIGINT NOT NULL,
			[CourseId] BIGINT NOT NULL, 
    			CONSTRAINT [FK_StudentCourse_Student] FOREIGN KEY (StudentId) REFERENCES [Student]([Id]), 
    			CONSTRAINT [FK_StudentCourse_Course] FOREIGN KEY (CourseId) REFERENCES [Course]([Id]) 
		)
