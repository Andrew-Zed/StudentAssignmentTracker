```mermaid
erDiagram
	ApplicationUser ||--o{ Course : owns
	Course ||--o{ Assignment : contains

	ApplicationUser {
		string Id PK
		string UserName
		string Email
	}

	Course {
		int Id PK
		string Name
		string Description
		string ApplicationUserId FK
	}

	Assignment {
		int Id PK
		string Title
		string Description
		datetime DueDate
		bool IsCompleted
		int CourseId FK
	}
```

## Relationships

- One `ApplicationUser` can have many `Course` records.
- Each `Course` belongs to one `ApplicationUser`.
- One `Course` can have many `Assignment` records.
- Each `Assignment` belongs to one `Course`.

