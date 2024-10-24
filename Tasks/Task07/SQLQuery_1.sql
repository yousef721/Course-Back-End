CREATE DATABASE Movie
use Movie
-- Movie table
CREATE TABLE movie (
    mov_id INT PRIMARY KEY,
    mov_title VARCHAR(50),
    mov_year INT,
    mov_time INT,
    mov_lang VARCHAR(50),
    mov_dt_rel DATE,
    mov_rel_country VARCHAR(5)
)
-- Actors table
CREATE TABLE actors (
    act_id INT PRIMARY KEY,
    act_fname VARCHAR(20),
    act_lname VARCHAR(20),
    act_gender VARCHAR(1),
)
-- Directors table
CREATE TABLE directors (
    dir_id INT PRIMARY KEY,
    dir_fname VARCHAR(20),
    dir_lname VARCHAR(20)
)
-- genres table
CREATE TABLE genres (
    gen_id INT PRIMARY KEY,
    gen_title VARCHAR(20)
)
-- reviewer table
CREATE TABLE reviewer (
    rev_id INT PRIMARY KEY,
    rev_name VARCHAR(39)
)
-- relationship between Movie table and Actors table
CREATE TABLE movie_cast (
    act_id INT,
    mov_id INT,
    rol VARCHAR(50),
    FOREIGN KEY (act_id) REFERENCES actors(act_id),
    FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
    PRIMARY KEY (act_id,mov_id)
)
-- relationship between Movie table and directors table
CREATE TABLE movie_direction (
    dir_id INT,
    mov_id INT,
    FOREIGN KEY (dir_id) REFERENCES directors(dir_id),
    FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
    PRIMARY KEY (dir_id,mov_id)
)
-- relationship between Movie table and genres table
CREATE TABLE movie_genres (
    gen_id INT,
    mov_id INT,
    FOREIGN KEY (gen_id) REFERENCES genres(gen_id),
    FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
    PRIMARY KEY (gen_id,mov_id)
)
-- relationship between Movie table and reviewer table
CREATE TABLE rating (
    rev_id INT,
    mov_id INT,
    FOREIGN KEY (rev_id) REFERENCES reviewer(rev_id),
    FOREIGN KEY (mov_id) REFERENCES movie(mov_id),
    PRIMARY KEY (rev_id,mov_id)
)

