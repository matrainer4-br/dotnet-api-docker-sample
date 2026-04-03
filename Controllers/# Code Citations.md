# Code Citations

## License: MIT
https://github.com/CodeMazeBlog/CodeMazeGuides/blob/a022c0ee66cb52fe840381bb4f2ed0f95c81a5aa/csharp-architectural-patterns/ClientServerArchitecture/ClientServerArchitecture/ClientServerArchitecture.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: desconhecido
https://github.com/RassadinDan/homework19/blob/9866fd37812a9d54d69d50809a895e3a600890d0/ContactWebAPI/ContactWebAPI.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: desconhecido
https://github.com/MohammedAlsayed/crm-backend-asp8/blob/6f767352501cb7da85b7a967a118d1a53ce2832a/asp.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: desconhecido
https://github.com/ncosentino/DevLeader/blob/b30edc8f64f0f9c1b3ea97adc6bf4186994facd4/SocialReach/SocialReach/SocialReach.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: MIT
https://github.com/dotnet/EntityFramework.Docs/blob/22c610f555abef0e07db1e3cfe8eef12c92e427d/samples/core/Miscellaneous/Multitenancy/MultiDb/MultiDb.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: desconhecido
https://github.com/zgcwkj/zgcwkj.DotnetCore/blob/450c4ef44cb915b8f97e1322b337479105249d7a/zgcwkj.Model/zgcwkj.Model.csproj

```
="Microsoft.NET.Sdk.Web">

  <PropertyGroup>
    <TargetFramework>net8.0</TargetFramework>
    <Nullable>enable</Nullable>
    <ImplicitUsings>enable</ImplicitUsings>
  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="8.0.0" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="8.0.0" />
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.4.0" />
  </ItemGroup>

<
```


## License: desconhecido
https://github.com/Radar-Dotnet/Back-end-api/blob/c6580033c95da200740fcfc96542682b0c3f3582/projeto-radar-backend/Controllers/ProdutoController.cs

```
}

    [HttpPost]
    public async Task<ActionResult<Produto>> PostProduto(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduto(int id, Produto produto)
    {
        if (id != produto.Id) return BadRequest();
        _context.Entry(produto).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
```


## License: desconhecido
https://github.com/Leme-do-Prado/TP4SW2/blob/8f50cc31c713996c5b53a181eb9c6051f0bde62b/ProjectAPI/ProjectAPI/Controllers/ProdutoController.cs

```
}

    [HttpPost]
    public async Task<ActionResult<Produto>> PostProduto(Produto produto)
    {
        _context.Produtos.Add(produto);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutProduto(int id, Produto produto)
    {
        if (id != produto.Id) return BadRequest();
        _context.Entry(produto).State = EntityState.Modified;
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
```

