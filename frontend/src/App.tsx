import React from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import BowlingList from './BowlingLeague/BowlingList';

function Footer() {
  return <footer>Copyright of Javi (dont steal this bruv)</footer>;
}

function App() {
  return (
    <div className="App">
      <Header />
      <BowlingList />
      <Footer />
    </div>
  );
}

export default App;
