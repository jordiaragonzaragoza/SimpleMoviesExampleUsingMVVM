# Teoría patrón MVVM

## Model 
Representa la estructura, los datos y la lógica de los **PROCESOS EMPRESARIALES**

## ViewModel
Representa la estructura, los datos y la lógica que requiere la **VISTA** 

El ViewModel es el puente entre la vista y el modelo.

1. Expone propiedades a las que se puede enlazar una vista
2. Ideal para propiedades calculadas del modelo.
3. La finalidad del modelo de vista es proporcionar a la vista la estructura y los datos que necesita.
4. El ViewModel está directamente relacionado con una vista pero no tiene porque tener una relacción explicita con un modelo. (Puede acceder a varios para montar la vista)
5. Pueden haber ViewModels diferentes basados en la misma clase del modelo.
6. Pueden haber ViewModels que se utilicen en varias vistas. Si la recuperación de datos para ambas vistas supone una gran sobre carga mejor separar y tener un ViewModel diferente para cada vista.
