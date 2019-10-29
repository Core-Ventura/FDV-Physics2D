# FDV-Physics2D
Pensando en una adaptación 2D del juego, selecciona un Sprite que te sirva para representar el personaje.
1) Mueve a tu personaje mediante las teclas de flechas.
2) Incorpora elementos físicos en tu escena que respondan a las siguientes restricciones:
   1) Objeto estático que ejerce de barrera infranqueable.
   2) Zona en la que los objetos que caen en ella son impulsados hacia adelante.
   3) Objeto que es arrastrado por otro a una distancia fija.
   4) Objeto que al colisionar con otros sigue un comportamiento totalmente físico.

Para la actividad he decidido crear una escena en la que nuestro personaje está encerrado en una prisión. Para ello he generado las siguientes clases:
1) **PlayerController:** encargada de controlar el movimiento del jugador.
2) **Spring:** que gestiona el trampolín.
3) **Wind:** representando a una zona que genera viento y empuja objetos con la etiqueta "Windy".

Los elementos con restricciones correspondientes son:
1) **Objeto estático que ejerce de barrera:** la cárcel en la que nuestro personaje está ubicado.
2) **Zona de empuje:** hay dos, un trampolín dentro de la prisión que afecta al jugador, y un ventilador que genera viento y empuja cubos que caerán cuando el jugador escape de la misma.
3) **Objeto arrastrado a una distancia fija:** el jugador arrastra una bola de hierro negra.
4) **Objeto que al colisionar con otros sigue un comportamiento totalmente físico:** los cubos que caen y son arrastrados por el viento e impactan con un gran bloque.


