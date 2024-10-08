CREATE TABLE Class (
    ClassID NUMBER GENERATED BY DEFAULT AS IDENTITY
        PRIMARY KEY,
    Name NVARCHAR2(256),
    Description NVARCHAR2(256)
);

CREATE TABLE Student (
    StudentID NUMBER GENERATED BY DEFAULT AS IDENTITY
        PRIMARY KEY,
    ClassID NUMBER,
    Name NVARCHAR2(256),
    DOB DATE,
    Code NVARCHAR2(32),
    Math NUMBER,
    Phys NUMBER,
    CONSTRAINT fk_class
        FOREIGN KEY (ClassID)
        REFERENCES Class (ClassID)

);


BEGIN
    -- Inserting rows into Class table
    FOR i IN 1..20 LOOP
        INSERT INTO Class (Name, Description)
        VALUES ('Class ' || i, 'Description for Class ' || i);
    END LOOP;
    
    -- Inserting rows into Student table
    FOR i IN 1..20 LOOP
        FOR j IN 1..10 LOOP
            INSERT INTO Student (ClassID, Name, DOB, Code, Math, Phys)
            VALUES (j, 'Student ' || ((i - 1) * 10 + j), TO_DATE('2005-01-01', 'YYYY-MM-DD') + (i - 1), 'S' || ((i - 1) * 10 + j), ROUND(DBMS_RANDOM.VALUE(1,10)), ROUND(DBMS_RANDOM.VALUE(1,10)));
        END LOOP;
    END LOOP;
    
    COMMIT;
END;

