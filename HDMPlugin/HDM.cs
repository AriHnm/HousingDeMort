<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <Version>1.5.8</Version>
    <TargetFramework>net7.0-windows</TargetFramework>
    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>
    <LangVersion>latest</LangVersion>
    <Platforms>x64</Platforms>
    <PlatformTarget>x64</PlatformTarget>
    <OutputType>Library</OutputType>
    <ProduceReferenceAssembly>false</ProduceReferenceAssembly>
    <PreserveCompilationContext>false</PreserveCompilationContext>
    <AppendTargetFrameworkToOutputPath>false</AppendTargetFrameworkToOutputPath>
    <OutputPath>$(AppData)\XIVLauncher\devPlugins\HousingPlugin</OutputPath>
  </PropertyGroup>

  <PropertyGroup>
    <DalamudLibPath>$(AppData)\XIVLauncher\addon\Hooks\dev\</DalamudLibPath>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="Dalamud">
      <HintPath>$(DalamudLibPath)Dalamud.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="FFXIVClientStructs">
      <HintPath>$(DalamudLibPath)FFXIVClientStructs.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="ImGui.NET">
      <HintPath>$(DalamudLibPath)ImGui.NET.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="ImGuiScene">
      <HintPath>$(DalamudLibPath)ImGuiScene.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="Lumina">
      <HintPath>$(DalamudLibPath)Lumina.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="Lumina">
      <HintPath>$(DalamudLibPath)Lumina.Excel.dll</HintPath>
      <Private>False</Private>
    </Reference>
  </ItemGroup>

  <ItemGroup>
    <PackageReference Include="System.Numerics.Vectors" Version="4.5.0" />
  </ItemGroup>

  <ItemGroup>
    <None Update="HDMPlugin.json">
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </None>
  </ItemGroup>
</Project>
