// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCollegeContactUserRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        [NameInMap("deptOrderList")]
        [Validation(Required=false)]
        public List<AddCollegeContactUserRequestDeptOrderList> DeptOrderList { get; set; }
        public class AddCollegeContactUserRequestDeptOrderList : TeaModel {
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

        }

        [NameInMap("deptTitleList")]
        [Validation(Required=false)]
        public List<AddCollegeContactUserRequestDeptTitleList> DeptTitleList { get; set; }
        public class AddCollegeContactUserRequestDeptTitleList : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("empType")]
        [Validation(Required=false)]
        public string EmpType { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("hideMobile")]
        [Validation(Required=false)]
        public bool? HideMobile { get; set; }

        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        [NameInMap("loginEmail")]
        [Validation(Required=false)]
        public string LoginEmail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        [NameInMap("managerUserid")]
        [Validation(Required=false)]
        public string ManagerUserid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("orgEmail")]
        [Validation(Required=false)]
        public string OrgEmail { get; set; }

        [NameInMap("orgEmailType")]
        [Validation(Required=false)]
        public string OrgEmailType { get; set; }

        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("sendActiveSms")]
        [Validation(Required=false)]
        public bool? SendActiveSms { get; set; }

        [NameInMap("seniorMode")]
        [Validation(Required=false)]
        public bool? SeniorMode { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
