// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryItemGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSalaryItemGroupResponseBodyResult> result;

    public static GetSalaryItemGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryItemGroupResponseBody self = new GetSalaryItemGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSalaryItemGroupResponseBody setResult(java.util.List<GetSalaryItemGroupResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSalaryItemGroupResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetSalaryItemGroupResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>SalaryItemGroupIdxxx</p>
         */
        @NameInMap("salaryItemGroupId")
        public String salaryItemGroupId;

        /**
         * <strong>example:</strong>
         * <p>浮动薪资xx</p>
         */
        @NameInMap("salaryItemGroupName")
        public String salaryItemGroupName;

        public static GetSalaryItemGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSalaryItemGroupResponseBodyResult self = new GetSalaryItemGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSalaryItemGroupResponseBodyResult setSalaryItemGroupId(String salaryItemGroupId) {
            this.salaryItemGroupId = salaryItemGroupId;
            return this;
        }
        public String getSalaryItemGroupId() {
            return this.salaryItemGroupId;
        }

        public GetSalaryItemGroupResponseBodyResult setSalaryItemGroupName(String salaryItemGroupName) {
            this.salaryItemGroupName = salaryItemGroupName;
            return this;
        }
        public String getSalaryItemGroupName() {
            return this.salaryItemGroupName;
        }

    }

}
