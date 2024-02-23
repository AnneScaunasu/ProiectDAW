export class Book {
    id = -1;
    title = '';
    author = '';
    description = '';
    bookTypeId = -1;
    bookType = null;
}

export class AdminUser {
    id = 0;
    userName = '';
    name = '';
    password = '';
    email = '';
}

export class BookSelf {
    id = 0;
    name = '';
    userId = '';
    normalUser = null;
}

export class BookType {
    id = 0;
    name = '';
}

export class NormalUser {
    id = 0;
    userName = '';
    password = '';
    email = '';
}
