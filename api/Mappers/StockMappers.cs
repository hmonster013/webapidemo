using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;
using api.Dtos.Stock;
using api.Models;

namespace api.Mappers
{
    public static class StockMappers
    {
        public static StockDto ToStockDto(this Stock stockModel)
        {
            return new StockDto
            {
                Id = stockModel.Id,
                Symbol = stockModel.Symbol,
                CompanyName = stockModel.CompanyName,
                Purchase = stockModel.Purchase,
                LastDiv = stockModel.LastDiv,
                Industry = stockModel.Industry,
                MarketCap = stockModel.MarketCap,
                CommentDtos = stockModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Stock ToStockFromCreateDTO(this CreateStockRequestDto stockRequestDto){
            return new Stock
            {
                Symbol = stockRequestDto.Symbol,
                CompanyName = stockRequestDto.CompanyName,
                Purchase = stockRequestDto.Purchase,
                LastDiv = stockRequestDto.LastDiv,
                Industry = stockRequestDto.Industry,
                MarketCap = stockRequestDto.MarketCap
            };
        }
    }
}