// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalksalary_1_0.Models
{
    public class ListSalaryCalculationResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public ListSalaryCalculationResponseBodyResult Result { get; set; }
        public class ListSalaryCalculationResponseBodyResult : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public List<ListSalaryCalculationResponseBodyResultData> Data { get; set; }
            public class ListSalaryCalculationResponseBodyResultData : TeaModel {
                [NameInMap("dataList")]
                [Validation(Required=false)]
                public List<ListSalaryCalculationResponseBodyResultDataDataList> DataList { get; set; }
                public class ListSalaryCalculationResponseBodyResultDataDataList : TeaModel {
                    [NameInMap("salaryItemId")]
                    [Validation(Required=false)]
                    public string SalaryItemId { get; set; }

                    [NameInMap("salaryItemName")]
                    [Validation(Required=false)]
                    public string SalaryItemName { get; set; }

                    [NameInMap("salaryItemValue")]
                    [Validation(Required=false)]
                    public string SalaryItemValue { get; set; }

                }

                [NameInMap("userId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("hasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

        }

    }

}
