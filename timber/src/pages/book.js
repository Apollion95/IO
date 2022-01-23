import React, {useState, useEffect, useMemo} from 'react';



const Book = () => {
    const [Books, setBooks] = useState([]);

    useEffect(() => {
        getData();

        async function getData() {
            const response = await fetch("http://localhost:8000/book",{
            credentials: 'include'});
            const data = await response.json();
        }
    }, []);
}

export default Book;