// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<InitAndGetLeaveALlocationQuotasResponseBodyResult> result;

    public static InitAndGetLeaveALlocationQuotasResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InitAndGetLeaveALlocationQuotasResponseBody self = new InitAndGetLeaveALlocationQuotasResponseBody();
        return TeaModel.build(map, self);
    }

    public InitAndGetLeaveALlocationQuotasResponseBody setResult(java.util.List<InitAndGetLeaveALlocationQuotasResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<InitAndGetLeaveALlocationQuotasResponseBodyResult> getResult() {
        return this.result;
    }

    public static class InitAndGetLeaveALlocationQuotasResponseBodyResult extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>1753851001000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>c00ced14-xxxxxd438748</p>
         */
        @NameInMap("leaveCode")
        public String leaveCode;

        /**
         * <strong>example:</strong>
         * <p>2022</p>
         */
        @NameInMap("quotaCycle")
        public String quotaCycle;

        /**
         * <strong>example:</strong>
         * <p>b13cc5b0--xxxx5b0</p>
         */
        @NameInMap("quotaId")
        public String quotaId;

        /**
         * <strong>example:</strong>
         * <p>700</p>
         */
        @NameInMap("quotaNumPerDay")
        public Long quotaNumPerDay;

        /**
         * <strong>example:</strong>
         * <p>800</p>
         */
        @NameInMap("quotaNumPerHour")
        public Long quotaNumPerHour;

        /**
         * <strong>example:</strong>
         * <p>1653851001000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>200</p>
         */
        @NameInMap("usedNumPerDay")
        public Long usedNumPerDay;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("usedNumPerHour")
        public Long usedNumPerHour;

        /**
         * <strong>example:</strong>
         * <p>user1</p>
         */
        @NameInMap("userId")
        public String userId;

        public static InitAndGetLeaveALlocationQuotasResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            InitAndGetLeaveALlocationQuotasResponseBodyResult self = new InitAndGetLeaveALlocationQuotasResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setQuotaCycle(String quotaCycle) {
            this.quotaCycle = quotaCycle;
            return this;
        }
        public String getQuotaCycle() {
            return this.quotaCycle;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setQuotaId(String quotaId) {
            this.quotaId = quotaId;
            return this;
        }
        public String getQuotaId() {
            return this.quotaId;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setQuotaNumPerDay(Long quotaNumPerDay) {
            this.quotaNumPerDay = quotaNumPerDay;
            return this;
        }
        public Long getQuotaNumPerDay() {
            return this.quotaNumPerDay;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setQuotaNumPerHour(Long quotaNumPerHour) {
            this.quotaNumPerHour = quotaNumPerHour;
            return this;
        }
        public Long getQuotaNumPerHour() {
            return this.quotaNumPerHour;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setUsedNumPerDay(Long usedNumPerDay) {
            this.usedNumPerDay = usedNumPerDay;
            return this;
        }
        public Long getUsedNumPerDay() {
            return this.usedNumPerDay;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setUsedNumPerHour(Long usedNumPerHour) {
            this.usedNumPerHour = usedNumPerHour;
            return this;
        }
        public Long getUsedNumPerHour() {
            return this.usedNumPerHour;
        }

        public InitAndGetLeaveALlocationQuotasResponseBodyResult setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
