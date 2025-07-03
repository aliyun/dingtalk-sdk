// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksalary_1_0.models;

import com.aliyun.tea.*;

public class GetSalaryCalculationResponseBody extends TeaModel {
    @NameInMap("result")
    public GetSalaryCalculationResponseBodyResult result;

    public static GetSalaryCalculationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSalaryCalculationResponseBody self = new GetSalaryCalculationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSalaryCalculationResponseBody setResult(GetSalaryCalculationResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetSalaryCalculationResponseBodyResult getResult() {
        return this.result;
    }

    public static class GetSalaryCalculationResponseBodyResult extends TeaModel {
        @NameInMap("calStatus")
        public Boolean calStatus;

        /**
         * <strong>example:</strong>
         * <p>2025-06-30</p>
         */
        @NameInMap("endDate")
        public String endDate;

        /**
         * <strong>example:</strong>
         * <p>2025-06-01</p>
         */
        @NameInMap("startDate")
        public String startDate;

        /**
         * <strong>example:</strong>
         * <p>NONE</p>
         */
        @NameInMap("status")
        public String status;

        public static GetSalaryCalculationResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetSalaryCalculationResponseBodyResult self = new GetSalaryCalculationResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetSalaryCalculationResponseBodyResult setCalStatus(Boolean calStatus) {
            this.calStatus = calStatus;
            return this;
        }
        public Boolean getCalStatus() {
            return this.calStatus;
        }

        public GetSalaryCalculationResponseBodyResult setEndDate(String endDate) {
            this.endDate = endDate;
            return this;
        }
        public String getEndDate() {
            return this.endDate;
        }

        public GetSalaryCalculationResponseBodyResult setStartDate(String startDate) {
            this.startDate = startDate;
            return this;
        }
        public String getStartDate() {
            return this.startDate;
        }

        public GetSalaryCalculationResponseBodyResult setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

    }

}
