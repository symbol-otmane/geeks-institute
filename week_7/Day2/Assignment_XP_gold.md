# Gold Level — Production Documentation  
## 2D Platformer Project

---

## Step 1 — Project Overview (≈170 words)

**Project Name:** Neon Drift  
**Genre:** 2D Platformer  
**Target Platform:** PC  
**Target Audience:** Casual to mid-core players (ages 12–30) who enjoy fast-paced platforming, reflex challenges, and neon-styled environments  

**Team Size & Roles:**  
- 1 Game Designer (level design, mechanics, difficulty balance)  
- 1 Developer (movement, dash mechanics, hazards, UI)  
- 1 Artist (stylized neon sprites, simple effects, UI placeholders)  

**Duration & Milestones:**  
- Total duration: 6 weeks  
- Week 1: Paper prototype & core loop validation  
- Weeks 2–3: Core mechanics (running, jumping, dash, collectibles)  
- Weeks 4–5: Level design (4 neon zones) & progression  
- Week 6: Polish, bug fixing, and playtesting  

**Project Goal & Vision:**  
Neon Drift is a compact 2D platformer focused on fast-paced movement, precise dashing, and rewarding exploration. The vision was to create a playable prototype demonstrating responsive core mechanics and smooth level flow using minimal assets, while emphasizing player feedback and clarity. The game prioritizes fluid movement and a visually striking neon aesthetic, ensuring an engaging experience even with placeholder graphics.

---

## Step 2 — Development Report (≈350 words)

The project was developed using **Unity 2D** with the built-in physics system and URP for consistent neon-style lighting effects. Development followed a **prototype-first workflow**, starting with a paper prototype to validate the core loop: run → jump → dash → collect → progress.

The first development phase focused on **player movement**, including running, jumping, and dash mechanics. Dash responsiveness was prioritized early, as it influenced timing for hazards and collectible placement. Platforms, hazards, and collectibles were implemented next, with simple placeholder sprites and neon-colored indicators.

Level design began with **greyboxing**, creating four distinct zones with increasing difficulty. Each zone introduced new hazards such as moving platforms, laser barriers, or timed spikes, gradually teaching players new skills. Collectibles were placed to encourage exploration while maintaining a smooth flow.

Scope management was critical due to time constraints. Advanced visual effects, enemy AI, and bonus mechanics were postponed to maintain a playable core loop. Mid-development playtests revealed that dashing was underutilized; level pacing was adjusted to incorporate dash-required sections, increasing player engagement.

Tasks were tracked on a lightweight task board, and weekly milestones ensured that a playable build existed at all times. Iterative testing allowed quick identification of movement issues, hazard timing errors, and collectible placement problems, ensuring a consistent experience throughout development.

---

## Step 3 — Problems Encountered (≈250 words)

1. **Collision Detection Issues**  
Player occasionally clipped into platforms or spikes during fast dashes due to edge cases in physics settings.  

2. **Level Difficulty Imbalance**  
Some zones were too easy, while later sections introduced sudden spikes in hazard density.  

3. **Dash Mechanics Underused**  
Players initially did not fully utilize the dash, reducing engagement with the core mechanic.  

4. **Visual Feedback Insufficient**  
Hazards and collectibles were sometimes unclear without distinct neon indicators.  

5. **Time Pressure & Scope Creep**  
Additional mechanic ideas were suggested mid-development, threatening milestone completion.

These problems impacted player experience, game flow, and team focus. Fast movement amplified collisions and difficulty spikes, while unclear feedback reduced player confidence in navigating hazards.

---

## Step 4 — Solutions & Adjustments (≈250 words)

Collision issues were resolved by refining collider shapes and adjusting physics materials to reduce clipping during fast dashes.  

Level difficulty was balanced by spacing hazards more evenly, introducing intermediate challenges, and providing subtle visual cues for timing.  

Dash engagement was increased by designing sections that required dashing to progress, and placing collectibles in dash-required positions to encourage mechanic usage.  

Visual feedback was improved by adding neon glow effects, particle highlights, and color-coded indicators for hazards and collectibles.  

Scope creep was controlled with a **feature lock milestone** after week three. Optional features were deferred until post-prototype, ensuring focus on polish and playable content.  

These solutions stabilized development, improved hazard clarity, and ensured consistent engagement with core mechanics.

---

## Step 5 — Post-Mortem Analysis (≈280 words)

### Successes
- Dash and movement mechanics felt responsive and satisfying.  
- Greyboxing allowed rapid iteration on level flow.  
- Playtests identified issues early, enabling effective balancing.  
- Scope limits ensured a playable prototype throughout development.  

### Failures
- Early zones were too easy and lacked challenge.  
- Dash mechanic initially underused due to level pacing.  
- Collision edge cases took more time to fix than expected.  

### Root Causes
Late validation of secondary systems (dash utilization, hazard pacing) caused engagement issues. Heavy early focus on movement mechanics left level difficulty and pacing less refined. Assumptions about player reflex skill led to imbalanced difficulty in later zones.

Despite these challenges, the prototype met its primary goal: demonstrating a complete core loop with responsive movement, dash mechanics, hazard navigation, and collectible-driven progression.

---

## Step 6 — Key Learnings (≈180 words)

### Technical
- Collision and physics for fast movement must be tested early.  
- Simple visual indicators can greatly improve mechanic clarity.  

### Design
- Gradual introduction of hazards helps balance difficulty.  
- Core mechanics should be reinforced in level design to ensure engagement.  

### Production / Team
- Strict scope management prevents feature creep.  
- Daily playable builds allow early identification of issues.  
- Documenting design and mechanics clarifies priorities and reduces repeated debates.

**Actionable Lesson:**  
Future platformers should integrate core mechanics into level design from the start and validate player engagement early to avoid last-minute reworks and ensure balanced, responsive gameplay.

---

## Step 7 — Optional Reflection

Documenting Neon Drift clarified development decisions, exposed root causes of problems, and highlighted trade-offs. The process provided a reference for future projects, improving team alignment and iterative design workflow.

---

**End of Document**