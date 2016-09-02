# AsyncSocket.Connect Method 
 

Attempt to create a TCP socket connection

**Namespace:**&nbsp;<a href="N_RemoteSurf">RemoteSurf</a><br />**Assembly:**&nbsp;RemoteSurf (in RemoteSurf.exe) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public Task<bool> Connect(
	string hostIP,
	int hostPort
)
```


#### Parameters
&nbsp;<dl><dt>hostIP</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/s1wwdcbf" target="_blank">System.String</a><br />IP of the server</dd><dt>hostPort</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/td2s409d" target="_blank">System.Int32</a><br />Port server</dd></dl>

#### Return Value
Type: <a href="http://msdn2.microsoft.com/en-us/library/dd321424" target="_blank">Task</a>(<a href="http://msdn2.microsoft.com/en-us/library/a28wyd50" target="_blank">Boolean</a>)<br />true if connection was successful, false if connection failed

## See Also


#### Reference
<a href="T_RemoteSurf_AsyncSocket">AsyncSocket Class</a><br /><a href="N_RemoteSurf">RemoteSurf Namespace</a><br />