import React from 'react';
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import 'react-toastify/dist/ReactToastify.css';
import './App.css';

import { SuburbsList } from './components/SuburbsList';
import NearestSuburb from './components/NearestSuburb';

function App() {
  return (
    <Router>
      <nav className="navbar navbar-expand navbar-dark bg-dark">
        <div className="navbar-nav mr-auto">
          <li className="nav-item">
            <Link to={"/suburbs"} className="nav-link">
              Suburbs
            </Link>
          </li>
          <li className="nav-item">
            <Link to={"/nearest-suburb"} className="nav-link">
              Nearest Suburb
            </Link>
          </li>
        </div>
      </nav>

      <div className="container mt-3">
        <Routes>
          <Route path="/" element={<SuburbsList />} />
          <Route path="/suburbs" element={<SuburbsList />} />
          <Route path="/nearest-suburb" element={<NearestSuburb />} />
        </Routes>
      </div>

    </Router>
  );
}

export default App;
