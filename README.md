# App for Launching and Hiding Airplayer

This Windows Forms application is designed to launch another program, "Airplayer" and hide its window upon launch. After completing these actions, the application will exit.

## Features

- Launches the "Airplayer" program with specified parameters.
- Choice latest version of protocol.
- Hides the window of the "Airplayer" program upon launch.
- Exits automatically after completing this tasks.

## Usage

0. If you want to use it, and don't want to chanhe anything, just download the latest relkease and go to step 4
1. Download or clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build the solution to generate the executable (`AirPlayerRunner.exe`).
4. Put original (`AirPlayer.exe`) in the same folder. You can use international english version or chinese version.
5. Make in windows Task Scheduler a task to run the file AirPlayerRunner.exe on windows start with admin privileges.
6. Enjoy automatically start.

## Important Notes

- **Administrator Privileges**: Ensure that the application is run with administrative privileges to enable launching and hiding of the "Airplayer" program's window.
  
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Contributing

Contributions are welcome! If you find any issues or would like to suggest improvements, please feel free to create an issue or submit a pull request.

## Acknowledgments

This project utilizes:
- C# (.NET Framework) for the Windows Forms application.
- [MIT License](LICENSE) for open-source licensing.

---

### Additional Resources

- [AirPlayerRunner GitHub Repository](https://github.com/AKikhaev/AirPlayerRunner)
