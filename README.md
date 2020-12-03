# Blazor5Tailwind
A Blazor Wasm App with the following (these are the goals)
- Tailwind Integration
- Including PostCSS
- Tailwind in separate project as I don't want to clutter up Blazor app with node/npm/config files
- Recreate Blazor demo style with Tailwind
- Production tree-shaking of Tailwind

The goal of this is to learn tailwind and end up with it fully integrated with Blazor.

## Notes
Have basic postcss commands in package.json; was hoping to avoid gulp, but as I worked on it, I realized I wanted both regular and min files produced to the wwwroot/css folder, which needs gulp.



### References
[Matt Ferderer's Post] (https://mattferderer.com/tailwind-with-blazor)
[Chris Sainty's Post] (https://chrissainty.com/integrating-tailwind-css-with-blazor-using-gulp-part-1/)