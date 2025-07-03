// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryItemResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSalaryItemResponseBodyResult> result;

    public static GetSalaryItemResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryItemResponseBody self = new GetSalaryItemResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSalaryItemResponseBody setResult(java.util.List<GetSalaryItemResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSalaryItemResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetSalaryItemResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>SalaryItemIdxxx</p>
         */
        @NameInMap("salaryItemId")
        public String salaryItemId;

        /**
         * <strong>example:</strong>
         * <p>绩效xx</p>
         */
        @NameInMap("salaryItemName")
        public String salaryItemName;

        public static GetSalaryItemResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSalaryItemResponseBodyResult self = new GetSalaryItemResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSalaryItemResponseBodyResult setSalaryItemId(String salaryItemId) {
            this.salaryItemId = salaryItemId;
            return this;
        }
        public String getSalaryItemId() {
            return this.salaryItemId;
        }

        public GetSalaryItemResponseBodyResult setSalaryItemName(String salaryItemName) {
            this.salaryItemName = salaryItemName;
            return this;
        }
        public String getSalaryItemName() {
            return this.salaryItemName;
        }

    }

}
