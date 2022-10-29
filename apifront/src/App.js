import './App.css';
import Nav from './components/nav/Nav';
import ListarClientes from './components/ListarClientes/ListarClientes';
import CrearClientes from './components/CrearClientes/CrearClientes';
import {BrowserRouter as Router,Route,Link} from "react-router-dom";

function App() {
  return (
    <>
      <Router>
        <Nav />
        <div className='container'>
          <div className="row mb-3 mt-3">
            <div className="col-4">
              <Link to="/crearcliente">Crear Cliente</Link>
            </div>
          </div>
        </div>
        <Switch>
          <Route exact path="/">
            <ListarClientes />
          </Route>
          <Route path='/crearcliente'>
            <CrearClientes />
          </Route>
        </Switch>
      </Router>
    </>
  );
}

export default App;
