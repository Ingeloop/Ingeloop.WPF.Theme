# Ingeloop.WPF.Theme
Ingeloop Branding Library for WPF (Icons, Colors, Animations)

The following projects are included:
- [Ingeloop.WPF.Icons](https://github.com/Ingeloop/Ingeloop.WPF.Icons)
- [Ingeloop.WPF.Core](https://github.com/Ingeloop/Ingeloop.WPF.Core)
- [Ingeloop.WPF.Design](https://github.com/Ingeloop/Ingeloop.WPF.Design)

## Quick guide:

### 1) Namespace:

Add the namespace as follow:

```xaml
xmlns:theme="clr-namespace:Ingeloop.WPF.Theme;assembly=Ingeloop.WPF.Theme"
```

All the Ingeloop namespaces can be included:

```xaml
xmlns:icons="clr-namespace:Ingeloop.WPF.Icons;assembly=Ingeloop.WPF.Icons"
xmlns:core="clr-namespace:Ingeloop.WPF.Core;assembly=Ingeloop.WPF.Core"
xmlns:design="clr-namespace:Ingeloop.WPF.Design;assembly=Ingeloop.WPF.Design"
xmlns:theme="clr-namespace:Ingeloop.WPF.Theme;assembly=Ingeloop.WPF.Theme"
```

### 2) Resource:

Load the resource to your UI, as follow:

```xaml
<ResourceDictionary Source="pack://application:,,,/Ingeloop.WPF.Theme;component/Resources/Theme.xaml"/>
```

### 3) Icons:

You can use Ingeloop icons as follow:

```xaml
<theme:IngeloopFullLogo/>
```

## Demo:

[Demo Project](https://github.com/Ingeloop/Ingeloop.WPF.Theme/tree/master/Ingeloop.WPF.Theme.Demo)
