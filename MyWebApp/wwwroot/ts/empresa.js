"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var Empresa = /** @class */ (function () {
    function Empresa(nome, id) {
        this.nome = nome;
        this.id = id;
    }
    Object.defineProperty(Empresa.prototype, "setNome", {
        set: function (nome) {
            this.nome = nome;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Empresa.prototype, "getNome", {
        get: function () {
            return this.nome;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Empresa.prototype, "setId", {
        set: function (id) {
            this.id = id;
        },
        enumerable: true,
        configurable: true
    });
    Object.defineProperty(Empresa.prototype, "getId", {
        get: function () {
            return this.id;
        },
        enumerable: true,
        configurable: true
    });
    Empresa.prototype.obterInformacoes = function () {
        console.log("Nome da empresa:" + this.nome + "Id da empresa" + this.id);
    };
    return Empresa;
}());
exports.Empresa = Empresa;
//# sourceMappingURL=empresa.js.map