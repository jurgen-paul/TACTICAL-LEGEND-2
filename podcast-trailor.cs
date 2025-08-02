<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tactical Legends: Rise of OISTARIAN - AI Voice Trailer</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Orbitron:wght@400;700;900&family=Rajdhani:wght@300;400;600&display=swap');
        
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        
        body {
            font-family: 'Rajdhani', sans-serif;
            background: radial-gradient(ellipse at center, #0f0f23 0%, #000000 70%);
            color: #00ff88;
            overflow-x: hidden;
            min-height: 100vh;
            position: relative;
        }
        
        .neural-grid {
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-image: 
                linear-gradient(rgba(0,255,136,0.03) 1px, transparent 1px),
                linear-gradient(90deg, rgba(0,255,136,0.03) 1px, transparent 1px);
            background-size: 50px 50px;
            pointer-events: none;
            animation: grid-pulse 4s ease-in-out infinite;
        }
        
        @keyframes grid-pulse {
            0%, 100% { opacity: 0.3; }
            50% { opacity: 0.1; }
        }
        
        .container {
            max-width: 1400px;
            margin: 0 auto;
            padding: 20px;
            position: relative;
            z-index: 10;
        }
        
        .header {
            text-align: center;
            margin-bottom: 50px;
            position: relative;
        }
        
        .title {
            font-family: 'Orbitron', monospace;
            font-size: clamp(2.5rem, 6vw, 5rem);
            font-weight: 900;
            color: #00ff88;
            text-shadow: 
                0 0 20px #00ff88,
                0 0 40px #00ff88,
                0 0 60px rgba(0,255,136,0.5);
            margin-bottom: 15px;
            animation: title-glitch 3s ease-in-out infinite;
            letter-spacing: 3px;
        }
        
        @keyframes title-glitch {
            0%, 90%, 100% { transform: translateX(0); }
            93% { transform: translateX(-2px); }
            96% { transform: translateX(2px); }
        }
        
        .subtitle {
            font-size: 1.4rem;
            color: #ff6b6b;
            font-weight: 300;
            letter-spacing: 4px;
            text-transform: uppercase;
            animation: subtitle-fade 2s ease-in-out infinite alternate;
        }
        
        @keyframes subtitle-fade {
            from { opacity: 0.7; }
            to { opacity: 1; }
        }
        
        .main-interface {
            display: grid;
            grid-template-columns: 1fr 400px;
            gap: 30px;
            margin-bottom: 40px;
        }
        
        .podcast-player {
            background: linear-gradient(145deg, rgba(0,0,0,0.9), rgba(26,26,46,0.8));
            border: 2px solid #00ff88;
            border-radius: 25px;
            padding: 40px;
            box-shadow: 
                0 0 50px rgba(0,255,136,0.3),
                inset 0 0 50px rgba(0,255,136,0.05);
            position: relative;
            overflow: hidden;
        }
        
        .podcast-player::before {
            content: '';
            position: absolute;
            top: -2px;
            left: -2px;
            right: -2px;
            bottom: -2px;
            background: conic-gradient(from 0deg, #00ff88, #ff6b6b, #00ff88);
            border-radius: 25px;
            z-index: -1;
            animation: border-spin 3s linear infinite;
        }
        
        @keyframes border-spin {
            from { transform: rotate(0deg); }
            to { transform: rotate(360deg); }
        }
        
        .player-content {
            position: relative;
            z-index: 2;
            text-align: center;
        }
        
        .play-button {
            width: 120px;
            height: 120px;
            border-radius: 50%;
            background: linear-gradient(145deg, #00ff88, #00cc6a);
            border: 4px solid #000;
            cursor: pointer;
            display: flex;
            align-items: center;
            justify-content: center;
            margin: 0 auto 30px;
            font-size: 3rem;
            color: #000;
            transition: all 0.4s cubic-bezier(0.68, -0.55, 0.265, 1.55);
            box-shadow: 
                0 0 40px rgba(0,255,136,0.6),
                0 10px 30px rgba(0,0,0,0.5);
            position: relative;
        }
        
        .play-button::before {
            content: '';
            position: absolute;
            top: -10px;
            left: -10px;
            right: -10px;
            bottom: -10px;
            border: 2px solid #00ff88;
            border-radius: 50%;
            opacity: 0;
            transition: all 0.3s ease;
        }
        
        .play-button:hover {
            transform: scale(1.15) rotate(5deg);
            box-shadow: 
                0 0 60px rgba(0,255,136,0.8),
                0 15px 40px rgba(0,0,0,0.7);
        }
        
        .play-button:hover::before {
            opacity: 1;
            animation: pulse-ring 1s ease-out infinite;
        }
        
        .progress-container {
            width: 100%;
            height: 12px;
            background: rgba(255,255,255,0.1);
            border-radius: 6px;
            margin: 30px 0;
            overflow: hidden;
            cursor: pointer;
            border: 1px solid rgba(0,255,136,0.3);
        }
        
        .progress-bar {
            height: 100%;
            background: linear-gradient(90deg, #00ff88, #ff6b6b, #00ff88);
            width: 0%;
            transition: width 0.2s ease;
            box-shadow: 0 0 15px rgba(0,255,136,0.6);
            position: relative;
        }
        
        .progress-bar::after {
            content: '';
            position: absolute;
            top: 0;
            right: 0;
            width: 20px;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(255,255,255,0.5));
            animation: progress-shine 2s ease-in-out infinite;
        }
        
        @keyframes progress-shine {
            0% { transform: translateX(-100%); opacity: 0; }
            50% { opacity: 1; }
            100% { transform: translateX(100%); opacity: 0; }
        }
        
        .time-display {
            display: flex;
            justify-content: space-between;
            font-family: 'Orbitron', monospace;
            font-size: 1.1rem;
            color: #00ff88;
            margin-bottom: 20px;
        }
        
        .volume-control {
            display: flex;
            align-items: center;
            gap: 15px;
            justify-content: center;
            margin-top: 30px;
        }
        
        .volume-slider {
            width: 200px;
            height: 8px;
            background: rgba(255,255,255,0.1);
            border-radius: 4px;
            outline: none;
            cursor: pointer;
            border: 1px solid rgba(0,255,136,0.3);
        }
        
        .volume-slider::-webkit-slider-thumb {
            width: 20px;
            height: 20px;
            background: radial-gradient(circle, #00ff88, #00cc6a);
            border-radius: 50%;
            cursor: pointer;
            -webkit-appearance: none;
            box-shadow: 0 0 15px #00ff88;
            border: 2px solid #000;
        }
        
        .ai-voice-panel {
            background: linear-gradient(145deg, rgba(26,26,46,0.9), rgba(0,0,0,0.8));
            border: 2px solid #ff6b6b;
            border-radius: 25px;
            padding: 30px;
            box-shadow: 0 0 40px rgba(255,107,107,0.3);
        }
        
        .ai-voice-panel h3 {
            color: #ff6b6b;
            font-family: 'Orbitron', monospace;
            font-size: 1.4rem;
            margin-bottom: 20px;
            text-align: center;
            text-shadow: 0 0 15px #ff6b6b;
        }
        
        .voice-generator-grid {
            display: grid;
            gap: 15px;
            margin-bottom: 25px;
        }
        
        .voice-generator-card {
            background: rgba(0,0,0,0.6);
            border: 1px solid rgba(0,255,136,0.3);
            border-radius: 12px;
            padding: 20px;
            transition: all 0.3s ease;
            cursor: pointer;
            position: relative;
            overflow: hidden;
        }
        
        .voice-generator-card::before {
            content: '';
            position: absolute;
            top: 0;
            left: -100%;
            width: 100%;
            height: 100%;
            background: linear-gradient(90deg, transparent, rgba(0,255,136,0.1), transparent);
            transition: left 0.5s ease;
        }
        
        .voice-generator-card:hover::before {
            left: 100%;
        }
        
        .voice-generator-card:hover {
            border-color: #00ff88;
            box-shadow: 0 5px 25px rgba(0,255,136,0.3);
            transform: translateY(-3px);
        }
        
        .voice-generator-card h4 {
            color: #00ff88;
            font-family: 'Orbitron', monospace;
            margin-bottom: 8px;
            font-size: 1.1rem;
        }
        
        .voice-generator-card p {
            color: #ccc;
            font-size: 0.9rem;
            line-height: 1.4;
        }
        
        .voice-generator-card .price {
            color: #ff6b6b;
            font-weight: 600;
            margin-top: 8px;
        }
        
        .generate-btn {
            width: 100%;
            padding: 15px;
            background: linear-gradient(145deg, #ff6b6b, #ff5252);
            border: none;
            border-radius: 12px;
            color: #fff;
            font-family: 'Orbitron', monospace;
            font-size: 1rem;
            font-weight: 600;
            cursor: pointer;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 1px;
            box-shadow: 0 5px 15px rgba(255,107,107,0.3);
        }
        
        .generate-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(255,107,107,0.5);
            background: linear-gradient(145deg, #ff5252, #ff6b6b);
        }
        
        .script-section {
            background: linear-gradient(145deg, rgba(0,0,0,0.8), rgba(26,26,46,0.6));
            border: 2px solid rgba(0,255,136,0.4);
            border-radius: 20px;
            padding: 35px;
            margin: 40px 0;
            font-size: 1.1rem;
            line-height: 1.8;
            box-shadow: 0 0 30px rgba(0,255,136,0.2);
        }
        
        .script-section h3 {
            color: #00ff88;
            font-family: 'Orbitron', monospace;
            margin-bottom: 25px;
            font-size: 1.5rem;
            text-align: center;
            text-shadow: 0 0 15px #00ff88;
        }
        
        .script-line {
            margin: 20px 0;
            padding: 15px;
            border-radius: 10px;
            transition: all 0.3s ease;
        }
        
        .script-line:hover {
            background: rgba(0,255,136,0.05);
            transform: translateX(5px);
        }
        
        .character-name {
            color: #00ff88;
            font-weight: 700;
            text-transform: uppercase;
            font-family: 'Orbitron', monospace;
            font-size: 1rem;
            text-shadow: 0 0 10px #00ff88;
        }
        
        .stage-direction {
            color: #888;
            font-style: italic;
            margin: 15px 0;
            padding: 10px;
            background: rgba(255,255,255,0.02);
            border-left: 3px solid #444;
            border-radius: 5px;
        }
        
        .dialogue {
            color: #fff;
            font-size: 1.3rem;
            margin: 15px 0;
            padding: 15px 0 15px 25px;
            border-left: 3px solid #00ff88;
            position: relative;
        }
        
        .dialogue::before {
            content: '"';
            position: absolute;
            left: -5px;
            top: 10px;
            font-size: 2rem;
            color: #00ff88;
            font-family: 'Orbitron', monospace;
        }
        
        .dialogue::after {
            content: '"';
            position: absolute;
            right: 10px;
            bottom: 5px;
            font-size: 2rem;
            color: #00ff88;
            font-family: 'Orbitron', monospace;
        }
        
        .tagline {
            text-align: center;
            font-family: 'Orbitron', monospace;
            font-size: 1.8rem;
            color: #ff6b6b;
            margin-top: 40px;
            text-shadow: 0 0 25px #ff6b6b;
            padding: 20px;
            background: rgba(255,107,107,0.1);
            border-radius: 15px;
            border: 1px solid rgba(255,107,107,0.3);
        }
        
        .audio-visualizer {
            position: fixed;
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            width: 300px;
            height: 300px;
            border: 3px solid #00ff88;
            border-radius: 50%;
            opacity: 0;
            pointer-events: none;
            z-index: 1000;
        }
        
        .audio-visualizer.active {
            animation: visualizer-pulse 1.5s ease-out;
        }
        
        @keyframes visualizer-pulse {
            0% {
                opacity: 1;
                transform: translate(-50%, -50%) scale(0.1);
                border-color: #00ff88;
            }
            50% {
                opacity: 0.8;
                border-color: #ff6b6b;
            }
            100% {
                opacity: 0;
                transform: translate(-50%, -50%) scale(1.5);
                border-color: #00ff88;
            }
        }
        
        .control-panel {
            display: flex;
            justify-content: center;
            gap: 20px;
            margin: 30px 0;
            flex-wrap: wrap;
        }
        
        .control-btn {
            padding: 12px 25px;
            background: rgba(0,0,0,0.7);
            border: 2px solid #00ff88;
            border-radius: 25px;
            color: #00ff88;
            font-family: 'Orbitron', monospace;
            font-size: 0.9rem;
            cursor: pointer;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 1px;
        }
        
        .control-btn:hover {
            background: rgba(0,255,136,0.1);
            box-shadow: 0 0 20px rgba(0,255,136,0.4);
            transform: translateY(-2px);
        }
        
        .status-display {
            text-align: center;
            margin: 20px 0;
            font-family: 'Orbitron', monospace;
            color: #00ff88;
            font-size: 1.1rem;
        }
        
        .demo-audio-btn {
            width: 100%;
            padding: 15px;
            background: linear-gradient(145deg, #00ff88, #00cc6a);
            border: none;
            border-radius: 12px;
            color: #000;
            font-family: 'Orbitron', monospace;
            font-size: 1rem;
            font-weight: 700;
            cursor: pointer;
            transition: all 0.3s ease;
            text-transform: uppercase;
            letter-spacing: 1px;
            margin-top: 20px;
            box-shadow: 0 5px 15px rgba(0,255,136,0.3);
        }
        
        .demo-audio-btn:hover {
            transform: translateY(-2px);
            box-shadow: 0 8px 25px rgba(0,255,136,0.5);
        }
        
        @media (max-width: 968px) {
            .main-interface {
                grid-template-columns: 1fr;
                gap: 20px;
            }
            
            .container {
                padding: 15px;
            }
            
            .play-button {
                width: 100px;
                height: 100px;
                font-size: 2.5rem;
            }
        }
        
        .loading {
            opacity: 0.6;
            pointer-events: none;
        }
        
        .success {
            border-color: #00ff88 !important;
            background: rgba(0,255,136,0.1) !important;
        }
    </style>
</head>
<body>
    <div class="neural-grid"></div>
    <div class="audio-visualizer" id="audioVisualizer"></div>
    
    <div class="container">
        <div class="header">
            <h1 class="title">TACTICAL LEGENDS</h1>
            <p class="subtitle">RISE OF OISTARIAN</p>
        </div>
        
        <div class="main-interface">
            <div class="podcast-player">
                <div class="player-content">
                    <button class="play-button" id="playButton">▶</button>
                    
                    <div class="status-display" id="statusDisplay">
                        READY TO INITIALIZE
                    </div>
                    
                    <div class="progress-container" id="progressContainer">
                        <div class="progress-bar" id="progressBar"></div>
                    </div>
                    
                    <div class="time-display">
                        <span id="currentTime">00:00</span>
                        <span id="totalTime">03:15</span>
                    </div>
                    
                    <div class="volume-control">
                        <span style="color: #00ff88; font-size: 1.2rem;">🔊</span>
                        <input type="range" class="volume-slider" id="volumeSlider" min="0" max="100" value="75">
                        <span style="color: #00ff88; font-size: 1.2rem;">🔊</span>
                    </div>
                    
                    <div class="control-panel">
                        <button class="control-btn" id="rewindBtn">⏪ REWIND</button>
                        <button class="control-btn" id="forwardBtn">FORWARD ⏩</button>
                        <button class="control-btn" id="resetBtn">🔄 RESET</button>
                    </div>
                </div>
            </div>
            
            <div class="ai-voice-panel">
                <h3>🎙️ AI VOICE GENERATION</h3>
                
                <div class="voice-generator-grid">
                    <div class="voice-generator-card" onclick="openVoiceGenerator('https://elevenlabs.io/voice-library/deep-voices')">
                        <h4>🏆 ELEVENLABS DEEP</h4>
                        <p>Premium cinematic voices. Hollywood-quality deep narrator tones perfect for trailers.</p>
                        <div class="price">Premium Service</div>
                    </div>
                    
                    <div class="voice-generator-card" onclick="openVoiceGenerator('https://play.ht/')">
                        <h4>🌍 PLAY.HT</h4>
                        <p>42+ languages, natural deep voices. Free tier available for testing.</p>
                        <div class="price">Free + Paid Tiers</div>
                    </div>
                    
                    <div class="voice-generator-card" onclick="openVoiceGenerator('https://www.voicebooking.com/en/free-voice-over-generator')">
                        <h4>🎯 VOICEBOOKING</h4>
                        <p>Free voice test samples. Perfect for script testing before production.</p>
                        <div class="price">Free Testing</div>
                    </div>
                    
                    <div class="voice-generator-card" onclick="openVoiceGenerator('https://speechify.com/male-voice-generator/')">
                        <h4>📚 SPEECHIFY</h4>
                        <p>Specialized male voices for podcasts and audiobooks. Natural conversation flow.</p>
                        <div class="price">Free + Premium</div>
                    </div>
                </div>
                
                <button class="generate-btn" onclick="generateVoiceInstructions()">
                    🎤 Generate Voice Instructions
                </button>
                
                <button class="demo-audio-btn" onclick="playDemoWithEffects()">
                    🎧 Play Demo with Effects
                </button>
            </div>
        </div>
        
        <div class="script-section">
            <h3>📜 PODCAST TRAILER SCRIPT</h3>
            
            <div class="script-line">
                <div class="stage-direction">[Sound of distant data pulses and echoes of gunfire. Ambient cyber atmosphere building tension.]</div>
            </div>
            
            <div class="script-line">
                <span class="character-name">Narrator</span> (low, gravelly voice):
                <div class="dialogue">In a world coded in silence... one whisper rewrites the algorithm.</div>
            </div>
            
            <div class="script-line">
                <div class="stage-direction">[Flash cuts: a shattered memory crystal. A cloaked figure sprinting across Echo Swamp. Neon eyes flicker in the dark.]</div>
            </div>
            
            <div class="script-line">
                <span class="character-name">Zoe's voice</span> (soft, glitching):
                <div class="dialogue">They said you were erased, but legends don't vanish. They reload.</div>
            </div>
            
            <div class="script-line">
                <div class="stage-direction">[Cue synth-heavy combat sequence. OISTARIAN locks in the NeuroPulse Arm. Drones dive, explosions bloom.]</div>
            </div>
            
            <div class="script-line">
                <span class="character-name">Narrator</span>:
                <div class="dialogue">OISTARIAN—former engineer. Reluctant operative. Relentless myth.</div>
            </div>
            
            <div class="script-line">
                <div class="stage-direction">[Fast montage: encrypted data walls exploding, a vault marked "EDEN" unlocking, flash of Zoe's hologram saying "Protect the Shard."]</div>
            </div>
            
            <div class="script-line">
                <span class="character-name">Narrator</span> (final beat):
                <div class="dialogue">This summer... silence is broken.</div>
            </div>
            
            <div class="script-line">
                <div class="stage-direction">[Final scene: OISTARIAN stands under a storm-lit sky, whispering "This time, I choose the ending."]</div>
            </div>
            
            <div class="script-line">
                <span class="character-name">OISTARIAN</span> (whispered):
                <div class="dialogue">This time, I choose the ending.</div>
            </div>
            
            <div class="tagline">
                TACTICAL LEGENDS: RISE OF OISTARIAN<br>
                <span style="font-size: 1.2rem; color: #00ff88;">"Decode the shadows. Unleash the legend."</span>
            </div>
        </div>
    </div>
    
    <script>
        class TacticalLegendsPodcast {
            constructor() {
                this.isPlaying = false;
                this.currentTime = 0;
                this.totalTime = 195; // 3:15 in seconds
                this.volume = 0.75;
                this.audioContext = null;
                this.intervals = [];
                this.activeOscillators = [];
                
                this.initializeElements();
                this.bindEvents();
                this.initializeAudio();
                this.setupAdvancedFeatures();
            }
            
            initializeElements() {
                this.playButton = document.getElementById('playButton');
                this.progressBar = document.getElementById('progressBar');
                this.progressContainer = document.getElementById('progressContainer');
                this.currentTimeDisplay = document.getElementById('currentTime');
                this.totalTimeDisplay = document.getElementById('totalTime');
                this.volumeSlider = document.getElementById('volumeSlider');
                this.audioVisualizer = document.getElementById('audioVisualizer');
                this.statusDisplay = document.getElementById('statusDisplay');
                this.rewindBtn = document.getElementById('rewindBtn');
                this.forwardBtn = document.getElementById('forwardBtn');
                this.resetBtn = document.getElementById('resetBtn');
            }
            
            bindEvents() {
                this.playButton.addEventListener('click', () => this.togglePlayPause());
                this.volumeSlider.addEventListener('input', (e) => this.setVolume(e.target.value / 100));
                this.progressContainer.addEventListener('click', (e) => this.handleProgressClick(e));
                this.rewindBtn.addEventListener('click', () => this.seek(Math.max(0, this.currentTime - 10)));
                this.forwardBtn.addEventListener('click', () => this.seek(Math.min(this.totalTime, this.currentTime + 10)));
                this.resetBtn.addEventListener('click', () => this.reset());
            }
            
            async initializeAudio() {
                try {
                    this.audioContext = new (window.AudioContext || window.webkitAudioContext)();
                    this.masterGain = this.audioContext.createGain();
                    this.masterGain.connect(this.audioContext.destination);
                    this.masterGain.gain.value = this.volume;
                    
                    // Create filter chains for better audio
                    this.lowPassFilter = this.audioContext.createBiquadFilter();
                    this.lowPassFilter.type = 'lowpass';
                    this.lowPassFilter.frequency.setValueAtTime(8000, this.audioContext.currentTime);
                    this.lowPassFilter.connect(this.masterGain);
                    
                    this.statusDisplay.textContent = 'AUDIO SYSTEM ONLINE';
                } catch (error) {
                    this.statusDisplay.textContent = 'AUDIO INITIALIZATION FAILED';
                    console.error('Audio context failed:', error);
                }
            }
            
            setupAdvancedFeatures() {
                // Enhanced audio timeline with more sophisticated sound design
                this.audioTimeline = [
                    { time: 0, action: () => this.playDataPulses(), description: 'Data pulse initialization' },
                    { time: 3, action: () => this.playDistantGunfire(), description: 'Echo combat sequences' },
                    { time: 8, action: () => this.playNarratorBacking(), description: 'Narrator voice backing' },
                    { time: 18, action: () => this.playGlitchEffects(), description: 'Zoe voice glitch effects' },
                    { time: 25, action: () => this.playCombatSequence(), description: 'Synth combat sequence' },
                    { time: 45, action: () => this.playExplosionMontage(), description: 'Explosion montage' },
                    { time: 65, action: () => this.playVaultUnlock(), description: 'EDEN vault unlocking' },
                    { time: 85, action: () => this.playNarratorFinal(), description: 'Final narrator sequence' },
                    { time: 120, action: () => this.playStormSequence(), description: 'Storm atmosphere' },
                    { time: 160, action: () => this.playFinalChord(), description: 'Dramatic finale' }
                ];
            }
            
            createAdvancedTone(frequency, duration, type = 'sine', envelope = {}) {
                if (!this.audioContext) return;
                
                const oscillator = this.audioContext.createOscillator();
                const gainNode = this.audioContext.createGain();
                const filter = this.audioContext.createBiquadFilter();
                
                // Set up oscillator
                oscillator.type = type;
                oscillator.frequency.setValueAtTime(frequency, this.audioContext.currentTime);
                
                // Set up filter
                filter.type = envelope.filterType || 'lowpass';
                filter.frequency.setValueAtTime(envelope.filterFreq || 2000, this.audioContext.currentTime);
                filter.Q.setValueAtTime(envelope.resonance || 1, this.audioContext.currentTime);
                
                // Set up envelope
                const attack = envelope.attack || 0.1;
                const decay = envelope.decay || 0.2;
                const sustain = envelope.sustain || 0.7;
                const release = envelope.release || 0.3;
                const peak = envelope.peak || 0.3;
                
                gainNode.gain.setValueAtTime(0, this.audioContext.currentTime);
                gainNode.gain.linearRampToValueAtTime(peak, this.audioContext.currentTime + attack);
                gainNode.gain.linearRampToValueAtTime(peak * sustain, this.audioContext.currentTime + attack + decay);
                gainNode.gain.linearRampToValueAtTime(0, this.audioContext.currentTime + duration - release);
                
                // Connect audio graph
                oscillator.connect(filter);
                filter.connect(gainNode);
                gainNode.connect(this.lowPassFilter);
                
                oscillator.start(this.audioContext.currentTime);
                oscillator.stop(this.audioContext.currentTime + duration);
                
                this.activeOscillators.push(oscillator);
                return { oscillator, gainNode, filter };
            }
            
            createComplexNoise(duration, profile = 'white') {
                if (!this.audioContext) return;
                
                const bufferSize = this.audioContext.sampleRate * duration;
                const buffer = this.audioContext.createBuffer(1, bufferSize, this.audioContext.sampleRate);
                const data = buffer.getChannelData(0);
                
                // Generate different noise profiles
                for (let i = 0; i < bufferSize; i++) {
                    switch(profile) {
                        case 'pink':
                            data[i] = (Math.random() * 2 - 1) * Math.pow(0.5, i / bufferSize);
                            break;
                        case 'brown':
                            data[i] = (Math.random() * 2 - 1) * Math.pow(0.25, i / bufferSize);
                            break;
                        default: // white
                            data[i] = Math.random() * 2 - 1;
                    }
                }
                
                const source = this.audioContext.createBufferSource();
                const gainNode = this.audioContext.createGain();
                const filter = this.audioContext.createBiquadFilter();
                
                source.buffer = buffer;
                filter.type = 'bandpass';
                filter.frequency.setValueAtTime(800, this.audioContext.currentTime);
                filter.Q.setValueAtTime(2, this.audioContext.currentTime);
                
                gainNode.gain.setValueAtTime(0, this.audioContext.currentTime);
                gainNode.gain.linearRampToValueAtTime(0.15, this.audioContext.currentTime + 0.1);
                gainNode.gain.linearRampToValueAtTime(0, this.audioContext.currentTime + duration - 0.2);
                
                source.connect(filter);
                filter.connect(gainNode);
                gainNode.connect(this.lowPassFilter);
                
                source.start(this.audioContext.currentTime);
                
                return { source, gainNode, filter };
            }
            
            playDataPulses() {
                this.statusDisplay.textContent = 'NEURAL NETWORK ACTIVE';
                const pulseInterval = setInterval(() => {
                    if (!this.isPlaying) {
                        clearInterval(pulseInterval);
                        return;
                    }
                    
                    this.createAdvancedTone(220 + Math.random() * 440, 0.2, 'square', {
                        attack: 0.01,
                        decay: 0.05,
                        sustain: 0.3,
                        release: 0.1,
                        peak: 0.2
                    });
                    
                    this.visualPulse();
                }, 600);
                this.intervals.push(pulseInterval);
            }
            
            playDistantGunfire() {
                this.statusDisplay.textContent = 'COMBAT ECHOES DETECTED';
                for (let i = 0; i < 8; i++) {
                    setTimeout(() => {
                        if (this.isPlaying) {
                            this.createComplexNoise(0.08, 'brown');
                            this.createAdvancedTone(60 + Math.random() * 40, 0.1, 'sawtooth', {
                                attack: 0.001,
                                decay: 0.02,
                                sustain: 0.1,
                                release: 0.05,
                                peak: 0.4
                            });
                        }
                    }, i * 300 + Math.random() * 200);
                }
            }
            
            playNarratorBacking() {
                this.statusDisplay.textContent = 'NARRATOR VOICE ACTIVE';
                this.createAdvancedTone(110, 3, 'sawtooth', {
                    attack: 0.5,
                    decay: 0.3,
                    sustain: 0.8,
                    release: 1.0,
                    peak: 0.15,
                    filterType: 'lowpass',
                    filterFreq: 400
                });
            }
            
            playGlitchEffects() {
                this.statusDisplay.textContent = 'ZOE SIGNAL PROCESSING';
                for (let i = 0; i < 5; i++) {
                    setTimeout(() => {
                        if (this.isPlaying) {
                            this.createAdvancedTone(880 + Math.random() * 880, 0.1, 'square', {
                                attack: 0.001,
                                decay: 0.02,
                                sustain: 0.5,
                                release: 0.05,
                                peak: 0.1
                            });
                        }
                    }, i * 150);
                }
            }
            
            playCombatSequence() {
                this.statusDisplay.textContent = 'NEURO-PULSE ARM ENGAGED';
                const combatInterval = setInterval(() => {
                    if (!this.isPlaying) {
                        clearInterval(combatInterval);
                        return;
                    }
                    
                    // Heavy bass line
                    this.createAdvancedTone(55, 0.8, 'sawtooth', {
                        attack: 0.1,
                        decay: 0.2,
                        sustain: 0.7,
                        release: 0.1,
                        peak: 0.3
                    });
                    
                    // Synth melody
                    setTimeout(() => {
                        if (this.isPlaying) {
                            const notes = [330, 370, 415, 466, 523];
                            const note = notes[Math.floor(Math.random() * notes.length)];
                            this.createAdvancedTone(note, 0.4, 'square', {
                                attack: 0.05,
                                decay: 0.1,
                                sustain: 0.6,
                                release: 0.2,
                                peak: 0.2
                            });
                        }
                    }, 200);
                    
                }, 1200);
                this.intervals.push(combatInterval);
            }
            
            playExplosionMontage() {
                this.statusDisplay.textContent = 'EXPLOSIVE SEQUENCE';
                for (let i = 0; i < 6; i++) {
                    setTimeout(() => {
                        if (this.isPlaying) {
                            // Explosion low end
                            this.createAdvancedTone(40, 0.3, 'sawtooth', {
                                attack: 0.001,
                                decay: 0.05,
                                sustain: 0.3,
                                release: 0.2,
                                peak: 0.5
                            });
                            
                            // Explosion high frequencies
                            this.createComplexNoise(0.15, 'white');
                        }
                    }, i * 800);
                }
            }
            
            playVaultUnlock() {
                this.statusDisplay.textContent = 'EDEN VAULT UNLOCKING';
                // Ascending technological sounds
                for (let i = 0; i < 10; i++) {
                    setTimeout(() => {
                        if (this.isPlaying) {
                            this.createAdvancedTone(200 + i * 50, 0.3, 'sine', {
                                attack: 0.1,
                                decay: 0.1,
                                sustain: 0.8,
                                release: 0.1,
                                peak: 0.15
                            });
                        }
                    }, i * 200);
                }
            }
            
            playNarratorFinal() {
                this.statusDisplay.textContent = 'FINAL REVELATION';
                this.createAdvancedTone(82, 4, 'triangle', {
                    attack: 0.8,
                    decay: 0.5,
                    sustain: 0.9,
                    release: 1.5,
                    peak: 0.2,
                    filterType: 'lowpass',
                    filterFreq: 600
                });
            }
            
            playStormSequence() {
                this.statusDisplay.textContent = 'STORM ATMOSPHERE';
                // Thunder rumble
                this.createAdvancedTone(45, 8, 'sawtooth', {
                    attack: 0.3,
                    decay: 1.0,
                    sustain: 0.4,
                    release: 2.0,
                    peak: 0.3
                });
                
                // Wind effect
                this.createComplexNoise(10, 'pink');
            }
            
            playFinalChord() {
                this.statusDisplay.textContent = 'LEGENDARY STATUS ACHIEVED';
                // Epic final chord
                const chord = [65, 82, 98, 130, 164];
                chord.forEach((freq, i) => {
                    setTimeout(() => {
                        if (this.isPlaying) {
                            this.createAdvancedTone(freq, 6, 'sawtooth', {
                                attack: 0.5,
                                decay: 1.0,
                                sustain: 0.8,
                                release: 2.0,
                                peak: 0.25
                            });
                        }
                    }, i * 100);
                });
            }
            
            visualPulse() {
                this.audioVisualizer.classList.add('active');
                setTimeout(() => {
                    this.audioVisualizer.classList.remove('active');
                }, 1500);
            }
            
            togglePlayPause() {
                if (this.isPlaying) {
                    this.pause();
                } else {
                    this.play();
                }
            }
            
            play() {
                if (this.audioContext && this.audioContext.state === 'suspended') {
                    this.audioContext.resume();
                }
                
                this.isPlaying = true;
                this.playButton.textContent = '⏸';
                this.playButton.style.background = 'linear-gradient(145deg, #ff6b6b, #ff5252)';
                this.statusDisplay.textContent = 'TRAILER PLAYING';
                
                this.executeAudioTimeline();
                this.startProgressTracking();
            }
            
            pause() {
                this.isPlaying = false;
                this.playButton.textContent = '▶';
                this.playButton.style.background = 'linear-gradient(145deg, #00ff88, #00cc6a)';
                this.statusDisplay.textContent = 'PAUSED';
                
                this.stopAllAudio();
                this.stopProgressTracking();
            }
            
            reset() {
                this.pause();
                this.currentTime = 0;
                this.updateDisplay();
                this.statusDisplay.textContent = 'SYSTEM RESET';
            }
            
            seek(time) {
                const wasPlaying = this.isPlaying;
                if (this.isPlaying) this.pause();
                
                this.currentTime = Math.max(0, Math.min(time, this.totalTime));
                this.updateDisplay();
                
                if (wasPlaying) this.play();
            }
            
            executeAudioTimeline() {
                this.audioTimeline.forEach(event => {
                    if (event.time >= this.currentTime) {
                        const delay = (event.time - this.currentTime) * 1000;
                        setTimeout(() => {
                            if (this.isPlaying && this.currentTime >= event.time - 1) {
                                event.action();
                            }
                        }, delay);
                    }
                });
            }
            
            startProgressTracking() {
                this.progressInterval = setInterval(() => {
                    if (this.isPlaying && this.currentTime < this.totalTime) {
                        this.currentTime += 0.1;
                        this.updateDisplay();
                    } else if (this.currentTime >= this.totalTime) {
                        this.reset();
                        this.statusDisplay.textContent = 'TRAILER COMPLETE';
                    }
                }, 100);
            }
            
            stopProgressTracking() {
                if (this.progressInterval) {
                    clearInterval(this.progressInterval);
                }
            }
            
            stopAllAudio() {
                this.intervals.forEach(interval => clearInterval(interval));
                this.intervals = [];
                
                this.activeOscillators.forEach(osc => {
                    try { osc.stop(); } catch (e) {}
                });
                this.activeOscillators = [];
            }
            
            handleProgressClick(e) {
                const rect = e.currentTarget.getBoundingClientRect();
                const clickX = e.clientX - rect.left;
                const percentage = clickX / rect.width;
                this.seek(percentage * this.totalTime);
            }
            
            setVolume(volume) {
                this.volume = Math.max(0, Math.min(1, volume));
                if (this.masterGain) {
                    this.masterGain.gain.value = this.volume;
                }
            }
            
            updateDisplay() {
                const progress = (this.currentTime / this.totalTime) * 100;
                this.progressBar.style.width = `${progress}%`;
                
                this.currentTimeDisplay.textContent = this.formatTime(this.currentTime);
                this.totalTimeDisplay.textContent = this.formatTime(this.totalTime);
            }
            
            formatTime(seconds) {
                const mins = Math.floor(seconds / 60);
                const secs = Math.floor(seconds % 60);
                return `${mins.toString().padStart(2, '0')}:${secs.toString().padStart(2, '0')}`;
            }
        }
        
        // AI Voice Generation Functions
        function openVoiceGenerator(url) {
            window.open(url, '_blank');
        }
        
        function generateVoiceInstructions() {
            const instructions = `
🎙️ AI VOICE GENERATION INSTRUCTIONS

SCRIPT FOR DEEP MALE NARRATOR:

1. OPENING (Dramatic, slow build):
"In a world coded in silence... one whisper rewrites the algorithm."

2. ZOE'S LINE (Soft, with digital glitch effect):
"They said you were erased, but legends don't vanish. They reload."

3. CHARACTER INTRO (Powerful, building intensity):
"OISTARIAN—former engineer. Reluctant operative. Relentless myth."

4. CLIMAX (Dramatic pause, then explosive):
"This summer... silence is broken."

5. FINAL WHISPER (OISTARIAN, quiet but intense):
"This time, I choose the ending."

VOICE SETTINGS RECOMMENDATIONS:
- Voice Type: Deep Male, Gravelly
- Tone: Cinematic, Dramatic
- Pacing: Slow to Medium
- Emphasis: Heavy on key words
- Effects: Add slight reverb for depth

RECOMMENDED GENERATORS:
✅ ElevenLabs: Use "Deep Voice" category
✅ Play.ht: Select "Male Deep" voice
✅ Speechify: Choose "Narrator" style
✅ VoiceBooking: Test with "Deep Male"

Copy this script to your chosen AI voice generator!
            `;
            
            alert(instructions);
        }
        
        function playDemoWithEffects() {
            // Enhanced demo with all effects
            const player = new TacticalLegendsPodcast();
            setTimeout(() => {
                player.play();
            }, 500);
        }
        
        // Initialize the podcast player
        document.addEventListener('DOMContentLoaded', () => {
            window.podcastPlayer = new TacticalLegendsPodcast();
        });
        
        // Enhanced interactive effects
        document.addEventListener('mousemove', (e) => {
            const x = (e.clientX / window.innerWidth) * 100;
            const y = (e.clientY / window.innerHeight) * 100;
            
            document.querySelector('.neural-grid').style.backgroundPosition = 
                `${x * 0.1}px ${y * 0.1}px, ${x * 0.05}px ${y * 0.05}px`;
        });
        
        // Keyboard controls
        document.addEventListener('keydown', (e) => {
            if (!window.podcastPlayer) return;
            
            switch(e.code) {
                case 'Space':
                    e.preventDefault();
                    window.podcastPlayer.togglePlayPause();
                    break;
                case 'ArrowLeft':
                    e.preventDefault();
                    window.podcastPlayer.seek(Math.max(0, window.podcastPlayer.currentTime - 10));
                    break;
                case 'ArrowRight':
                    e.preventDefault();
                    window.podcastPlayer.seek(Math.min(window.podcastPlayer.totalTime, window.podcastPlayer.currentTime + 10));
                    break;
                case 'KeyR':
                    e.preventDefault();
                    window.podcastPlayer.reset();
                    break;
            }
        });
    </script>
</body>
</html>
