#include <string.h>
#include <unistd.h>
#include <stdlib.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <stdio.h>
#include <pthread.h>
//A?adimos la libreria mysql
#include <mysql.h>

typedef struct {
	
	char nombre[20];
	int socket;
	
}TConectado;

typedef struct {
	
	TConectado conectados[100];
	int num; 
	
}TListaCon;


TListaCon lista;

int i;
int sockets[100];
char cadenafinal[200];

int Pon ( TListaCon *lista, char nombre [20], int socket)
{
	if(lista->num == 100) // ya hay 100 elementos
		return 0;
	else 
	{
		lista->conectados[lista->num].socket = socket;
		strcpy(lista->conectados[lista->num].nombre,nombre);
		lista->num ++;
		return 1; // todo ha ido bien
	}
}



int Eliminar ( TListaCon *lista, char nombre [20] )
{
	int encontrado = 0;
	
	int pos = DamePosicion(&lista, nombre);
	printf("%s\n", lista->conectados[pos].nombre);
	
	if(pos == -1){
		return pos;
	}
	else{
		for(int i = pos; i<lista->num-1; i++){
			lista->conectados[i].socket = lista->conectados[i+1].socket;
			strcpy(lista->conectados[i].nombre, lista->conectados[i+1].nombre);
		}
		lista->num--;
		printf("%s\n", lista->conectados[pos].nombre);
		return 0;
	}
}

int DameSocket (TListaCon *lista, char nombre [20])
{
	int encontrado = 0;
	int i = 0;
	
	while ((i < lista->num) && (!encontrado))
	{
		if (strcmp ( lista->conectados[i].nombre, nombre) ==0)
			encontrado = 1;
		else
			i++;
	}
	
	if (!encontrado)
		return lista->conectados[i].socket;
	else 
		return -1;
}

int DamePosicion (TListaCon *lista, char nombre [20])
{
	int encontrado = 0;
	int i = 0;
	
	while ((i < lista->num) && (!encontrado))
	{
		if (strcmp ( lista->conectados[i].nombre, nombre) ==0)
			encontrado = 1;
		else
			i++;
	}
	
	if (!encontrado)
		return i;
	else 
		return -1;
}

void Cadena (TListaCon *lista, char cadenafinal [100])
{
	
	char cadena[200];
	int cont=0;
	
	for (int i=0;i<lista->num;i++){
		printf("%s\n",lista->conectados[lista->num].nombre);
		sprintf (cadena,"%s\%s",cadena,lista->conectados[i].nombre);
		cont ++;
	}
	
	sprintf(cadenafinal,"5/%d\%s", lista->num, cadena);
	printf("%s\n",cadenafinal);
	
}

int LogIn(char nombre[20],char contra[20]){
	
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta[80];
	char res[80];
	
	
	//parte de mysql
	
	char nom[20], cnt[20]; //variables para comparar nombre y contrase?a
	
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "parchis",0, NULL, 0);
	
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy(consulta,"SELECT Jugador.Nombre,Jugador.Pass FROM Jugador WHERE Jugador.Nombre = '");
	strcat(consulta, nombre);
	strcat(consulta, "'");
	
	
	err=mysql_query (conn, consulta);
	
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	
	if (row == NULL) printf ("No se han obtenido datos en la consulta\n");
	
	else
	{
		strcpy(nom,row[0]);
		strcpy(cnt,row[1]);
		
		printf("nombre recibido: %s, contra recibida: %s\n", nom, cnt);
		row = mysql_fetch_row (resultado);
	}
	
	if(strcmp(nom,nombre) == 0  && strcmp(cnt,contra) == 0)
	{
		return 0;
	}
	
	else
	   return 1;
	
	//sprintf(respuesta,"%s",res);	
}

