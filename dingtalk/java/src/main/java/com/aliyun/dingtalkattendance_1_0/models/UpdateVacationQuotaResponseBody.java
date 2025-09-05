// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateVacationQuotaResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<UpdateVacationQuotaResponseBodyResult> result;

    public static UpdateVacationQuotaResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateVacationQuotaResponseBody self = new UpdateVacationQuotaResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateVacationQuotaResponseBody setResult(java.util.List<UpdateVacationQuotaResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<UpdateVacationQuotaResponseBodyResult> getResult() {
        return this.result;
    }

    public static class UpdateVacationQuotaResponseBodyResultQuota extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>f84a2829-d245-4312-9ff2-0653e5b3abb2</p>
         */
        @NameInMap("leaveCode")
        public String leaveCode;

        /**
         * <strong>example:</strong>
         * <p>2019</p>
         */
        @NameInMap("quotaCycle")
        public String quotaCycle;

        /**
         * <strong>example:</strong>
         * <p>user01</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateVacationQuotaResponseBodyResultQuota build(java.util.Map<String, ?> map) throws Exception {
            UpdateVacationQuotaResponseBodyResultQuota self = new UpdateVacationQuotaResponseBodyResultQuota();
            return TeaModel.build(map, self);
        }

        public UpdateVacationQuotaResponseBodyResultQuota setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public UpdateVacationQuotaResponseBodyResultQuota setQuotaCycle(String quotaCycle) {
            this.quotaCycle = quotaCycle;
            return this;
        }
        public String getQuotaCycle() {
            return this.quotaCycle;
        }

        public UpdateVacationQuotaResponseBodyResultQuota setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class UpdateVacationQuotaResponseBodyResult extends TeaModel {
        @NameInMap("quota")
        public UpdateVacationQuotaResponseBodyResultQuota quota;

        /**
         * <strong>example:</strong>
         * <p>假期类型不存在</p>
         */
        @NameInMap("reason")
        public String reason;

        public static UpdateVacationQuotaResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateVacationQuotaResponseBodyResult self = new UpdateVacationQuotaResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateVacationQuotaResponseBodyResult setQuota(UpdateVacationQuotaResponseBodyResultQuota quota) {
            this.quota = quota;
            return this;
        }
        public UpdateVacationQuotaResponseBodyResultQuota getQuota() {
            return this.quota;
        }

        public UpdateVacationQuotaResponseBodyResult setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

    }

}
