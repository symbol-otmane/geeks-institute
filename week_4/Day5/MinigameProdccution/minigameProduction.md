# 🎮 Mini Game Production Project: Crystal Rift
**Project Code:** Game VeGAS | **Genre:** Action-Adventure | **Platform:** PC

---

## 1. Game Concept & Pre-Production (30%)

### <font color="#3498db">High Concept Statement</font>
*Crystal Rift* is a stylized action-adventure game where players explore dangerous zones, avoid or fight enemies, and collect powerful crystals to stop a growing world conflict. The core focus is on **strategic movement** and **evasion**.

### <font color="#3498db">Mini Game Design Document (Mini GDD)</font>

#### 🕹️ Core Mechanics
* **Movement:** Top-down / 2.5D fluid navigation.
* **AI:** Enemy patrol patterns and proximity-based chase behavior.
* **Economy:** Crystal collection system for progression.
* **Survival:** Health management and checkpoint recovery.

#### 🔄 Core Gameplay Loop
> **Explore** → **Avoid/Fight Enemies** → **Collect Crystals** → **Upgrade** → **Unlock New Areas**

#### 🎨 Art & Audio Direction
* **Visuals:** Stylized low-poly fantasy. High-contrast "glowing" crystals against soft-lit environments.
* **Audio:** Satisfying "chime" for pickups, aggressive "stinger" for enemy alerts, and ambient synth-fantasy BGM.

---

### <font color="#3498db">Pipeline Plan & Roles</font>

| Phase | Milestone | Priority |
| :--- | :--- | :--- |
| **Pre-Production** | GDD, Flowcharts, Whitebox Level | <font color="#3498db">High</font> |
| **Production** | Asset Modeling, C# Scripting, UI | <font color="#e67e22">Medium</font> |
| **Post-Production** | Bug Fixing, Balancing, Export | <font color="#2ecc71">Final</font> |

#### Team Roles & Responsibilities
* **Game Designer:** Defines mechanics, rules, and player experience.
* **Programmer:** Implements gameplay systems and prototype.
* **Artist:** Creates characters, environments, and UI.
* **Sound Designer:** Produces sound effects and ambient audio.
* **QA Tester:** Tests gameplay and reports bugs.
* **Producer:** Manages tasks, schedule, and communication.

---

## 2. Rapid Prototyping & Iteration (25%)

### <font color="#9b59b6">Prototype Description</font>
A digital Unity prototype was created. The player is a **Blue Cube**, enemies are **Red Spheres**, and crystals are **Glowing Yellow Diamonds**.

### <font color="#9b59b6">Playtest Feedback & Iteration</font>
* **Feedback:** *“The crystal pickup feels satisfying, but enemies move too fast for early gameplay.”*
* **Iteration:** Reduced enemy `NavMesh` speed by **30%**.
* **Reflection:** This adjustment transformed the game from "frustrating" to "challenging but fair."

---

## 3. Team Structure & Collaboration (20%)

### <font color="#e67e22">Workflow Simulation</font>
In this solo simulation, I adopted a **Vertical Slice** workflow:
1.  **Designer/Producer:** Set a 48-hour deadline for the prototype.
2.  **Artist/Programmer:** Synced weekly to ensure the "Dash" animation matched the code logic.
3.  **QA:** Performed "Edge Case" testing (e.g., trying to collect crystals through walls).

---

## 4. Post-Mortem & Reflection (25%)

### <font color="#2ecc71">Self-Evaluation</font>
* **What Went Well:** Pre-production planning prevented "feature creep." I stayed within the 2.5D scope.
* **Challenge:** Balancing the "Aggro Range" of enemies was harder than expected.
* **Lesson:** Pre-production is the most critical phase because it defines the **limits** of the project.

### <font color="#2ecc71">Summary of Lessons Learned</font>
* ✅ **Planning:** Strong pre-production saves hours of coding rework.
* ✅ **Prototyping:** Visualizing the "fun" early is better than polishing a boring mechanic.
* ✅ **Structure:** Clear roles improve focus, even in solo projects.

---

## 📈 Optional: Presentation Outline
* **Slide 1:** Concept & Low-Poly Inspiration.
* **Slide 2:** The Core Loop (Explore/Collect/Upgrade).
* **Slide 3:** Prototype Video Demo.
* **Slide 4:** Feedback & Balancing Results.
* **Slide 5:** Future Roadmap (Boss Fights & New Biomes).