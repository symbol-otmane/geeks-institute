# 💎 Crystal Rift: Game Design & Production Document

## 1. Game Production Pipeline
The pipeline ensures that **Crystal Rift** moves from a concept to a finished product through a structured, logical workflow.

| Phase | Focus | Key Output | Color Code |
| :--- | :--- | :--- | :--- |
| **Pre-Production** | Vision, GDD, & Prototypes | **Design Blueprint** | <font color="#3498db">🔵 BLUE</font> |
| **Production** | Assets, Systems, & Levels | **Playable Build** | <font color="#e67e22">🟠 ORANGE</font> |
| **Post-Production** | Polish, Testing, & Release | **Final Release** | <font color="#2ecc71">🟢 GREEN</font> |



### Phase Descriptions
* **Pre-production:** Establishes the vision and scope of *Crystal Rift* through a lightweight GDD and early prototypes. This stage is critical for "failing fast" and refining mechanics before heavy coding starts.
* **Production:** The primary execution phase where we build gameplay systems, 3D assets, and levels inside Unity. This is where the mechanics meet the art.
* **Post-production:** Refines the experience through rigorous QA testing, bug fixing, and optimization to ensure the final release is polished and stable.

---

## 2. Team Roles & Interaction Map
The success of *Crystal Rift* depends on clear communication and defined responsibilities.

### Role Descriptions
* **Game Designer:** Defines mechanics, rules, and the overall player experience.
* **Programmer:** Implements core systems (movement, collection) and optimizes performance.
* **Artist:** Creates stylized low-poly characters, environments, and UI elements.
* **Sound Designer:** Produces magical sound effects and ambient soundtracks.
* **QA Tester:** Identifies bugs and provides feedback on difficulty and gameplay balance.
* **Producer:** Manages tasks, schedules, and ensures team communication is fluid.



> **Interaction Map Summary:** The **Producer** acts as the central coordinator. The **Game Designer** provides the blueprint for both the **Artist** and **Programmer**. As systems are built, **QA** tests them and sends feedback loops back to the developers for iteration.

---

## 3. Rapid Prototyping Exercise
**Tested Mechanic:** Crystal Collection & Enemy Avoidance.

* **Prototype Type:** Digital Unity Mockup.
* **Peer Feedback:** "The collection feel is satisfying, but the enemy movement speed makes the first level feel too punishing."
* **Reflection:** Early prototyping was vital. It proved the core 'fun' of the loop but highlighted that **enemy speed variables** need to be easily adjustable (exposed in the inspector) to balance the game effectively.

---

## 4. Mini Game Design Document (GDD)
**Game Title:** Crystal Rift  
**Genre:** Action-Adventure / Platformer

### <font color="#3498db">Core Gameplay Loop</font>
1. **Explore** (Navigate the rift)
2. **Avoid/Fight** (Interact with enemies)
3. **Collect** (Gather crystals)
4. **Upgrade** (Improve dash/jump)
5. **Unlock** (Access new areas)



* **Target Audience:** Casual to mid-core players (Ages 12+).
* **Key Mechanics:** Precision jumping, crystal-powered dashes, and environment puzzles.
* **Art Style:** **Stylized Low-Poly Fantasy.** High-contrast environments with glowing neon crystals to guide the player's path.

---

## 5. Post-Mortem Reflection
**What went well:** Strong pre-production planning significantly reduced "rework" by identifying flaws in the collection mechanic early.

**Potential Challenges:** * **Scope Creep:** Adding too many levels could delay the release date. 
* **Asset Creation:** Low-poly art is fast, but lighting glowing crystals in Unity requires specific technical setup.

**Final Thought:** Improving playtesting frequency and maintaining a transparent task board (like Trello or Jira) would further increase team efficiency.