void EdadColor(char p[80], char respuesta[200]) {
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta[200];
	char res[80];
	
	//Arrancamos atributo
	p = strtok(NULL, "/");
	char color[20];
	strcpy (color, p);
	//miramos por pantalla si realmente llega el color bien
	printf("color: %s\n", color);
	//Variable interna 
	int edad;
	
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "parchis",0, NULL, 0);
	
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy(consulta,"SELECT AVG(Jugador.Edad) FROM Jugador, Relacion, Partida WHERE Jugador.Id = Relacion.IdJugador AND Relacion.IdPartida = Partida.Id AND Relacion.Color ='");
	strcat(consulta, color);
	strcat(consulta, "'");
	
	err=mysql_query (conn, consulta);
	
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	
	if (row == NULL) printf ("No se han obtenido datos en la consulta\n");
	else{
		edad = atoi(row[0]);
		printf("Edad recibida: %d\n", edad);
		row = mysql_fetch_row (resultado);
	}		
	sprintf(respuesta,"2/%d",edad); //convertimos a string el entero "edad" y se lo copiamos a respuesta
	
	
}
void GanadorFecha (char p[80], char respuesta[200]){
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta [80];
	char res [80];
	
	// arrancamos 
	p = strtok(NULL, "/");
	char fecha[20];
	strcpy(fecha,p);
	p=strtok(NULL,"/");
	
	// hacemos mysql
	printf("fecha: %s\n", fecha); //2018-06-13
	
	conn = mysql_init(NULL);
	
	if (conn==NULL) {
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "parchis",0, NULL, 0);
	
	if (conn==NULL) {
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy(consulta,"SELECT Partida.Ganador FROM Partida WHERE Partida.Fecha='");
	strcat(consulta, fecha);
	strcat(consulta, "'");
	printf("hay: %s\n",consulta);
	err=mysql_query (conn, consulta);
	
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	
	if (row == NULL) printf ("No se han obtenido datos en la consulta\n");
	else{
		
		sprintf(resultado ,"%s\n",row[0]);
		row = mysql_fetch_row (resultado);
	}		
	sprintf(respuesta,"3/%s\n",resultado);
	
	
}


void PorcentajeColor(char p[80], char respuesta[200])   {
	
	
	MYSQL *conn;
	int err;
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	char consulta [80];
	char res[80];
	int total_jugadores;
	int jugador_color;
	float tanto_porciento;
	
	//arrancamos
	p = strtok(NULL, "/");
	char color[20];
	strcpy (color, p);
	//miramos por pantalla si realmente llega el color bien
	printf("color: %s\n", color);
	//Variable interna 
	
	
	conn = mysql_init(NULL);
	
	if (conn==NULL) 
	{
		printf ("Error al crear la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	conn = mysql_real_connect (conn, "localhost","root", "mysql", "parchis",0, NULL, 0);
	
	if (conn==NULL)
	{
		printf ("Error al inicializar la conexion: %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	strcpy (consulta,"SELECT count(*) FROM Relacion");
	err=mysql_query (conn, consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//recogemos el resultado de la consulta. El resultado de la
	//consulta se devuelve en una variable del tipo puntero a
	//MYSQL_RES tal y como hemos declarado anteriormente.
	//Se trata de una tabla virtual en memoria que es la copia
	//de la tabla real en disco.
	resultado = mysql_store_result (conn);
	// El resultado es una estructura matricial en memoria
	// en la que cada fila contiene los datos de una persona.
	
	// Ahora obtenemos la primera fila que se almacena en una
	// variable de tipo MYSQL_ROW
	row = mysql_fetch_row (resultado);
	
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		//En la columna 0 esta el valor total de jugadores y lo guardo en la variable total_jugadores
		printf ("Los jugadores que han jugado en las partidas es : %s\n", row[0]);
	total_jugadores = atol(row[0]);
	
	
	
	
	
	//Cuento el total de jugadores que han jugado una partida con el colorespecifico
	strcpy (consulta,"SELECT count(*) FROM Relacion WHERE Color = '");
	strcat (consulta, color);
	strcat (consulta,"'");
	
	err=mysql_query (conn, consulta);
	
	
	
	if (err!=0) 
	{
		printf ("Error al consultar datos de la base %u %s\n", mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	
	resultado = mysql_store_result (conn);
	
	row = mysql_fetch_row (resultado);
	
	if (row == NULL) printf ("No se han obtenido datos en la consulta\n");
	else
	{
		printf ("El total de jugadores que han jugado con el %s es : %s\n", color, row[0]);
		jugador_color = atol(row[0]);
	}	
	
	tanto_porciento = ((float )jugador_color / (float) total_jugadores)*100;
	//respuesta = jugador_color;
	//strcpy(respuesta, jugador_color);
	sprintf(respuesta,"4/%.2f",tanto_porciento);
	printf ("El tanto porciento de jugadores %s es: %.2f %\n", color, respuesta);
}

int contador;


pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;

void *AtenderCliente(void *socket){
	
	int sock_conn;
	int *s;
	s= (int *) socket;
	sock_conn= *s;
	
	
	char peticion[512];
	char respuesta[512];
	int ret;
	int res;
	
	
	
	int terminar =0;
	// Entramos en un bucle para atender todas las peticiones de este cliente
	//hasta que se desconecte
	while (terminar ==0)
	{
		// Ahora recibimos la petici?n
		ret=read(sock_conn,peticion, sizeof(peticion));
		printf ("Recibido\n");
		
		// Tenemos que a?adirle la marca de fin de string 
		// para que no escriba lo que hay despues en el buffer
		peticion[ret]='\0';
		
		
		printf ("Peticion: %s\n",peticion);
		
		// vamos a ver que quieren
		char *p = strtok( peticion, "/");
		int codigo =  atoi (p);
		// Ya tenemos el c?digo de la petici?n
		char nombre[20];
		
		if (codigo == 0)
		{ //salimos del bucle
			
			terminar = 1;
			
			int res = Eliminar(&lista,nombre); 
			if(res==0)
				printf("Se ha eliminado correctamente\n");
			else 
				printf("No hay elemento a eliminar!! merluzo\n");
			
			Cadena(&lista,respuesta);
			
			
		}
		
		else if (codigo == 1) // consulta 1: nombre y contrase?a en la base de datos?
		{	
			
			//arrancamos los atributos nombre y contra 
			p = strtok(NULL, "/");
			char nombre[20];
			strcpy (nombre, p);
			p = strtok(NULL, "/");
			char contra[20];
			strcpy (contra, p);
			printf ("Nombre: %s, Contra: %s\n", nombre, contra);
			
			res=LogIn(nombre,contra); 
			
			if (res==0)
				strcpy(respuesta,"1/SI"); 
			else
				strcpy(respuesta,"1/NO"); 
			//LogIn(p, respuesta); 
			
			if(strcmp(respuesta,"1/SI")==0)
			{
				res = Pon(&lista,nombre,sock_conn);
				
				if(res==1)
				{
					printf("Se ha a?adido correctamente--\n");
				
				    Cadena(&lista,cadenafinal);
					
					for(int i=0;i<lista.num;i++){
						write(sockets[i],cadenafinal, strlen(cadenafinal));						
					}
				}
				else 
				   {
					printf("Lista llena !! merluzo\n");
				   }
			}
			
			
	
		
			
		}
		else if (codigo == 2) //consulta 2: edad media de los jugadores que han ganado con el color pasado como parametro
		{
			EdadColor(p, respuesta);
		}
		else if (codigo== 3) // consulta 3: ganador con esa fecha 
		{
			GanadorFecha(p, respuesta);
		}
		
		else if (codigo == 4) //consulta 2: edad media de los jugadores que han ganado con el color pasado como parametro
		{
			PorcentajeColor(p, respuesta);
		}
		
		
	/*	else if (codigo == 6) //dame el socket
		{
			int res = DameSocket(&lista, nombre);
			if(res != -1){
				sprintf(respuesta,"6/%d",res);
			}else
			   sprintf(respuesta,"6/No hay socket para ese jugador");
		}
		else if (codigo == 7) //dame la posicion
		{
			DamePosicion(&lista, nombre);
		}
		
		
		*/
		
		if (codigo !=0)
		{
			
			printf ("Respuesta: %s\n", respuesta);
			//Enviamos respuesta
			write (sock_conn,respuesta, strlen(respuesta));
		}
		
		if ((codigo ==1)||(codigo==2)|| (codigo==3)|| (codigo==4)|| (codigo==5))
		{
			pthread_mutex_lock( &mutex ); //No me interrumpas ahora
			contador = contador +1;
			pthread_mutex_unlock( &mutex); //ya puedes interrumpirme
			
			// notificar a todos los clientes conectados
			char notificacion[20];
			sprintf (notificacion, "6/%d",contador);
			
			int j;
			for (j=0; j< i; j++)
				write (sockets[j],notificacion, strlen(notificacion));
		}
		
		
	}
	
	
	close(sock_conn); 
}



int main(int argc, char *argv[])
{
	
	int sock_conn, sock_listen;
	struct sockaddr_in serv_adr;
	
	// INICIALITZACIONS
	// Obrim el socket
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Fem el bind al port
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicialitza a zero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la m?quina. 
	//htonl formatea el numero que recibe al formato necesario
	serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9051);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");
	
	
	pthread_t thread;
	i=0;
	
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		
		sockets[i] =sock_conn;
		//sock_conn es el socket que usaremos para este cliente
		
		// Crear thead y decirle lo que tiene que hacer
		
		pthread_create (&thread, NULL, AtenderCliente,&sockets[i]);
		i=i+1;
		
		
		
	}
	
	
	
}