using UnityEngine;
using System.Collections;

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections.Generic;

public class ListenerSocket {
#if false
    Socket listener;
    SocketAsyncEventArgs e = new SocketAsyncEventArgs();

    public ListenerSocket()
    {
        e.Completed += OnAcceptCompleted;
    }

    public void Listen( int port )
    {
        listener = new Socket( AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp );
        listener.Bind( new IPEndPoint( IPAddress.Any, port ) );
        listener.Listen( 10 );

        listener.AcceptAsync(e);
    }

    private void OnAcceptCompleted( object sender, SocketAsyncEventArgs e )
    {
        Debug.Log( "OnAcceptCompleted" );
    }
#else
    Socket listener;

    public ListenerSocket()
    {
    }

    public void Listen(int port)
    {
        listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        listener.Bind(new IPEndPoint(IPAddress.Any, port));
        listener.Listen(10);

        listener.BeginAccept((ar)=> {
            Debug.Log("Accept");
        }, null);
    }
#endif
}
