// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkcontract_1_0.Models
{
    public class QueryContractSignInfoResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public QueryContractSignInfoResponseBodyResult Result { get; set; }
        public class QueryContractSignInfoResponseBodyResult : TeaModel {
            [NameInMap("actualOriginator")]
            [Validation(Required=false)]
            public QueryContractSignInfoResponseBodyResultActualOriginator ActualOriginator { get; set; }
            public class QueryContractSignInfoResponseBodyResultActualOriginator : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("staffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

            [NameInMap("amountType")]
            [Validation(Required=false)]
            public string AmountType { get; set; }

            [NameInMap("applicantDate")]
            [Validation(Required=false)]
            public long? ApplicantDate { get; set; }

            [NameInMap("approveTime")]
            [Validation(Required=false)]
            public long? ApproveTime { get; set; }

            [NameInMap("bizId")]
            [Validation(Required=false)]
            public string BizId { get; set; }

            [NameInMap("contractAmount")]
            [Validation(Required=false)]
            public string ContractAmount { get; set; }

            [NameInMap("contractAmountMethod")]
            [Validation(Required=false)]
            public string ContractAmountMethod { get; set; }

            [NameInMap("contractAttachmentFiles")]
            [Validation(Required=false)]
            public List<QueryContractSignInfoResponseBodyResultContractAttachmentFiles> ContractAttachmentFiles { get; set; }
            public class QueryContractSignInfoResponseBodyResultContractAttachmentFiles : TeaModel {
                [NameInMap("fileDownloadUrl")]
                [Validation(Required=false)]
                public string FileDownloadUrl { get; set; }

                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public long? SpaceId { get; set; }

            }

            [NameInMap("contractContentFiles")]
            [Validation(Required=false)]
            public List<QueryContractSignInfoResponseBodyResultContractContentFiles> ContractContentFiles { get; set; }
            public class QueryContractSignInfoResponseBodyResultContractContentFiles : TeaModel {
                [NameInMap("fileDownloadUrl")]
                [Validation(Required=false)]
                public string FileDownloadUrl { get; set; }

                [NameInMap("fileId")]
                [Validation(Required=false)]
                public string FileId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public string FileType { get; set; }

                [NameInMap("spaceId")]
                [Validation(Required=false)]
                public long? SpaceId { get; set; }

            }

            [NameInMap("contractEndDate")]
            [Validation(Required=false)]
            public long? ContractEndDate { get; set; }

            [NameInMap("contractId")]
            [Validation(Required=false)]
            public int? ContractId { get; set; }

            [NameInMap("contractName")]
            [Validation(Required=false)]
            public string ContractName { get; set; }

            [NameInMap("contractNo")]
            [Validation(Required=false)]
            public string ContractNo { get; set; }

            [NameInMap("contractRemark")]
            [Validation(Required=false)]
            public string ContractRemark { get; set; }

            [NameInMap("contractStartDate")]
            [Validation(Required=false)]
            public long? ContractStartDate { get; set; }

            [NameInMap("contractStatus")]
            [Validation(Required=false)]
            public string ContractStatus { get; set; }

            [NameInMap("contractTermType")]
            [Validation(Required=false)]
            public string ContractTermType { get; set; }

            [NameInMap("currencyCode")]
            [Validation(Required=false)]
            public string CurrencyCode { get; set; }

            [NameInMap("deptName")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("directoryName")]
            [Validation(Required=false)]
            public string DirectoryName { get; set; }

            [NameInMap("effectiveStatus")]
            [Validation(Required=false)]
            public string EffectiveStatus { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("oppositeParties")]
            [Validation(Required=false)]
            public List<QueryContractSignInfoResponseBodyResultOppositeParties> OppositeParties { get; set; }
            public class QueryContractSignInfoResponseBodyResultOppositeParties : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("phoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uniqueCode")]
                [Validation(Required=false)]
                public string UniqueCode { get; set; }

            }

            [NameInMap("ourParties")]
            [Validation(Required=false)]
            public List<QueryContractSignInfoResponseBodyResultOurParties> OurParties { get; set; }
            public class QueryContractSignInfoResponseBodyResultOurParties : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                [NameInMap("phoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("uniqueCode")]
                [Validation(Required=false)]
                public string UniqueCode { get; set; }

            }

            [NameInMap("ownerName")]
            [Validation(Required=false)]
            public string OwnerName { get; set; }

            [NameInMap("ownerStaffId")]
            [Validation(Required=false)]
            public string OwnerStaffId { get; set; }

            [NameInMap("processInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            [NameInMap("signers")]
            [Validation(Required=false)]
            public List<QueryContractSignInfoResponseBodyResultSigners> Signers { get; set; }
            public class QueryContractSignInfoResponseBodyResultSigners : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("staffId")]
                [Validation(Required=false)]
                public string StaffId { get; set; }

            }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
