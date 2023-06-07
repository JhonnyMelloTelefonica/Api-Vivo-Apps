using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Vivo_Apps.Models
{
    public class PagedResponse
    {
        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationPainelRotaModel validFilter, int totalRecords,
            double Pcr_ocupação, double Pcr_disponível, int qtd_total_casas, int qtd_total_prédios, int qtd_clientes_FTTC, int total_cliente_BADDEBT, int total_clientes_FRAUDE)
        {
            var respose = new PagedResponse<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
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

        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationPainelPrumaModel validFilter, int totalRecords)
        {
            var respose = new PagedResponse<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
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

        public static PagedResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationPainelRotaModel validFilter, int totalRecords)
        {
            var respose = new PagedResponse<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
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
        public static PagedModelResponse<List<T>> CreateListaDemandasPagedReponse<T>(List<T> pagedData, PaginationListaDemandasModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
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
        public static PagedModelResponse<List<T>> CreatePagedReponse<T>(List<T> pagedData, PaginationControleAcessoModel validFilter, int totalRecords)
        {
            var respose = new PagedModelResponse<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
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