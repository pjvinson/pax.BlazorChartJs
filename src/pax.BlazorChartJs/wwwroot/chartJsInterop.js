class AsyncLock {
    constructor() {
        this.disable = () => { };
        this.promise = Promise.resolve();
    }
    enable() {
        this.promise = new Promise(resolve => this.disable = resolve);
    }
}
class LoadInfo {
    constructor() {
        this.chartJsLoaded = false;
        this.chartJsDatalabels = false;
        this.chartJsLabels = false;
    }
}
class ChartJsInterop {
    constructor() {
        this.lock = new AsyncLock();
        this.dotnetRefs = new Map();
        this.loadInfo = new LoadInfo();
    }
    async initChart(setupOptions, chartId, dotnetConfig, dotnetRef) {
        const chartJsPath = setupOptions['ChartJsLocation'] == undefined ?
            './chart.min.js'
            : setupOptions['ChartJsLocation'];
        await this.require([chartJsPath], async (Chart) => {
            console.log("indahouse");
            await this.lock.promise;
            this.lock.enable();
            try {
                console.log("Und es war Sommer");
                this.dotnetRefs.set(chartId, dotnetRef);
                const plugins = [];
                const config = {
                    type: dotnetConfig['type'],
                    data: dotnetConfig['data'],
                    options: dotnetConfig['options'] ?? {},
                    plugins: plugins
                };
                var oldChart = Chart.getChart(chartId);
                if (oldChart != undefined) {
                    oldChart.destroy();
                }
                const ctx = document.getElementById(chartId).getContext('2d');
                const chart = new Chart(ctx, config);
            }
            catch {
            }
            finally {
                this.lock.disable();
            }
        });
    }
    async require(moduleNames, onLoad) {
        for (let i = 0; i < moduleNames.length; i++) {
            await import(moduleNames[i]);
        }
        onLoad();
    }
    async loadModules(moduleNames) {
        console.log("loading chartJs...");
        for (let i = 0; i < moduleNames.length; i++) {
            await import(moduleNames[i]);
        }
    }
}
window[ChartJsInterop.name] = new ChartJsInterop();
export async function initChart(setupOptions, chartId, dotnetConfig, dotnetRef) {
    await window[ChartJsInterop.name].initChart(setupOptions, chartId, dotnetConfig, dotnetRef);
}
