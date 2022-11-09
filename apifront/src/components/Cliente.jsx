import React from 'react'
import { useParams } from 'react-router-dom'
import { useRef, useEffect, useState } from 'react';
import axios from 'axios';

export default function Cliente() {
    const URL = 'http://www.appmotosasp.somee.com/api/cliente/';
    const { id }= useParams();
    const id_cliente = useRef(null);
    const Nombre = useRef(null);
    const Apellido = useRef(null);
    const Correo = useRef(null);
    const Telefono = useRef(null);
    const Direccion = useRef(null);
    const Ciudad = useRef(null);
    

    const enviarCliente = async(e)=>{
        console.log(e);
        e.preventDefault();
        const data = {
            IdCliente : id_cliente.current.value,
            NombreCliente : Nombre.current.value,
            ApellidoCliente : Apellido.current.value,
            Correo : Correo.current.value,
            Telefono : Telefono.current.value,
            Direccion : Direccion.current.value,
            Ciudad : Ciudad.current.value
        };
        console.log(data);
        await axios.put(URL + id, data).then(data => data.data[0].Error ? new Error(data.data[0].Message) : alert(data.data[0].Message)).catch(err => alert(data.data[0].Message));
        id_cliente.current.value = null;
        Nombre.current.value = null;
        Apellido.current.value = null;
        Correo.current.value = null;
        Telefono.current.value = null;
        Direccion.current.value = null;
        Ciudad.current.value = null;
    }

    const consultar = async() =>{
        if(id){
            let data_temp;
            await axios.get(URL + id).then(data => data_temp = data.data[0]).catch(err => console.log(err))
            id_cliente.current.value = data_temp.IdCliente;
            Nombre.current.value = data_temp.NombreCliente;
            Apellido.current.value = data_temp.ApellidoCliente;
            Correo.current.value = data_temp.Correo;
            Telefono.current.value = data_temp.Telefono;
            Direccion.current.value = data_temp.Direccion;
            Ciudad.current.value = data_temp.Ciudad;
        }
    }

    useEffect(()=>{
        consultar();
    });

    return (
        <div className='container w-25 mx-auto'>
            <form onSubmit={enviarCliente}>
                <div className='form-group'>
                    <label htmlFor='id'>Id del Cliente</label>
                    <input ref={id_cliente} className='form-control' id='id' placeholder='Ingresa el Id del Cliente'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='nombre'>Nombre</label>
                    <input ref={Nombre} className='form-control' id='nombre' placeholder='Ingresa el Nombre'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='apellido'>Apellido</label>
                    <input ref={Apellido} className='form-control' id='apellido' placeholder='Ingresa el Apellido'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='correo'>Correo</label>
                    <input ref={Correo} className='form-control' type='correo' id='correo' placeholder='Ingresa el correo'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='telefono'>Telefono</label>
                    <input ref={Telefono} className='form-control' type='phone' id='telefono' placeholder='Ingresa el Telefono'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='direccion'>Direccion</label>
                    <input ref={Direccion} className='form-control' id='direccion' placeholder='Ingresa la Direccion'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='ciudad'>Ciudad</label>
                    <input ref={Ciudad} className='form-control' id='ciudad' placeholder='Ingresa la Ciudad'/>
                </div>
                <button  type='submit' className='btn btn-primary mt-3'>{id ? 'Actualizar' : 'Crear'}</button>
            </form>
        </div>
    )
}
