// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryGroupResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<GetSalaryGroupResponseBodyResult> result;

    public static GetSalaryGroupResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryGroupResponseBody self = new GetSalaryGroupResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSalaryGroupResponseBody setResult(java.util.List<GetSalaryGroupResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetSalaryGroupResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetSalaryGroupResponseBodyResult extends TeaModel {
        @NameInMap("enableFlag")
        public Boolean enableFlag;

        /**
         * <strong>example:</strong>
         * <p>SalaryItemGroupIdxxx</p>
         */
        @NameInMap("salaryGroupId")
        public String salaryGroupId;

        /**
         * <strong>example:</strong>
         * <p>123</p>
         */
        @NameInMap("salaryGroupName")
        public String salaryGroupName;

        public static GetSalaryGroupResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSalaryGroupResponseBodyResult self = new GetSalaryGroupResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSalaryGroupResponseBodyResult setEnableFlag(Boolean enableFlag) {
            this.enableFlag = enableFlag;
            return this;
        }
        public Boolean getEnableFlag() {
            return this.enableFlag;
        }

        public GetSalaryGroupResponseBodyResult setSalaryGroupId(String salaryGroupId) {
            this.salaryGroupId = salaryGroupId;
            return this;
        }
        public String getSalaryGroupId() {
            return this.salaryGroupId;
        }

        public GetSalaryGroupResponseBodyResult setSalaryGroupName(String salaryGroupName) {
            this.salaryGroupName = salaryGroupName;
            return this;
        }
        public String getSalaryGroupName() {
            return this.salaryGroupName;
        }

    }

}
