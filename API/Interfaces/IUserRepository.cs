using System;
using API.DTOs;
using API.Entities;

namespace API.Interfaces;

public interface IUserRepository
{
    void Update(AppUser user);
    Task<bool> SaveAllSync();
    Task<IEnumerable<AppUser>> GetUsersAsync();
    Task<AppUser?> GetUserByIdAsync(int id);
    Task<AppUser?> GetUserByUsermameAsync(string username);
    Task<IEnumerable<MemberDTO>> GetMembersAsync();
    Task<MemberDTO?> GetMemberAsync(string username);
}
