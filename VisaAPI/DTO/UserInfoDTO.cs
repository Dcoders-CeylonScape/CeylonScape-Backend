

using AuthAPI.Models;

namespace VisaAPI.DTO
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string BirthCountry { get; set; }
        public string BirthPlace { get; set; }
        public double Height { get; set; }
        public string Peculiarity { get; set; }
        public string DomicileAddress { get; set; }
        public string AddressDuringSriLanka { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public string? Fax { get; set; }
        public string Email { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public List<EmergencyContactDTO>? EmergencyContacts { get; set; }
        public NaturalizationInfoDTO? NaturalizationInfo { get; set; }
        public SpouseInfoDTO? Spouse { get; set; }
        public PassportDTO? Passport { get; set; }
        public List<EntryVisaInfoDTO>? EntryVisas { get; set; }
        public List<ChildrenDTO>? Children { get; set; }
        public ProfessionDTO? Profession { get; set; }
        public ResidenceVisaInfoDTO? ResidenceVisaInfo { get; set; }
        public int UserID { get; set; }

        public static UserInfoDTO ToDTO(UserInfo userInfo)
        {
            return new UserInfoDTO
            {
                Id = userInfo.Id,
                FullName = userInfo.FullName,
                Nationality = userInfo.Nationality,
                Gender = userInfo.Gender,
                DOB = userInfo.DOB,
                BirthCountry = userInfo.BirthCountry,
                BirthPlace = userInfo.BirthPlace,
                Height = userInfo.Height,
                Peculiarity = userInfo.Peculiarity,
                DomicileAddress = userInfo.DomicileAddress,
                AddressDuringSriLanka = userInfo.AddressDuringSriLanka,
                Telephone = userInfo.Telephone,
                Mobile = userInfo.Mobile,
                Fax = userInfo.Fax,
                Email = userInfo.Email,
                CivilStatus = userInfo.CivilStatus,
                EmergencyContacts = userInfo.EmergencyContacts?.Select(ec => EmergencyContactDTO.ToDTO(ec)).ToList(),
                NaturalizationInfo = NaturalizationInfoDTO.ToDTO(userInfo.NaturalizationInfo),
                Spouse = SpouseInfoDTO.ToDTO(userInfo.Spouse),
                Passport = PassportDTO.ToDTO(userInfo.Passport),
                EntryVisas = userInfo.EntryVisas?.Select(ev => EntryVisaInfoDTO.ToDTO(ev)).ToList(),
                Children = userInfo.Children?.Select(c => ChildrenDTO.ToDTO(c)).ToList(),
                Profession = ProfessionDTO.ToDTO(userInfo.Profession),
                ResidenceVisaInfo = ResidenceVisaInfoDTO.ToDTO(userInfo.ResidenceVisaInfo),
                UserID = userInfo.UserID
            };
        }

        public static UserInfo FromDTO(UserInfoDTO dto)
        {
            return new UserInfo
            {
                
                FullName = dto.FullName,
                Nationality = dto.Nationality,
                Gender = dto.Gender,
                DOB = dto.DOB,
                BirthCountry = dto.BirthCountry,
                BirthPlace = dto.BirthPlace,
                Height = dto.Height,
                Peculiarity = dto.Peculiarity,
                DomicileAddress = dto.DomicileAddress,
                AddressDuringSriLanka = dto.AddressDuringSriLanka,
                Telephone = dto.Telephone,
                Mobile = dto.Mobile,
                Fax = dto.Fax,
                Email = dto.Email,
                CivilStatus = dto.CivilStatus,
                EmergencyContacts = dto.EmergencyContacts?.Select(ec => EmergencyContactDTO.FromDTO(ec)).ToList(),
                NaturalizationInfo = NaturalizationInfoDTO.FromDTO( dto.NaturalizationInfo),
                Spouse = SpouseInfoDTO.FromDTO( dto.Spouse),
                Passport = PassportDTO.FromDTO (dto.Passport),
                EntryVisas = dto.EntryVisas?.Select(ev => EntryVisaInfoDTO.FromDTO(ev)).ToList(),
                Children = dto.Children?.Select(c => ChildrenDTO.FromDTO(c)).ToList(),
                Profession = ProfessionDTO.FromDTO( dto.Profession),
                ResidenceVisaInfo = ResidenceVisaInfoDTO.FromDTO( dto.ResidenceVisaInfo),
                UserID = dto.UserID
            };
        }


    }

}
