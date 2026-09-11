// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalkbizfinance_2_0.Models
{
    public class CreatePayableReceiptRequest : TeaModel {
        [NameInMap("receipt")]
        [Validation(Required=false)]
        public CreatePayableReceiptRequestReceipt Receipt { get; set; }
        public class CreatePayableReceiptRequestReceipt : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public string Amount { get; set; }

            [NameInMap("categoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("companyCode")]
            [Validation(Required=false)]
            public string CompanyCode { get; set; }

            [NameInMap("corpId")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("customerCode")]
            [Validation(Required=false)]
            public string CustomerCode { get; set; }

            [NameInMap("dangAnDataInfoList")]
            [Validation(Required=false)]
            public List<CreatePayableReceiptRequestReceiptDangAnDataInfoList> DangAnDataInfoList { get; set; }
            public class CreatePayableReceiptRequestReceiptDangAnDataInfoList : TeaModel {
                [NameInMap("dataCode")]
                [Validation(Required=false)]
                public string DataCode { get; set; }

                [NameInMap("defineCode")]
                [Validation(Required=false)]
                public string DefineCode { get; set; }

            }

            [NameInMap("departmentCode")]
            [Validation(Required=false)]
            public string DepartmentCode { get; set; }

            [NameInMap("empAccountUserId")]
            [Validation(Required=false)]
            public string EmpAccountUserId { get; set; }

            [NameInMap("enterpriseAccountCode")]
            [Validation(Required=false)]
            public string EnterpriseAccountCode { get; set; }

            [NameInMap("formCode")]
            [Validation(Required=false)]
            public string FormCode { get; set; }

            [NameInMap("occurDate")]
            [Validation(Required=false)]
            public long? OccurDate { get; set; }

            [NameInMap("principalId")]
            [Validation(Required=false)]
            public string PrincipalId { get; set; }

            [NameInMap("productCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("projectCode")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("receiptPlans")]
            [Validation(Required=false)]
            public List<CreatePayableReceiptRequestReceiptReceiptPlans> ReceiptPlans { get; set; }
            public class CreatePayableReceiptRequestReceiptReceiptPlans : TeaModel {
                [NameInMap("planAmount")]
                [Validation(Required=false)]
                public string PlanAmount { get; set; }

                [NameInMap("planDate")]
                [Validation(Required=false)]
                public long? PlanDate { get; set; }

                [NameInMap("planRemark")]
                [Validation(Required=false)]
                public string PlanRemark { get; set; }

                [NameInMap("uuid")]
                [Validation(Required=false)]
                public string Uuid { get; set; }

            }

            [NameInMap("receiptType")]
            [Validation(Required=false)]
            public long? ReceiptType { get; set; }

            [NameInMap("recodeTime")]
            [Validation(Required=false)]
            public long? RecodeTime { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("supplierCode")]
            [Validation(Required=false)]
            public string SupplierCode { get; set; }

            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
