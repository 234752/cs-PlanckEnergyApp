const ctx = document.getElementById('myChart');

const data = {
    labels: [
        'MOFs',
        'Nanoparticles',
        'MMOs',
        'Carbon-based',
        'MXenes'
    ],
    datasets: [{
        label: 'Materials',
        data: [25, 10, 32, 5, 38],
        backgroundColor: [
            'rgb(0, 0, 255)',
            'rgb(100, 100, 100)',
            'rgb(255, 165, 0)',
            'rgb(255, 0, 0)',
            'rgb(100, 255, 100)'
        ],
        hoverOffset: 4
    }]
};


new Chart(ctx, {
    type: 'doughnut',
    data: data,
    options: {
        plugins: {
            legend: {
                position: 'right'
            }
        },
        maintainAspectRatio: false
    }

});