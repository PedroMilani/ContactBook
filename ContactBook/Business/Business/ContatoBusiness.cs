using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ContatoBusiness
    {
        public List<ContatoDTO> ObterTodosContatos()
        {
            ContatoRepository contatoRepository = new ContatoRepository();
            return contatoRepository.ObterTodosContatos();
        }

        public ContatoDTO PesquisarContato(string Nome)
        {
            ContatoRepository contatoRepository = new ContatoRepository();
            return contatoRepository.PesquisarContato(Nome);
        }

        public ContatoDTO PesquisarContatoEnd(string Endereco)
        {
            ContatoRepository contatoRepositoryEnd = new ContatoRepository();
            return contatoRepositoryEnd.PesquisarContatoEnd(Endereco);
        }
        public ContatoDTO PesquisarContatoId(string id)
        {
            ContatoRepository contatoRepositoryId = new ContatoRepository();
            return contatoRepositoryId.PesquisarContatoId(id);
        }

        public string AdicionarContato(ContatoDTO contatoDTO)
        {
            //TODO:Adicionar as validações de null aqui/ ADICIONAR TRY CATCH
            string msg = string.Empty;
            ContatoRepository contatoRepository = new ContatoRepository();
            try
            {
                if (!string.IsNullOrEmpty(contatoDTO.Nome))
                {
                    if (!string.IsNullOrEmpty(contatoDTO.Endereco))
                    {
                        if (!string.IsNullOrEmpty(contatoDTO.Telefone))
                        {
                            if (!string.IsNullOrEmpty(contatoDTO.Email))
                            {
                                if (!string.IsNullOrEmpty(contatoDTO.CPF))
                                {
                                    return msg = contatoRepository.AdicionarContato(contatoDTO);
                                }
                                else
                                {
                                    return msg = "Informe o CPF.";
                                }
                            }
                            else
                            {
                                return msg = "Informe o e-mail.";
                            }
                        }
                        else
                        {
                            return msg = "Informe o Telefone.";
                        }
                    }
                    else
                    {
                        return msg = "Informe o endereço.";
                    }
                }
                else
                {
                    return msg = "Informe o nome";
                }
            }
            catch
            {
                throw;
            }


        }

        public string DeletarContato(int id)
        {
            string msg = string.Empty;
            ContatoRepository contatoRepository = new ContatoRepository();
            return msg = contatoRepository.DeletarContato(id);
        }
        public string UpdateContato(ContatoDTO contatoDTO, int id)
        {
            string msg = string.Empty;
            if (string.IsNullOrEmpty(contatoDTO.Nome) && string.IsNullOrEmpty(contatoDTO.Endereco) && string.IsNullOrEmpty(contatoDTO.Telefone) && string.IsNullOrEmpty(contatoDTO.Email) && string.IsNullOrEmpty(contatoDTO.CPF))
            {
                return msg = "Insira algum dado para atualizar.";
            }
            else
            {
                ContatoRepository contatoRepository = new ContatoRepository();
                return msg = contatoRepository.UpdateContato(contatoDTO, id);
            }
        }
    }
}
