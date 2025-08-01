import React from 'react';

const BookDetails = ({ books }) => {
  return (
    <div className="section">
      <h1>Book Details</h1>
      {books.map(book => (
        <div key={book.id} className="item">
          <h3>{book.bname}</h3>
          <h4>{book.price}</h4>
        </div>
      ))}
    </div>
  );
};

export default BookDetails;