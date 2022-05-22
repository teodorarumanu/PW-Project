import { 
  BrowserRouter as Router,
  Routes,
  Route,
} from 'react-router-dom';
import './App.css';
import Header from './components/Header'
import NewsPost from './components/NewsPost';
import Shelter from './components/Shelter';
import NewsPosts from './pages/User/NewsPosts';
import Shelters from './pages/User/Shelters';
import LoginButton from './components/LoginButton';
import LogoutButton from './components/LogoutButton';
import Account from './pages/Account';


function App() {
  return (
      <>
        <div className="font-bold text-2xl">
            STOP WAR!
        </div>  
        <div className='signin'>
          <LoginButton/>
          <LogoutButton/>
        </div>
        
        <div className="column">
          <Router>  
            <div className='fixed top-0.5 left-0'>
              <Header/>  
            </div> 
            
            <Routes>
              <Route exact path="/" element={<NewsPosts/>}></Route>
              <Route exact path="/usernews" element={<NewsPosts/>}></Route>
              <Route exact path="/shelters" element={<Shelters/>}></Route>
              <Route exact path="/newspost/:id" element={<NewsPost/>}></Route>
              <Route exact path="/shelter/:id" element={<Shelter/>}></Route>
              <Route exact path="/profile" element={<Account/>}/><Route/>
            </Routes>
          </Router>
        </div>
      </>
  );
}

export default App;
