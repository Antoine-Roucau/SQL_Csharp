# VeloMax - Bicycle Management System with Alexandre Allaire

## Overview
VeloMax is a comprehensive management system for bicycle shops, built with C# and MySQL. The application provides interfaces for administrators and customers to handle inventory, sales, and customer relationships.

## Features
- **Multi-user Interface**:
  - Admin portal with complete system management
  - Customer interface for shopping and order tracking
  - Statistical reporting module

- **Inventory Management**:
  - Track bicycles and individual parts
  - Monitor stock levels
  - Manage suppliers and orders

- **Customer Management**:
  - Individual and corporate customer profiles
  - Loyalty program (Fidelio) with multiple subscription levels
  - Order history tracking

- **Sales Features**:
  - Process sales of bicycles and parts
  - Automatic inventory updates
  - Backorder management for out-of-stock items

- **Reporting**:
  - Sales analysis by product, store, and salesperson
  - Customer loyalty program statistics
  - Stock level monitoring and alerts

## Technical Details
- Built with C# and .NET 7.0
- MySQL database backend
- Console-based user interface
- Modular architecture for easy maintenance


## Installation
1. Set up MySQL server and import the SQL schema files from the `/Serveur` directory
2. Configure the connection strings in the application to match your database settings
3. Build and run the C# application

## Usage
Run the application and use the arrow keys to navigate the menu system. Select the appropriate user mode (Admin/Client) to access different features.