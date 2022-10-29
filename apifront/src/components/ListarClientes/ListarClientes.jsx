import React from 'react';
import axios from 'axios';
import { useState, useEffect } from 'react';

function ListarClientes() {

    const [Clientes, setClientes]  = useState([]);

    const listarClientes = () =>{
        axios.get('http://www.appmotosasp.somee.com/api/cliente').then(data => {
            setClientes(data.data);
        }).catch(err => console.log(err));
    }

    useEffect(()=>{
        listarClientes();
    })

    return (
        <div className='row'>
            <table className='table'>
                <thead>
                    <tr>
                        <th>Documento Identidad</th>
                        <th>Nombres</th>
                        <th>Telefono</th>
                        <th>Correo</th>
                        <th>Ciudad</th>
                        <th>Direccion</th>
                    </tr>
                </thead>
                <tbody>
                    {Clientes.map(value => {
                        return(
                            <tr key={value.IdCliente}>
                                <td>{value.IdCliente}</td>
                                <td>{`${value.NombreCliente} ${value.ApellidoCliente}`}</td>
                                <td>{value.Telefono}</td>
                                <td>{value.Correo}</td>
                                <td>{value.Ciudad}</td>
                                <td>{value.Direccion}</td>
                            </tr>
                        )
                    })}
                </tbody>
            </table>
        </div>
    )
}

export default ListarClientes