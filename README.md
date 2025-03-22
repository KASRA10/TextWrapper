# TextWrapper

# 📸 Image Preview
![TextWrapperScreenShotK10](https://github.com/user-attachments/assets/8f91112e-75ad-41b1-b167-3be02c033e55)

# 🎥 Video Preview
https://github.com/user-attachments/assets/fc29c1fa-970d-48c9-b050-bef23a0c9601

## Introduction
Welcome to TextWrapper! This is a simple Windows Forms application built in C# that allows users to input text, split it by spaces or tabs, and save the result as a text file in a user-selected folder. It's a lightweight tool designed for basic text processing and file management.

## About
TextWrapper is a desktop application created to demonstrate fundamental C# programming concepts using Windows Forms. The program provides a user-friendly interface where you can:
- Enter text in a textbox
- Select a folder to save your output
- Split the text into individual words or segments
- Save the result as a text file, with each segment on a new line

This project is ideal for beginners learning C# or anyone needing a simple text processing utility.

## What is C#?
C# (pronounced "C-sharp") is a modern, object-oriented programming language developed by Microsoft. It’s part of the .NET framework and is widely used for building Windows applications, web services, and games (via Unity). C# is known for its simplicity, type safety, and versatility, making it a great choice for this project.

## What is Windows Forms?
Windows Forms (WinForms) is a graphical user interface (GUI) framework included in .NET. It allows developers to create desktop applications with buttons, textboxes, and other controls using a drag-and-drop designer or code. TextWrapper uses Windows Forms to provide an intuitive interface for text input and file saving.

## What is Text Wrapper?
In this context, "Text Wrapper" refers to the functionality of this application. It "wraps" or processes input text by splitting it into individual pieces (based on spaces or tabs) and formatting them into a text file where each piece appears on its own line. It’s a simple yet practical example of text manipulation.

## What is List?
In C#, a `List<T>` is a dynamic, generic collection class from the `System.Collections.Generic` namespace. Unlike arrays, Lists can grow or shrink in size as needed. In TextWrapper, a `List<string>` is used to store the split text segments before saving them to a file.

## What is string.Split()?
The string.Split() method in C# is used to divide a string into an array of substrings based on specified delimiters (like spaces or tabs). In TextWrapper, we use:
TextBox_RTB.Text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();
