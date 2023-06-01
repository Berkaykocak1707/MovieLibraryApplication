# MovieLibraryApplication
Description:
This project involves creating a film library application that allows users to manage their movie collections. Users can add, edit, and delete movies. The application also includes an admin panel for controlling all user and movie data. The movies will be stored in a database, and the application will provide various features to help users effectively manage their movies.

Açıklama:
Bu proje, kullanıcıların film koleksiyonlarını yönetmelerine olanak tanıyan bir film kütüphanesi uygulaması oluşturmanızı içerir. Kullanıcılar, filmleri ekleyebilir, düzenleyebilir ve silebilir. Admin panelinden bütün kullanıcı ve film verileri kontrol edilebilirsiniz. Uygulama, filmleri veritabanında depolayacak ve kullanıcılara filmleri etkili bir şekilde yönetmeleri için çeşitli özellikler sunacaktır.  

Database requirements

Database Name: MovieLibraryApplication

Table: "UsersTable"

user_ID: Unique identifier for the user (primary key) - int

username: User's username - varchar(50)

password: User's password - varchar(50)


This table will be used to store user records. Each user will have a unique user_ID and other columns such as username and password for authentication information.



Table: "MoviesTable"

movie_ID: Unique identifier for the movie (primary key) - int

user_ID: Identifier for the user (foreign key, referencing Users table) - int

title: Movie title - varchar(50)

director: Movie director - varchar(50)

cast: Movie cast - varchar(50)

genre: Movie genre - varchar(50)

release_year: Year of movie release - int

rating: Movie rating - float

description: Movie description or summary - varchar(50)

