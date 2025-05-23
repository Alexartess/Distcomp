using System;
using Domain.Models;
using MongoDB.Bson;
using Shared.Domain;

namespace Domain.Repositories;

public interface IReactionRepository
{
    Task<Result<ReactionModel>> CreateReaction(ReactionModel reaction);
    Task<Result<IEnumerable<ReactionModel>>> GetReactions();
    Task<Result<ReactionModel>> GetReactionById(long id);
    Task<Result<ReactionModel>> UpdateReaction(ReactionModel reaction);
    Task<Result> DeleteReaction(long id);
}
