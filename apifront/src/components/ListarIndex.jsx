import React from 'react'
import { useEffect, useState } from 'react'
import axios from 'axios';
import { Link } from 'react-router-dom';

function Listar() {

    const URL = 'http://www.appmotosasp.somee.com/api/';
    const [Clientes, setClientes] = useState([]);
    const [Motos, setMotos] = useState([]);

    const EliminarCliente = async(e)=>{
        console.log(e.target.value);
        await axios.delete(URL + '/cliente/' + e.target.value).then(data => {
            console.log('hecho');
            data ? ListarClientes() : alert("Ocurrió un error")
        }).catch(err => console.log(err));
    }

    const ListarClientes =async ()=>{
        let ClientesTemp;
        await axios.get(URL + 'cliente').then(data => ClientesTemp = data.data).catch(err => console.log(err));
        setClientes(ClientesTemp);
    } 

    const ListarCompras = async () =>{
        let Compras_temp;
        await axios.get(URL + 'moto').then(data => Compras_temp = data.data).catch(err => console.log(err));
        setMotos(Compras_temp);
    }

    useEffect(()=>{
        ListarClientes();
        ListarCompras();
    })

  return (
    <>
        <div className='container'>
            <table className='table'>
                <thead>
                        <tr>
                            <th>Id Compra</th>
                            <th>Fecha Compra</th>
                            <th>Marca</th>
                            <th>Cilindraje</th>
                            <th>Freno</th>
                            <th>Llantas</th>
                            <th>Refrigeracion</th>
                            <th>Suspension</th>
                            <th>Valor Moto</th>
                            <th>Valor Soat</th>
                            <th>Valor Total</th>
                            <th>Cliente</th>
                        </tr>
                    </thead>
                    <tbody>
                        {Motos.map(value =>{
                            return (
                                <tr key={value.IdCompra}>
                                    <td>{value.FechaCompra}</td>
                                    <td>{value.Marca}</td>
                                    <td>{value.Modelo}</td>
                                    <td>{value.Cilindraje}</td>
                                    <td>{value.Freno}</td>
                                    <td>{value.Llantas}</td>
                                    <td>{value.Refrigeracion}</td>
                                    <td>{value.Suspension}</td>
                                    <td>{value.VarloMoto}</td>
                                    <td>{value.ValorSoat}</td>
                                    <td>{value.valorTotal}</td>
                                    <td>{value.IdCliente}</td>
                                </tr>
                            );
                        })}
                    </tbody>
            </table>
        </div>
        <div className='container'>
            <table className='table'>
                <thead>
                    <tr>
                        <th>Id Cliente</th>
                        <th>Nombre Cliente</th>
                        <th>Apellido Cliente</th>
                        <th>Correo Cliente</th>
                        <th>Telefono</th>
                        <th>Direccion</th>
                        <th>Ciudad</th>
                    </tr>
                </thead>
                <tbody>
                    {Clientes.map(element => {
                        return(
                            <tr key={element.IdCliente}>
                                <td scope='row'>{element.IdCliente}</td>
                                <td>{element.NombreCliente}</td>
                                <td>{element.ApellidoCliente}</td>
                                <td>{element.Correo}</td>
                                <td>{element.Telefono}</td>
                                <td>{element.Direccion}</td>
                                <td>{element.Ciudad}</td>
                                <td><button onClick={EliminarCliente} value={element.IdCliente}>Eliminar</button></td>
                                <td><button><Link to={'/cliente/' + element.IdCliente}>Editar</Link></button></td>
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    </>
  )
}

export default Listar;