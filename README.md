# Border Radius Previewer

A interactive web application built with Blazor Server that allows developers to visually preview and generate CSS `border-radius` properties. Adjust corner radii with intuitive sliders and see real-time updates on a preview shape.

## Features

- **Interactive Sliders**: Adjust X and Y radii for each corner (top-left, top-right, bottom-left, bottom-right) using MudBlazor sliders
- **Live Preview**: See changes instantly applied to a visual shape
- **CSS Generation**: Automatically generates the complete `border-radius` CSS property
- **Copy to Clipboard**: One-click copying of the generated CSS to your clipboard
- **Responsive Design**: Clean, modern UI built with MudBlazor components

## Prerequisites

- .NET 9.0 SDK
- A modern web browser

## Installation and Running

1. Clone the repository:
~~~bash
git clone https://github.com/yourusername/border-radius-previewer.git
cd border-radius-previewer
~~~

2. Restore dependencies:
~~~bash
dotnet restore
~~~

3. Run the application:
~~~bash
dotnet run
~~~

4. Open your browser and navigate to `https://localhost:5001` (or the URL shown in the console)

## Usage

1. Use the sliders to adjust the border radius for each corner:
   - Top-left corner: Adjust both X and Y radii
   - Top-right corner: Adjust both X and Y radii
   - Bottom-left corner: Adjust both X and Y radii
   - Bottom-right corner: Adjust both X and Y radii

2. Watch the preview shape update in real-time as you adjust the values

3. Click the "Copy CSS" button to copy the generated `border-radius` property to your clipboard

4. Paste the CSS into your stylesheet or inline styles

### Example Generated CSS

~~~css
border-radius: 25% 50% 75% 10% / 30% 60% 40% 20%;
~~~

This creates elliptical corners with different radii for each corner.

## Technologies Used

- **Blazor Server**: For server-side rendering and interactivity
- **.NET 9.0**: Latest .NET framework
- **MudBlazor**: Material Design components for Blazor
- **C#**: Primary programming language
- **CSS**: For styling the preview shape

## Project Structure

~~~
BorderRadiusPreviewer/
├── Components/
│   ├── Pages/
│   │   └── Home.razor          # Main page with sliders and preview
│   ├── Layout/
│   │   ├── MainLayout.razor    # Application layout
│   │   └── MainLayout.razor.css
│   ├── App.razor               # Root component
│   └── Routes.razor            # Routing configuration
├── Services/
│   └── ClipboardService.cs     # Service for clipboard operations
├── wwwroot/
│   └── app.css                 # Global styles
├── Program.cs                  # Application entry point
└── appsettings.json            # Configuration
~~~

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the LICENSE file for details.