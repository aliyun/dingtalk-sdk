// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class InitAndGetLeaveALlocationQuotasResponseBody extends TeaModel {
    // 返回结果。
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
        // 额度有效期结束时间。
        @NameInMap("endTime")
        public Long endTime;

        // 假期类型标识。
        @NameInMap("leaveCode")
        public String leaveCode;

        // 年度。
        @NameInMap("quotaCycle")
        public String quotaCycle;

        // 余额标识。
        @NameInMap("quotaId")
        public String quotaId;

        // 以天计算额度总数。
        @NameInMap("quotaNumPerDay")
        public Long quotaNumPerDay;

        // 以小时计算额度总数。
        @NameInMap("quotaNumPerHour")
        public Long quotaNumPerHour;

        // 额度有效期开始时间。
        @NameInMap("startTime")
        public Long startTime;

        // 用过的配额天数。
        @NameInMap("usedNumPerDay")
        public Long usedNumPerDay;

        // 用过的配额小时数。
        @NameInMap("usedNumPerHour")
        public Long usedNumPerHour;

        // 用户id。
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
