// Theme management JavaScript
export function setTheme(isDark) {
    const htmlElement = document.documentElement;
    const bodyElement = document.body;

    if (isDark) {
        htmlElement.classList.remove('light-theme');
        htmlElement.classList.add('dark-theme');
        bodyElement.classList.remove('light-theme');
        bodyElement.classList.add('dark-theme');
    } else {
        htmlElement.classList.remove('dark-theme');
        htmlElement.classList.add('light-theme');
        bodyElement.classList.remove('dark-theme');
        bodyElement.classList.add('light-theme');
    }
}

export function getTheme() {
    return document.documentElement.classList.contains('dark-theme');
}

export function toggleSidebar(sidebarElement) {
    if (sidebarElement) {
        sidebarElement.classList.toggle('collapsed');
    }
}
