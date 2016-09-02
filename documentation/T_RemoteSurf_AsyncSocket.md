# AsyncSocket Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Async Wrapper for TCPclient to allow proper async usage.


## Inheritance Hierarchy
<a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_self">System.Object</a><br />&nbsp;&nbsp;RemoteSurf.AsyncSocket<br />
**Namespace:**&nbsp;<a href="Documentation.md">RemoteSurf</a><br />**Assembly:**&nbsp;RemoteSurf (in RemoteSurf.exe) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public class AsyncSocket
```

The AsyncSocket type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="Documentation.md">AsyncSocket</a></td><td>
Creates a new AsyncSocket and sets the timeout (default 5 seconds)</td></tr></table>&nbsp;
<a href="#asyncsocket-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="Documentation.md">Connect</a></td><td>
Attempt to create a TCP socket connection</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="Documentation.md">Disconnect</a></td><td>
Disconnect from the socket</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="Documentation.md">ReadLineAsync</a></td><td>
Reads a line from the active socket connection asynchronously.</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="Documentation.md">SendAsync</a></td><td>
Send data to socket asynchronously</td></tr></table>&nbsp;
<a href="#asyncsocket-class">Back to Top</a>

## Fields
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="Documentation.md">connected</a></td><td>
Are we currently connected to the Versisurf API server?</td></tr><tr><td>![Private field](media/privfield.gif "Private field")</td><td><a href="Documentation.md">m_client</a></td><td /></tr><tr><td>![Private field](media/privfield.gif "Private field")</td><td><a href="Documentation.md">m_reader</a></td><td /></tr><tr><td>![Private field](media/privfield.gif "Private field")</td><td><a href="Documentation.md">m_stream</a></td><td /></tr><tr><td>![Public field](media/pubfield.gif "Public field")</td><td><a href="Documentation.md">timeout</a></td><td>
TCPclient timeout in ms</td></tr></table>&nbsp;
<a href="#asyncsocket-class">Back to Top</a>

## See Also


#### Reference
<a href="Documentation.md">RemoteSurf Namespace</a><br />