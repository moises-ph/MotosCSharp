import React from 'react';
import { Link } from 'react-router-dom';
import { useRef } from 'react';
import './Motos.css';
import axios from 'axios';

function Motos() {

    const URL = 'http://www.appmotosasp.somee.com/api/moto'
    const Marca = useRef(null);
    const Modelo = useRef(null);
    const Cilindraje = useRef(null);
    const Freno = useRef(null);
    const Llantas = useRef(null);
    const Refrigeracion = useRef(null);;
    const Suspension = useRef(null);
    const valorMoto = useRef(null);
    const valorSoat = useRef(null);
    const valorTotal = useRef(null);
    const Cliente = useRef(null);

    const TotalMoto = ()=>{
        valorTotal.current.value = parseInt(valorSoat.current.value) + parseInt(valorMoto.current.value);
    }

    const enviarMoto = async (e) =>{
        e.preventDefault();
        const data = {
            Marca : Marca.current.value,
            Modelo : Modelo.current.value,
            Cilindraje : parseInt(Cilindraje.current.value),
            Freno : Freno.current.value,
            Llantas : Llantas.current.value,
            Refrigeracion : Refrigeracion.current.value,
            Suspension : Suspension.current.value,
            ValorMoto : parseInt(valorMoto.current.value),
            ValorSoat : parseInt(valorSoat.current.value),
            valorTotal : parseInt(valorTotal.current.value),
            IdCliente : Cliente.current.value
        }
        console.log(data);
        axios.post(URL, data).then(data => data.data[0].Error ? new Error(data.data[0].Message) : alert("Compra creada Exitosamente")).catch(err => alert(err));
        Marca.current.value = null ;
        Modelo.current.value = null ;
        Cilindraje.current.value = null ;
        Freno.current.value = null ;
        Llantas.current.value = null ;
        Refrigeracion .current.value=  null;
        Suspension.current.value = null ;
        valorMoto.current.value = null ;
        valorSoat.current.value = null ;
        valorTotal.current.value = null ;
        Cliente.current.value = null ;
    }

    return (
    <>
        <h2>Compra de Moto</h2>
        <div className='container w-25 mx-auto'>
            <form onSubmit={enviarMoto}>
                <div className='form-group'>
                    <label htmlFor='marca'>Marca</label>
                    <input ref={Marca} className='form-control' id='marca' placeholder='Ingresa la Marca de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='modelo'>Modelo</label>
                    <input ref={Modelo} className='form-control' id='modelo' placeholder='Ingresa el Modelo de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='cilindraje'>Cilindraje</label>
                    <input ref={Cilindraje} type='number' className='form-control' id='cilindraje' placeholder='Ingresa el Cilindraje de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='freno'>Freno</label>
                    <input ref={Freno} className='form-control' id='freno' placeholder='Ingresa el Freno de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='llantas'>Llantas</label>
                    <input ref={Llantas} className='form-control' id='llantas' placeholder='Ingresa las Llantas de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='refrigeracion'>Refrigeración</label>
                    <input ref={Refrigeracion} className='form-control' id='refrigeracion' placeholder='Ingresa la Refrigeración de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='suspension'>Suspensión</label>
                    <input ref={Suspension} className='form-control' id='suspension' placeholder='Ingresa la Suspensión de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='valorMoto'>Valor de la Moto</label>
                    <input onChange={TotalMoto} defaultValue='0' ref={valorMoto} type='number' className='form-control' id='valorMoto' placeholder='Ingresa el Valor de la Moto de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='valorSoat'>Valor del Soat</label>
                    <input onChange={TotalMoto} defaultValue='0' ref={valorSoat} type='number' className='form-control' id='valorSoat' placeholder='Ingresa el Valor del Soat de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='valorTotal'>Valor Total</label>
                    <input defaultValue='0' ref={valorTotal} type='number' className='form-control' id='valorTotal' placeholder='Ingresa el Valor Total de la moto'/>
                </div>
                <div className='form-group'>
                    <label htmlFor='cliente'>Cliente</label>
                    <input ref={Cliente} type='number' className='form-control' id='cliente' placeholder='Ingresa la Identificación del cliente'/>
                </div>
                <button className='btn btn-primary mt-3 mb-2' type='submit'>Crear Compra</button>
            </form>
            <Link className='link' to='/' >Volver</Link>
        </div>
    </>
    )
}

export default Motos