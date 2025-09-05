// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class UpdateVacationQuotaRequest extends TeaModel {
    @NameInMap("body")
    public java.util.List<UpdateVacationQuotaRequestBody> body;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user01</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    public static UpdateVacationQuotaRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateVacationQuotaRequest self = new UpdateVacationQuotaRequest();
        return TeaModel.build(map, self);
    }

    public UpdateVacationQuotaRequest setBody(java.util.List<UpdateVacationQuotaRequestBody> body) {
        this.body = body;
        return this;
    }
    public java.util.List<UpdateVacationQuotaRequestBody> getBody() {
        return this.body;
    }

    public UpdateVacationQuotaRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public static class UpdateVacationQuotaRequestBody extends TeaModel {
        @NameInMap("actionType")
        public String actionType;

        /**
         * <strong>example:</strong>
         * <p>1753851001000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <p>This parameter is required.</p>
         * 
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

        @NameInMap("quotaNumPerDay")
        public Integer quotaNumPerDay;

        @NameInMap("quotaNumPerHour")
        public Integer quotaNumPerHour;

        @NameInMap("reason")
        public String reason;

        /**
         * <strong>example:</strong>
         * <p>1653851001000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>user01</p>
         */
        @NameInMap("userId")
        public String userId;

        public static UpdateVacationQuotaRequestBody build(java.util.Map<String, ?> map) throws Exception {
            UpdateVacationQuotaRequestBody self = new UpdateVacationQuotaRequestBody();
            return TeaModel.build(map, self);
        }

        public UpdateVacationQuotaRequestBody setActionType(String actionType) {
            this.actionType = actionType;
            return this;
        }
        public String getActionType() {
            return this.actionType;
        }

        public UpdateVacationQuotaRequestBody setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public UpdateVacationQuotaRequestBody setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public UpdateVacationQuotaRequestBody setQuotaCycle(String quotaCycle) {
            this.quotaCycle = quotaCycle;
            return this;
        }
        public String getQuotaCycle() {
            return this.quotaCycle;
        }

        public UpdateVacationQuotaRequestBody setQuotaNumPerDay(Integer quotaNumPerDay) {
            this.quotaNumPerDay = quotaNumPerDay;
            return this;
        }
        public Integer getQuotaNumPerDay() {
            return this.quotaNumPerDay;
        }

        public UpdateVacationQuotaRequestBody setQuotaNumPerHour(Integer quotaNumPerHour) {
            this.quotaNumPerHour = quotaNumPerHour;
            return this;
        }
        public Integer getQuotaNumPerHour() {
            return this.quotaNumPerHour;
        }

        public UpdateVacationQuotaRequestBody setReason(String reason) {
            this.reason = reason;
            return this;
        }
        public String getReason() {
            return this.reason;
        }

        public UpdateVacationQuotaRequestBody setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public UpdateVacationQuotaRequestBody setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
