const url = "https://localhost:44326/api/beanvariety/";

const button = document.querySelector("#run-button");
const outputContainer = document.querySelector("#bean-type-container");
button.addEventListener("click", () => {
    getAllBeanVarieties()
        .then(beanVarieties => {
            console.log(beanVarieties);
            beanVarieties.forEach((singleBeanType) => {
                outputContainer.innerHTML += BeanCard(singleBeanType);
            })
        })
});

function BeanCard(beanTypeObject) {
    return `
    <div class="bean-type-card">
    <h2>${beanTypeObject.name}</h2>
    <p>${beanTypeObject.region}</p>
    <p>${beanTypeObject.notes}</p>
    </div>
    `;
}

function getAllBeanVarieties() {
    return fetch(url).then(resp => resp.json());
}