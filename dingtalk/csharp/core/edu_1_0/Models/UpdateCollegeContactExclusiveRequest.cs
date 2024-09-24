// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class UpdateCollegeContactExclusiveRequest : TeaModel {
        [NameInMap("avatarMediaId")]
        [Validation(Required=false)]
        public string AvatarMediaId { get; set; }

        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        [NameInMap("deptOrderList")]
        [Validation(Required=false)]
        public List<UpdateCollegeContactExclusiveRequestDeptOrderList> DeptOrderList { get; set; }
        public class UpdateCollegeContactExclusiveRequestDeptOrderList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

        }

        [NameInMap("deptTitleList")]
        [Validation(Required=false)]
        public List<UpdateCollegeContactExclusiveRequestDeptTitleList> DeptTitleList { get; set; }
        public class UpdateCollegeContactExclusiveRequestDeptTitleList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("empType")]
        [Validation(Required=false)]
        public string EmpType { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("forceUpdateFields")]
        [Validation(Required=false)]
        public string ForceUpdateFields { get; set; }

        [NameInMap("hideMobile")]
        [Validation(Required=false)]
        public bool? HideMobile { get; set; }

        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("loginIdType")]
        [Validation(Required=false)]
        public string LoginIdType { get; set; }

        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        [NameInMap("managerUserid")]
        [Validation(Required=false)]
        public string ManagerUserid { get; set; }

        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        [NameInMap("orgEmail")]
        [Validation(Required=false)]
        public string OrgEmail { get; set; }

        [NameInMap("orgEmailType")]
        [Validation(Required=false)]
        public string OrgEmailType { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("seniorMode")]
        [Validation(Required=false)]
        public bool? SeniorMode { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
