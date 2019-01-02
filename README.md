
# react-native-zendesk-tecnovix

## Getting started

`$ npm install react-native-zendesk-tecnovix --save`

### Mostly automatic installation

`$ react-native link react-native-zendesk-tecnovix`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-zendesk-tecnovix` and add `RNZendeskTecnovix.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNZendeskTecnovix.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNZendeskTecnovixPackage;` to the imports at the top of the file
  - Add `new RNZendeskTecnovixPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-zendesk-tecnovix'
  	project(':react-native-zendesk-tecnovix').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-zendesk-tecnovix/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-zendesk-tecnovix')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNZendeskTecnovix.sln` in `node_modules/react-native-zendesk-tecnovix/windows/RNZendeskTecnovix.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Zendesk.Tecnovix.RNZendeskTecnovix;` to the usings at the top of the file
  - Add `new RNZendeskTecnovixPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNZendeskTecnovix from 'react-native-zendesk-tecnovix';

// TODO: What to do with the module?
RNZendeskTecnovix;
```
  