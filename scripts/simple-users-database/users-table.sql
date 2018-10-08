CREATE TABLE users(
    id NUMBER(10) NOT NULL,
    firstname VARCHAR(50) NOT NULL,
    lastname VARCHAR(50) NOT NULL,
    email VARCHAR(50) NULL,
    
    CONSTRAINT ID_PK PRIMARY KEY (id)
);