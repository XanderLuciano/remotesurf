# RemoteSurf.Connect_Clicked Method 
 

Attempt to connect to Verisurf

**Namespace:**&nbsp;<a href="N_RemoteSurf">RemoteSurf</a><br />**Assembly:**&nbsp;RemoteSurf (in RemoteSurf.exe) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
private void Connect_Clicked(
	Object sender,
	EventArgs e
)
```


#### Parameters
&nbsp;<dl><dt>sender</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/e5kfa45b" target="_blank">System.Object</a><br />\[Missing <param name="sender"/> documentation for "M:RemoteSurf.RemoteSurf.Connect_Clicked(System.Object,System.EventArgs)"\]</dd><dt>e</dt><dd>Type: <a href="http://msdn2.microsoft.com/en-us/library/118wxtk3" target="_blank">System.EventArgs</a><br />\[Missing <param name="e"/> documentation for "M:RemoteSurf.RemoteSurf.Connect_Clicked(System.Object,System.EventArgs)"\]</dd></dl>

## Remarks

Connects over localhost to default port API port. Updates labels and Text.

Creates 2 async loops to handle the socket connection

The first loop awaits incoming data from the Verisurf API server

The second loop sends device_info requests at the current refresh rate


## See Also


#### Reference
<a href="T_RemoteSurf_RemoteSurf">RemoteSurf Class</a><br /><a href="N_RemoteSurf">RemoteSurf Namespace</a><br />