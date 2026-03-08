English: 
MarolateCore is an advanced multi-layer project designed for managing and developing an organized system.  
The main goal is to provide a **scalable and extensible architecture** for domain management, business logic, web services, and AI modules.  
Key features:  
- Manage domain models and business rules  
- Provide APIs and web services for internal and external use  
- Integrate AI modules for processing and decision-making  
- Support real-time communication and notifications  
- Clear layering with strict dependency rules between layers


## Layers & Architecture

- **Web / API**: Presentation & Service Endpoints  
- **Application**: Business Logic  
- **Domain**: Core Models & Domain Rules  
- **Infrastructure / Persistence**: Database & External Resources Access  
- **AI Integration**: AI Module  
- **RealTime**: Real-Time Communications  
- **Shared**: Shared Components  

**Dependency Rules**:  

Web/API → Application → Domain
Infrastructure → Domain
Persistence → Domain
AI → Application + Domain
RealTime → Application
Shared → All
