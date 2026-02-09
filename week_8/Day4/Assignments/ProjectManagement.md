# Assignment 1 — Critical Path Analysis & Time Estimation

## Game Concept
**Top-Down Space Shooter** with 3 levels, upgradeable weapons, and enemy waves.

---

## Milestones

### First Playable
- Controllable spaceship
- One playable arena level
- Basic enemy ship prototype

### Alpha Build
- All core mechanics complete
- 3 playable levels
- Weapon upgrades functional
- Basic UI (health, score, ammo)

**Alpha Release Gate Criteria**
- Runs at 60 FPS on mid-spec hardware for 1 hour
- Zero critical (blocking) bugs

### Beta Build
- Polished levels and assets
- Enhanced UI/UX
- Balanced enemy waves
- External playtest ready

---

## Epic Breakdown (Alpha): Ship Combat System

### Tasks (Ideal Hours)

| # | Task | Ideal Hours |
|---|---|---|
| 1 | Combat design specification | 6 |
| 2 | Ship movement input | 8 |
| 3 | Weapon firing system | 10 |
| 4 | Projectile collision detection | 12 |
| 5 | Enemy damage handling | 8 |
| 6 | Player damage handling | 8 |
| 7 | Health & shield logic | 6 |
| 8 | Combat feedback (FX/SFX) | 10 |
| 9 | Combat balancing & tuning | 12 |
|10 | Playtesting & fixes | 10 |

**Total Ideal Hours:** 90  
**15% Buffer:** +13.5 hours  
**Total Scheduled Time:** **103.5 hours**

---

## Dependency Mapping (Gantt Logic)

1. Combat design → Ship movement input  
2. Ship movement → Weapon firing system  
3. Weapon firing → Projectile collision detection  
4. Projectile collision → Enemy damage handling  
5. Enemy damage → Player damage handling  
6. Player damage → Health & shield logic  
7. Health logic → Combat feedback  
8. Combat feedback → Combat balancing  
9. Combat balancing → Playtesting & fixes

---

## Critical Path Analysis

**Critical Path:**  
Combat Design → Ship Movement → Weapon Firing → Projectile Collision → Enemy Damage → Player Damage → Health & Shield → Feedback → Balancing → Playtesting

**Critical Task:**  
**Projectile Collision Detection**  
Any delay here blocks all downstream combat tasks and directly pushes the Alpha deadline.

---

# Assignment 2 — Scrum Board Setup & Process Enforcement

## Tool
**Jira (Scrum Board)**

---

## Epics
- EPIC 1: Ship Core Systems  
- EPIC 2: Combat & Enemy Waves

---

## Workflow Columns
- Product Backlog  
- Current Sprint  
- In Progress (**WIP Limit: 3**)  
- Code Review  
- QA / Verification  
- Done

---

## User Stories (Sample with Story Points)

| Story | Epic | SP | Role |
|---|---|---|---|
| Ship movement | Core | 5 | Programmer |
| Boost mechanics | Core | 3 | Programmer |
| Camera follow | Core | 2 | Programmer |
| Basic laser attack | Combat | 5 | Programmer |
| Projectile collision | Combat | 8 | Programmer |
| Enemy AI waves | Combat | 5 | Programmer |
| Health & shields | Core | 3 | Programmer |
| Combat FX | Combat | 3 | Artist |
| UI health bar | Core | 2 | UI Designer |
| Combat tuning | Combat | 5 | Designer |

---

## Definition of Done (Gameplay Code Feature)

1. Code reviewed by Lead Programmer  
2. Integrated into latest build  
3. No critical bugs after 1-hour QA test  
4. Meets performance budget (60 FPS)  
5. Documented behavior and parameters

---

# Assignment 3 — Formal Risk Register

| ID | Risk Description | Category | L x I | Exposure | Owner | Prevention Strategy | Contingency Plan |
|---|---|---|---|---|---|---|---|
| R01 | Projectile system fails at high load | Technical | 4 x 5 | 20 | Lead Programmer | Early technical spike | Simplified projectile system |
| R02 | Combat system not fun | Design | 4 x 4 | 16 | Game Designer | Early vertical slice tests | Adjust enemy behavior or weapons |
| R03 | Scope creep | Scope | 5 x 4 | 20 | Producer | Scope lock after Alpha | Cut non-core features |
| R04 | Programmer burnout | Personnel | 3 x 4 | 12 | Producer | Sprint WIP limits | Reassign tasks / reduce features |
| R05 | Performance issues on low-end devices | Technical | 3 x 5 | 15 | Tech Lead | Continuous profiling | Reduce particle effects / downgrade visuals |
