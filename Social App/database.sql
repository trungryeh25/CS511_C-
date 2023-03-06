CREATE DATABASE socialapp;
GO
USE socialapp;
GO

CREATE TABLE users (
  user_id INTEGER IDENTITY PRIMARY KEY,
  username VARCHAR(255) NOT NULL,
  password VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  name NVARCHAR(255) NOT NULL,
  age INTEGER NOT NULL,
  image VARCHAR(255)
);

GO
CREATE TABLE posts (
  post_id INTEGER IDENTITY PRIMARY KEY,
  user_id INTEGER NOT NULL,
  message NVARCHAR(MAX),
  image_url NVARCHAR(MAX),
  creation_time DATETIME NOT NULL,
  FOREIGN KEY (user_id) REFERENCES Users(user_id)
);
GO
CREATE TABLE comments (
  comment_id INTEGER IDENTITY PRIMARY KEY,
  post_id INTEGER NOT NULL,
  user_id INTEGER NOT NULL,
  content NVARCHAR(MAX) NOT NULL,
  comment_time DATETIME NOT NULL,
  FOREIGN KEY (post_id) REFERENCES posts(post_id),
  FOREIGN KEY (user_id) REFERENCES users(user_id)
);
GO
CREATE TABLE messages (
  message_id INTEGER IDENTITY PRIMARY KEY,
  sender_id INTEGER NOT NULL,
  receiver_id INTEGER NOT NULL,
  message_text NVARCHAR(MAX) NOT NULL,
  message_timestamp DATETIME NOT NULL,
  FOREIGN KEY (sender_id) REFERENCES Users(user_id),
  FOREIGN KEY (receiver_id) REFERENCES Users(user_id)
);
GO
--INSERT INTO users(username, password, email, name, age)
--VALUES ('hao', '123', 'hao@gmail.com', 'hao', 18);
SELECT * FROM posts;
DELETE posts where post_id = 1;
SELECT * FROM posts;
Select * from users where user_id != 1;

select * from messages where sender_id = 2 and receiver_id = 1

delete messages

INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (1,2,'hi1',GETDATE());
INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (2,1,'hello1',GETDATE());

INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (1,2,'hi2',GETDATE());
INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (2,1,'hello2',GETDATE());

INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (1,2,'hi3',GETDATE());
INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (2,1,'hello3',GETDATE());

INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (1,2,'hi4',GETDATE());
INSERT INTO messages(sender_id, receiver_id, message_text, message_timestamp)
VALUES (2,1,'hello4',GETDATE());

