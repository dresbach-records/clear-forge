ENGENHARIA – CLEARFORGE

Technical UI Reference Structure
Tech Ops Engineering
Dresbach Group – Canada

Overview

This directory contains the complete UI reference structure for the CLEARFORGE Windows application.

Each folder represents a designed screen exported from Stitch.
Every screen contains:

code.html → Layout reference

screen.png → Visual reference

These files are used as design blueprints for .NET implementation (WinUI / WPF).

This folder does not contain the website structure.
It is strictly for the Windows software interface.

📁 Folder Structure

Each subfolder represents one screen of the application.

🔹 INSTALLER MODULE

Represents the installation wizard flow.

Folders:

clearforge_installation_wizard_1

clearforge_installation_wizard_2

clearforge_installation_wizard_3

clearforge_installation_wizard_4

clearforge_installation_wizard_5

Purpose:
Defines the multi-step installation process including progress, options and finalization.

🔹 LOGIN MODULE

Folder:

clearforge_login_portal

Purpose:
Secure access screen for user authentication.

🔹 ONBOARDING MODULE

Folder:

clearforge_onboarding_welcome

Purpose:
First-run experience and initial configuration.

🔹 BASE DASHBOARD (Base Plan)

Folders:

clearforge_main_dashboard_1

clearforge_main_dashboard_2

clearforge_main_dashboard_3

clearforge_main_dashboard_4

clearforge_main_dashboard_5

clearforge_main_dashboard_6

clearforge_main_dashboard_7

clearforge_main_dashboard_8

clearforge_main_dashboard_9

Purpose:
Base plan interface with essential system metrics and core cleaning tools.

🔹 ADVANCED DASHBOARD (Advanced Plan)

Folders:

clearforge_main_dashboard_10

clearforge_main_dashboard_11

clearforge_main_dashboard_12

Purpose:
Expanded interface with advanced analytics and enterprise-level modules.

🔹 PRO DASHBOARD (Pro Plan – Locked Modules)

Folders:

clearforge_pro_dashboard_locked_1

clearforge_pro_dashboard_locked_2

clearforge_pro_dashboard_locked_3

clearforge_pro_dashboard_locked_4

clearforge_pro_dashboard_locked_5

clearforge_pro_dashboard_locked_6

Purpose:
Represents feature-gated interface for Pro plan.
Includes locked module visualization and upgrade prompts.

🔹 NOTIFICATION & SETTINGS MODULE

Folders:

clearforge_notification_settings_1

clearforge_notification_settings_2

clearforge_notification_settings_3

clearforge_notification_settings_4

clearforge_notification_settings_5

clearforge_notification_settings_6

clearforge_notification_settings_7

clearforge_notification_settings_8

clearforge_notification_settings_9

clearforge_notification_settings_10

clearforge_notification_settings_11

clearforge_notification_settings_12

clearforge_notification_settings_13

clearforge_notification_settings_14

clearforge_notification_settings_15

Purpose:
Configuration screens, notification center and advanced control panels.

🔹 HELP & SUPPORT

Folder:

clearforge_help_&_support

Purpose:
User support interface within the application.

🧩 Dashboard Structure Overview

CLEARFORGE includes three plan-based UI structures:

Base Plan

Simplified dashboard.
Essential modules.
Manual optimization.

Pro Plan

Unlocked advanced modules.
Notification system.
Scheduled optimization.
Expanded analytics.

Advanced Plan

Enterprise-level interface.
Extended reporting.
Administrative tools.
Expanded monitoring.

Feature access is controlled dynamically via licensing validation.

🛠 Engineering Notes

HTML files are visual reference only.

They must be converted into native WinUI 3 or WPF components.

Layout structure should follow MVVM pattern.

Do not replicate HTML directly in production.

Use component modularization for dashboard cards.

🎯 Purpose of This Folder

This directory serves as:

Visual reference library

UI implementation blueprint

Plan-based feature mapping

Internal engineering documentation

It does not contain production code.

📌 Implementation Guidance

When converting screens to .NET:

Map each folder to a View

Create corresponding ViewModel

Load features dynamically by license

Maintain consistent spacing and component reuse

Enforce plan-based feature gating in Application layer

Corporate Attribution

CLEARFORGE
Developed by Tech Ops Engineering
Dresbach Group – Canada

Founder & Lead Architect:
Marcos Vinicius Dresbach do Amaral

All rights reserved.