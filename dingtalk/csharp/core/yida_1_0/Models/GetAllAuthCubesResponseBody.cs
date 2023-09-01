// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkyida_1_0.Models
{
    public class GetAllAuthCubesResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<GetAllAuthCubesResponseBodyResult> Result { get; set; }
        public class GetAllAuthCubesResponseBodyResult : TeaModel {
            [NameInMap("apappliedCount")]
            [Validation(Required=false)]
            public int? ApappliedCount { get; set; }

            [NameInMap("appCode")]
            [Validation(Required=false)]
            public string AppCode { get; set; }

            [NameInMap("appInstanceCode")]
            [Validation(Required=false)]
            public string AppInstanceCode { get; set; }

            [NameInMap("appStoreCode")]
            [Validation(Required=false)]
            public string AppStoreCode { get; set; }

            [NameInMap("authMode")]
            [Validation(Required=false)]
            public string AuthMode { get; set; }

            [NameInMap("authorizationType")]
            [Validation(Required=false)]
            public int? AuthorizationType { get; set; }

            [NameInMap("businessProcessCode")]
            [Validation(Required=false)]
            public string BusinessProcessCode { get; set; }

            [NameInMap("categoriesFirst")]
            [Validation(Required=false)]
            public string CategoriesFirst { get; set; }

            [NameInMap("categoriesSecond")]
            [Validation(Required=false)]
            public string CategoriesSecond { get; set; }

            [NameInMap("createTimeGMT")]
            [Validation(Required=false)]
            public string CreateTimeGMT { get; set; }

            [NameInMap("creatorUserId")]
            [Validation(Required=false)]
            public string CreatorUserId { get; set; }

            [NameInMap("cubeAuthType")]
            [Validation(Required=false)]
            public string CubeAuthType { get; set; }

            [NameInMap("cubeCode")]
            [Validation(Required=false)]
            public string CubeCode { get; set; }

            [NameInMap("cubeDataRange")]
            [Validation(Required=false)]
            public string CubeDataRange { get; set; }

            [NameInMap("cubeDataRanges")]
            [Validation(Required=false)]
            public List<GetAllAuthCubesResponseBodyResultCubeDataRanges> CubeDataRanges { get; set; }
            public class GetAllAuthCubesResponseBodyResultCubeDataRanges : TeaModel {
                [NameInMap("classifiedCode")]
                [Validation(Required=false)]
                public string ClassifiedCode { get; set; }

                [NameInMap("conditionKey")]
                [Validation(Required=false)]
                public string ConditionKey { get; set; }

                [NameInMap("conditionValue")]
                [Validation(Required=false)]
                public List<object> ConditionValue { get; set; }

                [NameInMap("elementCode")]
                [Validation(Required=false)]
                public string ElementCode { get; set; }

                [NameInMap("elementType")]
                [Validation(Required=false)]
                public string ElementType { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

            }

            [NameInMap("cubeSource")]
            [Validation(Required=false)]
            public string CubeSource { get; set; }

            [NameInMap("dataCacheTimeConfiguration")]
            [Validation(Required=false)]
            public string DataCacheTimeConfiguration { get; set; }

            [NameInMap("dataflowCode")]
            [Validation(Required=false)]
            public string DataflowCode { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("domainCode")]
            [Validation(Required=false)]
            public string DomainCode { get; set; }

            [NameInMap("enableCache")]
            [Validation(Required=false)]
            public bool? EnableCache { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("isNeedApplication")]
            [Validation(Required=false)]
            public string IsNeedApplication { get; set; }

            [NameInMap("isTrend")]
            [Validation(Required=false)]
            public string IsTrend { get; set; }

            [NameInMap("modifiedTimeGMT")]
            [Validation(Required=false)]
            public string ModifiedTimeGMT { get; set; }

            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("namespaceCode")]
            [Validation(Required=false)]
            public string NamespaceCode { get; set; }

            [NameInMap("owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            [NameInMap("sharedDataSet")]
            [Validation(Required=false)]
            public bool? SharedDataSet { get; set; }

            [NameInMap("tenantCorpId")]
            [Validation(Required=false)]
            public string TenantCorpId { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("userInformation")]
            [Validation(Required=false)]
            public GetAllAuthCubesResponseBodyResultUserInformation UserInformation { get; set; }
            public class GetAllAuthCubesResponseBodyResultUserInformation : TeaModel {
                [NameInMap("authProvider")]
                [Validation(Required=false)]
                public string AuthProvider { get; set; }

                [NameInMap("corpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                [NameInMap("departmentName")]
                [Validation(Required=false)]
                public string DepartmentName { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("nickName")]
                [Validation(Required=false)]
                public string NickName { get; set; }

                [NameInMap("realmId")]
                [Validation(Required=false)]
                public long? RealmId { get; set; }

                [NameInMap("refererNamespaceCode")]
                [Validation(Required=false)]
                public string RefererNamespaceCode { get; set; }

                [NameInMap("showName")]
                [Validation(Required=false)]
                public string ShowName { get; set; }

                [NameInMap("workNo")]
                [Validation(Required=false)]
                public string WorkNo { get; set; }

            }

        }

    }

}
