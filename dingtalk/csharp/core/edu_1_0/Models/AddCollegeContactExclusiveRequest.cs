// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class AddCollegeContactExclusiveRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>@lALPDfmVUw19YdrNA-jNA-g</para>
        /// </summary>
        [NameInMap("avatarMediaId")]
        [Validation(Required=false)]
        public string AvatarMediaId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deptIdList")]
        [Validation(Required=false)]
        public List<long?> DeptIdList { get; set; }

        [NameInMap("deptOrderList")]
        [Validation(Required=false)]
        public List<AddCollegeContactExclusiveRequestDeptOrderList> DeptOrderList { get; set; }
        public class AddCollegeContactExclusiveRequestDeptOrderList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order")]
            [Validation(Required=false)]
            public int? Order { get; set; }

        }

        [NameInMap("deptPositionSet")]
        [Validation(Required=false)]
        public List<AddCollegeContactExclusiveRequestDeptPositionSet> DeptPositionSet { get; set; }
        public class AddCollegeContactExclusiveRequestDeptPositionSet : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>001</para>
            /// </summary>
            [NameInMap("managerUserId")]
            [Validation(Required=false)]
            public string ManagerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学工处处长</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学工处办公室</para>
            /// </summary>
            [NameInMap("workPlace")]
            [Validation(Required=false)]
            public string WorkPlace { get; set; }

        }

        [NameInMap("deptTitleList")]
        [Validation(Required=false)]
        public List<AddCollegeContactExclusiveRequestDeptTitleList> DeptTitleList { get; set; }
        public class AddCollegeContactExclusiveRequestDeptTitleList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("deptId")]
            [Validation(Required=false)]
            public long? DeptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>学工处处长</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
        /// </summary>
        [NameInMap("email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>college_student</para>
        /// </summary>
        [NameInMap("empType")]
        [Validation(Required=false)]
        public string EmpType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("exclusiveAccount")]
        [Validation(Required=false)]
        public bool? ExclusiveAccount { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("exclusiveAccountType")]
        [Validation(Required=false)]
        public string ExclusiveAccountType { get; set; }

        [NameInMap("exclusiveMobileVerifyStatus")]
        [Validation(Required=false)]
        public string ExclusiveMobileVerifyStatus { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1597573616828</para>
        /// </summary>
        [NameInMap("hiredDate")]
        [Validation(Required=false)]
        public long? HiredDate { get; set; }

        [NameInMap("initPassword")]
        [Validation(Required=false)]
        public string InitPassword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>666666</para>
        /// </summary>
        [NameInMap("jobNumber")]
        [Validation(Required=false)]
        public string JobNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>studentNo</para>
        /// </summary>
        [NameInMap("loginIdType")]
        [Validation(Required=false)]
        public string LoginIdType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("mainDeptId")]
        [Validation(Required=false)]
        public long? MainDeptId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>001</para>
        /// </summary>
        [NameInMap("managerUserid")]
        [Validation(Required=false)]
        public string ManagerUserid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>185xxxx8888</para>
        /// </summary>
        [NameInMap("mobile")]
        [Validation(Required=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>昵称</para>
        /// </summary>
        [NameInMap("nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="mailto:test@xxx.com">test@xxx.com</a></para>
        /// </summary>
        [NameInMap("orgEmail")]
        [Validation(Required=false)]
        public string OrgEmail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>profession</para>
        /// </summary>
        [NameInMap("orgEmailType")]
        [Validation(Required=false)]
        public string OrgEmailType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>备注</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("sendActiveSms")]
        [Validation(Required=false)]
        public bool? SendActiveSms { get; set; }

        [NameInMap("seniorMode")]
        [Validation(Required=false)]
        public bool? SeniorMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>010-86123456-2345</para>
        /// </summary>
        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>学工处处长</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zhangsan666</para>
        /// </summary>
        [NameInMap("userid")]
        [Validation(Required=false)]
        public string Userid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>学工处办公室</para>
        /// </summary>
        [NameInMap("workPlace")]
        [Validation(Required=false)]
        public string WorkPlace { get; set; }

    }

}
