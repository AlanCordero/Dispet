< !DOCTYPE html >
< html lang = "en" >
< head >
    < meta charset = "UTF-8" >
    < meta name = "viewport" content = "width=device-width, initial-scale=1.0" >
    < title > Detalles del Producto</title>
    <link href = "css/bootstrap.min.css" rel= "stylesheet" >
</ head >
< body >

< div class= "container mt-5" >
    < !--Tarjeta del producto -->
    <div class= "card mb-4 shadow-lg" id = "product-details" >
        < div class= "row g-0" >
            < div class= "col-md-6" >
                < img src = "https://via.placeholder.com/500x400" class= "img-fluid rounded-start" alt = "Imagen del producto" >
            </ div >
            < div class= "col-md-6" >
                < div class= "card-body" >
                    < h3 id = "productName" class= "card-title text-primary" > Nombre del Producto</h3>
                    <p id = "productDescription" class= "card-text" > Descripción del producto aquí.</p>
                    <p id="productPrice" class= "card-text" >< strong > Precio:</ strong > $0.00 </ p >
                    < button class= "btn btn-success btn-lg w-100 mt-3" onclick = "addToCart()" > Agregar al Carrito</button>
                </div>
            </div>
        </div>
    </div>

    <!-- Sección de reseñas -->
    <h4 class= "mt-5" > Reseñas de Clientes</h4>
    <div id = "reviews" >
        < !--Las reseñas se llenarán dinámicamente -->
    </div>

    <!-- Formulario para agregar reseña -->
    <h5 class= "mt-4" > Deja tu Reseña</h5>
    <form onsubmit = "submitReview(event)" >
        < div class= "mb-3" >
            < label for= "user" class= "form-label" > Nombre </ label >
            < input type = "text" id = "user" class= "form-control" placeholder = "Tu nombre" required >
        </ div >

        < div class= "mb-3" >
            < label for= "comment" class= "form-label" > Comentario </ label >
            < textarea id = "comment" class= "form-control" rows = "3" placeholder = "Escribe tu comentario aquí" required ></ textarea >
        </ div >

        < div class= "mb-3" >
            < label for= "rating" class= "form-label" > Calificación </ label >
            < select id = "rating" class= "form-select" required >
                < option selected > Selecciona una calificación</option>
                <option value = "1" > 1 estrella</option>
                <option value = "2" > 2 estrellas</option>
                <option value = "3" > 3 estrellas</option>
                <option value = "4" > 4 estrellas</option>
                <option value = "5" > 5 estrellas</option>
            </select>
        </div>

        <button type = "submit" class= "btn btn-primary" > Enviar Reseña </ button >
    </ form >
</ div >

< script >
    // Simulación de cargar el producto desde Blazor
    function loadProductDetails(productId) {
    // Aquí puedes realizar una llamada de Blazor Interop para obtener el producto
    document.getElementById("productName").innerText = "Dispensador Inteligente";
    document.getElementById("productDescription").innerText = "Controla las porciones y horarios desde tu celular.";
    document.getElementById("productPrice").innerText = "$75.00";

    // Cargar reseñas (puedes reemplazarlo con datos de Blazor)
    const reviewsDiv = document.getElementById("reviews");
    reviewsDiv.innerHTML = `
            < div class= "border rounded p-3 mb-3 shadow-sm" >
                < p >< strong > Ana </ strong > < span class= "text-muted" > (⭐⭐⭐⭐⭐)</ span ></ p >
                < p >¡Excelente producto! Mi perro está feliz.</p>
            </div>
            <div class= "border rounded p-3 mb-3 shadow-sm" >
                < p >< strong > Carlos </ strong > < span class= "text-muted" > (⭐⭐⭐⭐)</ span ></ p >
                < p > Muy útil, aunque un poco caro.</p>
            </div>
        `;
    }

    function addToCart()
{
    alert("Producto agregado al carrito");
}

function submitReview(event)
{
        event.preventDefault();
    const user = document.getElementById("user").value;
    const comment = document.getElementById("comment").value;
    const rating = document.getElementById("rating").value;

    alert(`Reseña agregada: ${ user}, ${ rating}
    estrellas - ${ comment}`);
}

// Simulación de carga del producto al cargar la página
document.addEventListener("DOMContentLoaded", () => {
    loadProductDetails(1); // Puedes pasar el ID del producto
});
</ script >

</ body >
</ html >
