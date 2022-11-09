import './App.css';
import {BrowserRouter, Routes, Route} from 'react-router-dom'
import Listar from './components/ListarIndex';
import Cliente from './components/Cliente';

function App() {
  return (
    <>
    <h1>Api Compras de Motos</h1>
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<Listar />}/>
        <Route path='/cliente/:id' element={<Cliente />}/>
        <Route path='/cliente' element={<Cliente />}/>
      </Routes>
    </BrowserRouter>
    </>
  );
}

export default App;
