<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="channel">
    <html>
      <body>
        <h2>Flick</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th style="text-align:left">Title</th>
            <th style="text-align:left">Description</th>
            <th> Picture</th>
          </tr>
          <xsl:for-each select="item">
            <tr>
              <td>
                <xsl:value-of select="title"/>
              </td>
              <td>
                <xsl:value-of select="description"/>
              </td>
              <td>
                <xsl:element name="img">
                  <xsl:attribute name="src">
                    <xsl:value-of select="link"/>
                  </xsl:attribute>
                </xsl:element>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>