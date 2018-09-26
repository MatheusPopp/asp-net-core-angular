export class Empresa {

    public nome: string;
    public id: number;

    constructor(nome?:string, id?:number) {
        this.nome = nome;
        this.id = id;
    }


    set setNome(nome:string){
        this.nome = nome;
    }

    get getNome(){
        return this.nome;
    }

    set setId(id: number) {
        this.id = id;
    }

    get getId() {
        return this.id;
    }

    public obterInformacoes() {
        console.log("Nome da empresa:"+this.nome+"Id da empresa"+this.id);
    }
}