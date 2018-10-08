CREATE TABLE user_credentials(
    user_id NUMBER(10) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    
    CONSTRAINT USER_ID_PK PRIMARY KEY(user_id)
);

ALTER TABLE user_credentials
ADD CONSTRAINT USER_ID_FK FOREIGN KEY (user_id) REFERENCES users (id) ON DELETE CASCADE;