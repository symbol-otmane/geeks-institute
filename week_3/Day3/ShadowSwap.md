# Game Design Exercise: New Concept & Ideation

## 1. Game Concept: "Shadow Swap"

**Goal, Rules, & Core Loop** Reach the light portal by navigating a world where you can only walk on shadows. You have the power to "Swap" the light source to the opposite side of the room, instantly shifting the position of all shadows. The core loop consists of analyzing the geometry, swapping the light to create a path, and platforming across the darkness.

**Key Feedback** * **Action:** Performing a "Swap."
* **Feedback:** A brief, high-contrast visual flash (negative color inversion) accompanied by a heavy, mechanical *thud-click* sound effect.

---

## 2. SCAMPER Technique
**Subject:** *Tetris*

Using the SCAMPER method to reimagine the classic block-stacking mechanic:

| Letter | Strategy | Concept Idea |
| :--- | :--- | :--- |
| **S** | **Substitute** | Replace rigid blocks with **viscous liquids** that harden after 3 seconds. |
| **C** | **Combine** | Combine stacking with **Combat**; clearing lines fires projectiles at an opponent. |
| **A** | **Adapt** | Adapt the gravity to a **circular well** where blocks fall toward the center. |
| **M** | **Modify** | Add **"Weight"** to blocks; heavy blocks can crush and break those beneath them. |
| **P** | **Put to Other Use** | Use cleared lines as **building materials** to bridge a gap in a platforming sub-game. |
| **E** | **Eliminate** | Eliminate the "Next Piece" preview to force **purely reactive** play. |
| **R** | **Reverse** | **Reverse the goal:** Start with a full board and "un-stack" by matching shapes. |

---


## 1. Core Concept: Player → Verb → Goal
* **Player** → **Light Swap** → **Reach the Portal.**
* **Goal:** Reach the light portal at the end of each level.
* **Rules:** * Movement is only possible within shadowed areas.
    * Swapping the light source flips shadow positions instantly.
* **Feedback:** A high-contrast "negative" screen flash and a heavy mechanical *thud-click* upon swapping.

---

## 2. Rules & Predictions
* **Rule Change:** Shadows "linger" for 0.5 seconds after a swap before disappearing.
* **Effect:** Players can perform "leap of faith" jumps, swapping mid-air to catch a shadow that hasn't vanished yet. This makes the gameplay feel more kinetic and rewarding for high-skill players.

---

## 3. Design Pillars
* **Pillars:** Mental Mapping, Rhythmic Movement, Spatial Tension.
* **Non-goal:** No combat or "lives" system; the focus is purely on the puzzle-platforming logic.

---

## 4. MDA Framework (Mechanics → Feeling)
| Mechanic | Feeling |
| :--- | :--- |
| **Light Source Swap** | Empowerment / Control |
| **Instant Death in Light** | Vulnerability / Precision |
| **Moving Light Sources** | Urgency / Dynamic Planning |

* **Remove one mechanic:** Without the "Instant Death in Light," the shadows become optional. The tension disappears, and it becomes a generic platformer rather than a puzzle game.

---

## 5. Core Loop & Progression
**The Loop:**
`Observe Geometry` → `Plan Shadow Path` → `Execute Swaps/Jumps` → `Reach Portal` → `Unlock New Light Mechanics` → `Repeat`

**Progression (New Mechanic: Moving Lights):**
1.  **Teach:** A light on a slow pendulum. Player waits for the shadow to sweep across a gap.
2.  **Test:** Two pendulums out of sync. Player must time a jump from one moving shadow to the next.
3.  **Twist:** Player can "Swap" to freeze the light movement for 2 seconds.
4.  **Master:** Navigating a room of rotating lights while manually swapping to fill the gaps in the rotation.

---

## 6. Goals, Rules, Feedback, Rewards
* **Goal:** Complete a "Perfect Run" (Zero light exposure).
* **Rule 1:** Light meter fills if you touch brightness; 100% = Restart.
* **Rule 2:** Swapping has a 1-second cooldown (prevents "spamming").
* **Feedback (Success):** Portal emits a warm golden hum + satisfying chime on entry.
* **Feedback (Failure):** Player character "evaporates" into white smoke + sharp hiss SFX.
* **Cosmetic Reward:** Unlock "Neon Shadow" trails after 10 Perfect Runs.

---

## 7. Fair Challenge & Balance
* **Fairness Tool:** **Shadow Snapping** — If a player is 5 pixels away from a shadow edge when landing, the game gently pulls them into the dark.
* **Tuning Knobs:**
    * **Swap Cooldown:** Shorten to make it easier; lengthen for "Hard Mode."
    * **Light Sensitivity:** How fast the "Death Meter" fills when touching light.

---

## 8. Level Design (Teach → Test → Twist → Master)
1.  **Room 1 (Teach):** Single wall, one swap required. Checkpoint at start.
2.  **Room 2 (Test):** Multiple pillars. Player must swap 3 times to cross. Checkpoint after 2nd pillar.
3.  **Room 3 (Twist):** A "flickering" light source that swaps automatically. Checkpoint before the flicker zone.
4.  **Room 4 (Master):** Moving lights combined with player-controlled swaps. Checkpoint mid-way through the complex sequence.

---

## 9. UX & Accessibility
* **Features:**
    * **High-Contrast Mode:** Makes shadows pitch black and light zones bright yellow.
    * **Swap Warning:** A subtle UI arrow indicating where the next shadow will appear.
* **In-Game Prompt:**
    > “The light is your enemy. Stand in the darkness. Press [Space] to shift the world and create your path.”