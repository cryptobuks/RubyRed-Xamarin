using System;

namespace CrossPlatformApp {
	public class MyClass {
		
		public MyClass() { 
			
		}

		public static int getRandomColorValue() {
			return (new Random()).Next(255);
		}
	}
}