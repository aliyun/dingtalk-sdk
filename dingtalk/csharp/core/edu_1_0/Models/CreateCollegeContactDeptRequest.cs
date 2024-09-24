// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkedu_1_0.Models
{
    public class CreateCollegeContactDeptRequest : TeaModel {
        [NameInMap("autoApproveApply")]
        [Validation(Required=false)]
        public bool? AutoApproveApply { get; set; }

        [NameInMap("brief")]
        [Validation(Required=false)]
        public string Brief { get; set; }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("createDeptGroup")]
        [Validation(Required=false)]
        public bool? CreateDeptGroup { get; set; }

        [NameInMap("deptCode")]
        [Validation(Required=false)]
        public string DeptCode { get; set; }

        [NameInMap("deptPermits")]
        [Validation(Required=false)]
        public List<long?> DeptPermits { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("deptType")]
        [Validation(Required=false)]
        public string DeptType { get; set; }

        [NameInMap("empApplyJoinDept")]
        [Validation(Required=false)]
        public bool? EmpApplyJoinDept { get; set; }

        [NameInMap("extension")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extension { get; set; }

        [NameInMap("hideDept")]
        [Validation(Required=false)]
        public bool? HideDept { get; set; }

        [NameInMap("hideSceneConfig")]
        [Validation(Required=false)]
        public CreateCollegeContactDeptRequestHideSceneConfig HideSceneConfig { get; set; }
        public class CreateCollegeContactDeptRequestHideSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("chatboxSubtitle")]
            [Validation(Required=false)]
            public bool? ChatboxSubtitle { get; set; }

            [NameInMap("nodeList")]
            [Validation(Required=false)]
            public bool? NodeList { get; set; }

            [NameInMap("profile")]
            [Validation(Required=false)]
            public bool? Profile { get; set; }

            [NameInMap("search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("order")]
        [Validation(Required=false)]
        public long? Order { get; set; }

        [NameInMap("outerDept")]
        [Validation(Required=false)]
        public bool? OuterDept { get; set; }

        [NameInMap("outerDeptOnlySelf")]
        [Validation(Required=false)]
        public bool? OuterDeptOnlySelf { get; set; }

        [NameInMap("outerPermitDepts")]
        [Validation(Required=false)]
        public List<long?> OuterPermitDepts { get; set; }

        [NameInMap("outerPermitUsers")]
        [Validation(Required=false)]
        public List<string> OuterPermitUsers { get; set; }

        [NameInMap("outerSceneConfig")]
        [Validation(Required=false)]
        public CreateCollegeContactDeptRequestOuterSceneConfig OuterSceneConfig { get; set; }
        public class CreateCollegeContactDeptRequestOuterSceneConfig : TeaModel {
            [NameInMap("active")]
            [Validation(Required=false)]
            public bool? Active { get; set; }

            [NameInMap("chatboxSubtitle")]
            [Validation(Required=false)]
            public bool? ChatboxSubtitle { get; set; }

            [NameInMap("nodeList")]
            [Validation(Required=false)]
            public bool? NodeList { get; set; }

            [NameInMap("profile")]
            [Validation(Required=false)]
            public bool? Profile { get; set; }

            [NameInMap("search")]
            [Validation(Required=false)]
            public bool? Search { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("parentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("sourceIdentifier")]
        [Validation(Required=false)]
        public string SourceIdentifier { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("struId")]
        [Validation(Required=false)]
        public long? StruId { get; set; }

        [NameInMap("telephone")]
        [Validation(Required=false)]
        public string Telephone { get; set; }

        [NameInMap("userPermits")]
        [Validation(Required=false)]
        public List<string> UserPermits { get; set; }

    }

}
