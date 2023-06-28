using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vivo_Apps_API.Models
{
    public class PagedResponse
    {
        public static PagedResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationPainelRotaModel validFilter, int totalRecords,
            double Pcr_ocupação, double Pcr_disponível, int qtd_total_casas, int qtd_total_prédios, int qtd_clientes_FTTC, int total_cliente_BADDEBT, int total_clientes_FRAUDE)
        {
            var respose = new PagedResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            
            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            respose.Pcr_ocupação = Pcr_ocupação;
            respose.Pcr_disponível = Pcr_disponível;
            respose.qtd_total_casas = qtd_total_casas;
            respose.qtd_total_prédios = qtd_total_prédios;
            respose.qtd_clientes_FTTC = qtd_clientes_FTTC;
            respose.total_cliente_BADDEBT = total_cliente_BADDEBT;
            respose.total_clientes_FRAUDE = total_clientes_FRAUDE;

            return respose;
        }

        public static PagedModelResponse<IEnumerable<T>> CreatePagedReponse<T,C>(IEnumerable<T> pagedData, GenericPaginationModel<C> validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }
        public static PagedResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationPainelPrumaModel validFilter, int totalRecords)
        {
            var respose = new PagedResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;

            return respose;
        }
        public static GenericPagedResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationDemandasModel validFilter, int totalRecords)
        {
            var respose = new GenericPagedResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;

            return respose;
        }

        public static PagedResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationPainelRotaModel validFilter, int totalRecords)
        {
            var respose = new PagedResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;
            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }

            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;

            return respose;
        }
        public static PagedModelResponse<IEnumerable<T>> CreateListaDemandasPagedReponse<T>(IEnumerable<T> pagedData, PaginationListaDemandasModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;

            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }
            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }
        public static PagedModelResponse<IEnumerable<T>> CreatePagedReponse<T>(IEnumerable<T> pagedData, PaginationControleAcessoModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<IEnumerable<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
            if (validFilter.PageNumber == roundedTotalPages)
            {
                respose.isLastpage = true;

            }

            if (validFilter.PageNumber == 1)
            {
                respose.isFirstpage = true;
            }
            respose.TotalPages = roundedTotalPages;
            respose.TotalRecords = totalRecords;
            return respose;
        }

    }
}