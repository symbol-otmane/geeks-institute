# Assignment 1 — Game Production Schedule

## Game Concept
**Mobile Endless Runner** with 3 unique environments and collectible coins.

---

## Milestones & Deliverables

### Milestone 1: First Playable
- Controllable character running automatically
- One playable environment (greybox)
- Obstacles (basic) 
- Basic UI (score + restart)

### Milestone 2: Alpha Build
- 3 playable environments
- Core mechanics (jump, slide, speed up)
- Collectibles implemented
- Audio placeholder
- Internal playtesting

### Milestone 3: Beta Build
- Polished environments
- Full UI/UX polish
- Visual and audio assets final
- Bug fixing
- External playtest ready

---

## Work Breakdown Structure (First Playable)

### Epic 1: Player Mechanics
| Task | Estimate (hrs) |
|---|---|
| Automatic forward movement | 10 |
| Jump mechanic | 8 |
| Slide mechanic | 6 |
| Collision detection | 10 |

### Epic 2: Level Blockout
| Task | Estimate (hrs) |
|---|---|
| Greybox environment layout | 12 |
| Place obstacles | 8 |
| Add collectible placeholders | 6 |

### Epic 3: UI & Game Loop
| Task | Estimate (hrs) |
|---|---|
| Score system | 6 |
| Restart logic | 6 |
| Basic HUD | 6 |

---

## Dependencies
1. Collision detection → Jump & Slide mechanics
2. Forward movement → Level testing
3. Greybox layout → Obstacle placement
4. Score system → HUD
5. Restart logic → Full playtest

**Critical Path:**
Automatic Movement → Collision → Jump/Slide → Greybox Level → Obstacles → Restart Logic → Playtest

---

# Assignment 2 — Task Board & Workflow Setup

## Tool Selected
**Trello (Kanban)**

## Columns
- Backlog
- Ready for Sprint
- In Progress
- Review / QA
- Done

## Tasks Imported (Sample)
| Task | Role | Priority | Status |
|---|---|---|---|
| Automatic forward movement | Programmer | Must | In Progress |
| Jump mechanic | Programmer | Must | In Progress |
| Greybox environment | Level Designer | Must | Review |
| Obstacle placement | Level Designer | Should | Ready |
| Score system | Programmer | Must | Done |
| Basic HUD | UI Designer | Should | In Progress |
| Restart logic | Programmer | Must | Review |
| Slide mechanic | Programmer | Should | Backlog |
| Collectible placeholders | Level Designer | Should | Ready |
| Audio placeholder | Audio | Should | Backlog |

---

# Assignment 3 — Risk Management Exercise

| Risk Description | Category | Impact / Likelihood | Prevention (Plan A) | Contingency (Plan B) |
|---|---|---|---|---|
| Core mechanic not fun | Design | High / Medium | Early vertical slice playtests | Replace with simpler mechanic |
| Scope creep | Scope | High / High | Lock scope after Alpha | Cut non-core features |
| Technical bugs | Technical | Medium / Medium | Regular builds & testing | Freeze features, bug-fix sprint |
| Team member unavailable | Personnel | Medium / Low | Knowledge sharing & docs | Reassign tasks |
| Missed deadline | Schedule | High / Medium | Buffer time in milestones | Reduce number of levels or features |
