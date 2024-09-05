namespace AuthAPI.Models;

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
        public string Fax { get; set; }
        public string Email { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public List<EmergencyContactDTO> EmergencyContacts { get; set; }
        public NaturalizationInfoDTO NaturalizationInfo { get; set; }
        public SpouseInfoDTO Spouse { get; set; }
        public PassportDTO Passport { get; set; }
        public List<EntryVisaInfoDTO> EntryVisas { get; set; }
        public List<ChildrenDTO> Children { get; set; }
        public ProfessionDTO Profession { get; set; }
        public ResidenceVisaInfoDTO ResidenceVisaInfo { get; set; }
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
                EmergencyContacts = userInfo.EmergencyContacts?.Select(ec => EmergencyContact.ToDTO(ec)).ToList(),
                NaturalizationInfo = userInfo.NaturalizationInfo?.ToDTO(),
                Spouse = userInfo.Spouse?.ToDTO(),
                Passport = userInfo.Passport?.ToDTO(),
                EntryVisas = userInfo.EntryVisas?.Select(ev => EntryVisaInfo.ToDTO(ev)).ToList(),
                Children = userInfo.Children?.Select(c => Children.ToDTO(c)).ToList(),
                Profession = userInfo.Profession?.ToDTO(),
                ResidenceVisaInfo = userInfo.ResidenceVisaInfo?.ToDTO(),
                UserID = userInfo.UserID
            };
        }

        public static UserInfo FromDTO(UserInfoDTO dto)
        {
            return new UserInfo
            {
                Id = dto.Id,
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
                EmergencyContacts = dto.EmergencyContacts?.Select(ec => EmergencyContact.FromDTO(ec)).ToList(),
                NaturalizationInfo = dto.NaturalizationInfo?.FromDTO(),
                Spouse = dto.Spouse?.FromDTO(),
                Passport = dto.Passport?.FromDTO(),
                EntryVisas = dto.EntryVisas?.Select(ev => EntryVisaInfo.FromDTO(ev)).ToList(),
                Children = dto.Children?.Select(c => Children.FromDTO(c)).ToList(),
                Profession = dto.Profession?.FromDTO(),
                ResidenceVisaInfo = dto.ResidenceVisaInfo?.FromDTO(),
                UserID = dto.UserID
            };
        }


    }

}
