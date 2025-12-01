<div align="center">
  <a href="https://github.com/your-username/your-repo">
    
  <img src="https://img.shields.io/badge/.NET%208-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=aspnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Web%20API-6C4BEF?style=for-the-badge&logo=csharp&logoColor=white" />
  <img src="https://img.shields.io/badge/Entity%20Framework%20Core-3E8ACC?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/JWT%20Auth-FF9800?style=for-the-badge&logo=jsonwebtokens&logoColor=white" />

  </a>

  <h1>📘 Order Management API — Secure ASP.NET Core Web API</h1>

  <p>
    A secure <strong>Order Management API</strong> built using 
    <strong>ASP.NET Core Web API + Identity + JWT Authentication</strong> with 
    <strong>SQL Server (LocalDB)</strong> and <strong>EF Core</strong>.
    <br/><br/>
    Users must <strong>register</strong> and <strong>login</strong> to access the API and can perform  
    <strong>CRUD operations</strong> on their own orders.
  </p>

  <p>🧑‍💻 By <strong>Yashika</strong> | <a href="https://github.com/yashika-ishi/OrderManagementApi_Yashika">View Repository</a></p>
</div>

---

# ✨ Key Features

<ul>
  <li><strong>ASP.NET Core Web API</strong> (Secure Endpoints)</li>
  <li><strong>Identity + JWT Authentication</strong></li>
  <li><strong>Authorization</strong> with Bearer Token</li>
  <li><strong>EF Core + SQL Server (LocalDB)</strong></li>
  <li><strong>3 Seeded Orders</strong> + Predefined Demo User</li>
  <li>Protected <strong>CRUD</strong> for Orders</li>
  <li><strong>Swagger UI</strong> Enabled</li>
</ul>

---

# 📂 **Solution Explorer**
<div align="center">
  <img src="./Solution%20Explorer.png" width="300"/>
</div>

---

# 📸 **Project Structure**
<div align="center">
  <img src="./Project%20Structure%20image-1.png" width="500"/>-1  
  <img src="./Project%20Structure%20image-2.png" width="500"/>-2  
  <img src="./Project%20Structure%20image-3.png" width="500"/>-3  
  <img src="./Project%20Structure%20image-4.png" width="500"/>-4  
  <img src="./Project%20Structure%20image-5.png" width="500"/>-5  
  <img src="./Project%20Structure%20image-6.png" width="500"/>-6  
  <img src="./Project%20Structure%20image-7.png" width="500"/>-7  
  <img src="./Project%20Structure%20image-8.png" width="500"/>-8
</div>

---

# 🔐 **Authentication Flow — Postman**

## **1️⃣ Registration — Fetching Token (User Register)**
<div align="center">
  <img src="./Fetching%20Token%20Result%20-%20Postman%20(Register%20User).png" width="650"/>
</div>

---

## **2️⃣ Login — JWT Token Retrieval**
<div align="center">
  <img src="./Login%20JWT%20result%20-%20Postman%20(Token).png" width="650"/>
</div>

---

## **3️⃣ Unauthorized Access Test (401)**
<div align="center">
  <img src="./Unauthorized%20call%20test%20(401).png" width="650"/>
</div>

---

## **Adding Authorization Header (Bearer Token)**
<div align="center">
  <img src="./Header%20tab%20-Authorization%20%2B%20Bearer%20.png" width="600"/>
  <img src="./Add%20Authorization%20(Bearer%20Token).png" width="500"/>
  
  
</div>

---

# **4️⃣ CRUD Operations (Postman Screenshots)**

## **🟢 1. CREATE ORDER (POST)**
<div align="center">
  <img src="./CRUD1-%20CREATE%20ORDER.png" width="650"/>
</div>

---

## **🔵 2.1 READ — Get All Orders**
<div align="center">
  <img src="./CRUD2.1-%20READ%20(GET%20ALL%20ORDERS).png" width="650"/>
</div>

---

## **🔵 2.2 READ — Get Single Order**
<div align="center">
  <img src="./CRUD2.2-%20READ%20(GET%20SINGLE%20ORDER).png" width="650"/>
</div>

---

## **🟠 3. UPDATE ORDER**
<div align="center">
  <img src="./CRUD3%20-UPDATE%20(Order%20update).png" width="650"/>
</div>

---

## **🔴 4. DELETE ORDER**
<div align="center">
  <img src="./CRUD4-%20DELETE%20(Order%20delete).png" width="650"/>
</div>

---

# 📘 **Swagger UI**
<div align="center">
  <img src="./Swagger%20UI%20image-1.png" width="650"/>
  <img src="./Swagger%20UI%20image-2.png" width="650"/>
</div>

---

## 🏗 Project Architecture
```mermaid
graph TD

    %% -------------------------
    %%         API Layer
    %% -------------------------
    A["🌐 ASP.NET Core Web API<br/><br/>• AuthController<br/>• OrdersController"]

    %% -------------------------
    %%   Identity + JWT Layer
    %% -------------------------
    B["🟣 Identity + JWT<br/><br/>• ApplicationUser<br/>• UserManager / SignInManager<br/>• JWT Token Generator"]

    %% -------------------------
    %%     Service Layer
    %% -------------------------
    C["🟩 Service Layer<br/><br/>• OrderService"]

    %% -------------------------
    %%   Repository Layer
    %% -------------------------
    D["🟧 Repository Layer<br/><br/>• OrderRepository"]

    %% -------------------------
    %%   EF Core + SQL Server
    %% -------------------------
    E["🟨 EF Core ORM<br/>ApplicationDbContext"]
    F["🗄 SQL Server (LocalDB)<br/><br/>• Orders Table<br/>• AspNetUsers Table"]

    %% -------------------------
    %%           Flow
    %% -------------------------

    A --> B
    A --> C
    C --> D
    D --> E
    E --> F

    %% Style
    classDef box fill:#f7f7ff,stroke:#7a7a9a,stroke-width:1px,border-radius:10px;
    class A,B,C,D,E,F box;

