

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
        public int Height { get; set; }
        public string Peculiarity { get; set; }
        public string DomicileAddress { get; set; }
        public string AddressDuringSriLanka { get; set; }
        public int Periodofvisit{ get; set;}
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public DateTime? CreatedAt{ get; set; }
        public string Email { get; set; }
        public CivilStatus CivilStatus { get; set; }
        public List<EmergencyContactDTO>? EmergencyContacts { get; set; }
        public NaturalizationInfoDTO? NaturalizationInfo { get; set; }
        public SpouseInfoDTO? Spouse { get; set; }
        public PassportDTO? Passport { get; set; }
        public List<EntryVisaInfoDTO>? EntryVisas { get; set; }
        public ProfessionDTO? Profession { get; set; }
        public string Image { get; set; }
        public ResidenceVisaInfoDTO? ResidenceVisaInfo { get; set; }
        
        public VisaRequestStatusDTO? VisaRequestStatus { get; set; }
        
        public int UserID { get; set; }

        public static UserInfoDTO ToDTO(UserInfo userInfo)
        {
            return new UserInfoDTO
            {
                Id = userInfo.Id,
                FullName = userInfo.FullName,
                Nationality = userInfo.Nationality,
                Image=userInfo.Image,
                Gender = userInfo.Gender,
                DOB = userInfo.DOB,
                CreatedAt= userInfo.CreatedAt,
                Periodofvisit=userInfo.Periodofvisit,
                BirthCountry = userInfo.BirthCountry,
                BirthPlace = userInfo.BirthPlace,
                Height = userInfo.Height,
                Peculiarity = userInfo.Peculiarity,
                DomicileAddress = userInfo.DomicileAddress,
                AddressDuringSriLanka = userInfo.AddressDuringSriLanka,
                Telephone = userInfo.Telephone,
                Mobile = userInfo.Mobile,
                Email = userInfo.Email,
                CivilStatus = userInfo.CivilStatus,
                EmergencyContacts = userInfo.EmergencyContacts?.Select(ec => EmergencyContactDTO.ToDTO(ec)).ToList(),
                NaturalizationInfo = NaturalizationInfoDTO.ToDTO(userInfo.NaturalizationInfo),
                Spouse = SpouseInfoDTO.ToDTO(userInfo.Spouse),
                Passport = PassportDTO.ToDTO(userInfo.Passport),
                EntryVisas = userInfo.EntryVisas?.Select(ev => EntryVisaInfoDTO.ToDTO(ev)).ToList(),
                Profession = ProfessionDTO.ToDTO(userInfo.Profession),
                ResidenceVisaInfo = ResidenceVisaInfoDTO.ToDTO(userInfo.ResidenceVisaInfo),
                VisaRequestStatus=VisaRequestStatusDTO.ToDTO(userInfo.Status),
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
                Image=dto.Image,
                DOB = dto.DOB,
                CreatedAt= dto.CreatedAt,
                Periodofvisit = dto.Periodofvisit,
                BirthCountry = dto.BirthCountry,
                BirthPlace = dto.BirthPlace,
                Height = dto.Height,
                Peculiarity = dto.Peculiarity,
                DomicileAddress = dto.DomicileAddress,
                AddressDuringSriLanka = dto.AddressDuringSriLanka,
                Telephone = dto.Telephone,
                Mobile = dto.Mobile,
                Email = dto.Email,
                CivilStatus = dto.CivilStatus,
                EmergencyContacts = dto.EmergencyContacts?.Select(ec => EmergencyContactDTO.FromDTO(ec)).ToList(),
                NaturalizationInfo = NaturalizationInfoDTO.FromDTO( dto.NaturalizationInfo),
                Spouse = SpouseInfoDTO.FromDTO( dto.Spouse),
                Passport = PassportDTO.FromDTO (dto.Passport),
                EntryVisas = dto.EntryVisas?.Select(ev => EntryVisaInfoDTO.FromDTO(ev)).ToList(),
                Profession = ProfessionDTO.FromDTO( dto.Profession),
                ResidenceVisaInfo = ResidenceVisaInfoDTO.FromDTO( dto.ResidenceVisaInfo),
                Status = dto.VisaRequestStatus != null
                ? VisaRequestStatusDTO.FromDTO(dto.VisaRequestStatus)
                : new VisaRequestStatus(),
                UserID = dto.UserID
            };
        }


    }

}
