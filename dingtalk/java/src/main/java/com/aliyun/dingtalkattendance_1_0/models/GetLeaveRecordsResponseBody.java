// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkattendance_1_0.models;

import com.aliyun.tea.*;

public class GetLeaveRecordsResponseBody extends TeaModel {
    @NameInMap("result")
    public GetLeaveRecordsResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static GetLeaveRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetLeaveRecordsResponseBody self = new GetLeaveRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetLeaveRecordsResponseBody setResult(GetLeaveRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public GetLeaveRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public GetLeaveRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetLeaveRecordsResponseBodyResultLeaveRecords extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>add</p>
         */
        @NameInMap("calType")
        public String calType;

        /**
         * <strong>example:</strong>
         * <p>1753851001000</p>
         */
        @NameInMap("endTime")
        public Long endTime;

        /**
         * <strong>example:</strong>
         * <p>1653851001000</p>
         */
        @NameInMap("gmtCreate")
        public Long gmtCreate;

        /**
         * <strong>example:</strong>
         * <p>1753851001000</p>
         */
        @NameInMap("gmtModified")
        public Long gmtModified;

        /**
         * <strong>example:</strong>
         * <p>f84a2dxxxx</p>
         */
        @NameInMap("leaveCode")
        public String leaveCode;

        /**
         * <strong>example:</strong>
         * <p>管理员导入</p>
         */
        @NameInMap("leaveReason")
        public String leaveReason;

        /**
         * <strong>example:</strong>
         * <p>update</p>
         */
        @NameInMap("leaveRecordType")
        public String leaveRecordType;

        /**
         * <strong>example:</strong>
         * <p>init</p>
         */
        @NameInMap("leaveStatus")
        public String leaveStatus;

        /**
         * <strong>example:</strong>
         * <p>day</p>
         */
        @NameInMap("leaveViewUnit")
        public String leaveViewUnit;

        /**
         * <strong>example:</strong>
         * <p>manage223</p>
         */
        @NameInMap("opUserId")
        public String opUserId;

        /**
         * <strong>example:</strong>
         * <p>db1d74xxxxbaa</p>
         */
        @NameInMap("quotaId")
        public String quotaId;

        /**
         * <strong>example:</strong>
         * <p>db1d74xxxxbaa</p>
         */
        @NameInMap("recordId")
        public String recordId;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("recordNumPerDay")
        public Long recordNumPerDay;

        /**
         * <strong>example:</strong>
         * <p>100</p>
         */
        @NameInMap("recordNumPerHour")
        public Long recordNumPerHour;

        /**
         * <strong>example:</strong>
         * <p>1653851001000</p>
         */
        @NameInMap("startTime")
        public Long startTime;

        /**
         * <strong>example:</strong>
         * <p>user1</p>
         */
        @NameInMap("userId")
        public String userId;

        public static GetLeaveRecordsResponseBodyResultLeaveRecords build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveRecordsResponseBodyResultLeaveRecords self = new GetLeaveRecordsResponseBodyResultLeaveRecords();
            return TeaModel.build(map, self);
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setCalType(String calType) {
            this.calType = calType;
            return this;
        }
        public String getCalType() {
            return this.calType;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setEndTime(Long endTime) {
            this.endTime = endTime;
            return this;
        }
        public Long getEndTime() {
            return this.endTime;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setGmtCreate(Long gmtCreate) {
            this.gmtCreate = gmtCreate;
            return this;
        }
        public Long getGmtCreate() {
            return this.gmtCreate;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setGmtModified(Long gmtModified) {
            this.gmtModified = gmtModified;
            return this;
        }
        public Long getGmtModified() {
            return this.gmtModified;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setLeaveCode(String leaveCode) {
            this.leaveCode = leaveCode;
            return this;
        }
        public String getLeaveCode() {
            return this.leaveCode;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setLeaveReason(String leaveReason) {
            this.leaveReason = leaveReason;
            return this;
        }
        public String getLeaveReason() {
            return this.leaveReason;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setLeaveRecordType(String leaveRecordType) {
            this.leaveRecordType = leaveRecordType;
            return this;
        }
        public String getLeaveRecordType() {
            return this.leaveRecordType;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setLeaveStatus(String leaveStatus) {
            this.leaveStatus = leaveStatus;
            return this;
        }
        public String getLeaveStatus() {
            return this.leaveStatus;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setLeaveViewUnit(String leaveViewUnit) {
            this.leaveViewUnit = leaveViewUnit;
            return this;
        }
        public String getLeaveViewUnit() {
            return this.leaveViewUnit;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setOpUserId(String opUserId) {
            this.opUserId = opUserId;
            return this;
        }
        public String getOpUserId() {
            return this.opUserId;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setQuotaId(String quotaId) {
            this.quotaId = quotaId;
            return this;
        }
        public String getQuotaId() {
            return this.quotaId;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setRecordId(String recordId) {
            this.recordId = recordId;
            return this;
        }
        public String getRecordId() {
            return this.recordId;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setRecordNumPerDay(Long recordNumPerDay) {
            this.recordNumPerDay = recordNumPerDay;
            return this;
        }
        public Long getRecordNumPerDay() {
            return this.recordNumPerDay;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setRecordNumPerHour(Long recordNumPerHour) {
            this.recordNumPerHour = recordNumPerHour;
            return this;
        }
        public Long getRecordNumPerHour() {
            return this.recordNumPerHour;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setStartTime(Long startTime) {
            this.startTime = startTime;
            return this;
        }
        public Long getStartTime() {
            return this.startTime;
        }

        public GetLeaveRecordsResponseBodyResultLeaveRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetLeaveRecordsResponseBodyResult extends TeaModel {
        @NameInMap("hasMore")
        public Boolean hasMore;

        @NameInMap("leaveRecords")
        public java.util.List<GetLeaveRecordsResponseBodyResultLeaveRecords> leaveRecords;

        public static GetLeaveRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetLeaveRecordsResponseBodyResult self = new GetLeaveRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetLeaveRecordsResponseBodyResult setHasMore(Boolean hasMore) {
            this.hasMore = hasMore;
            return this;
        }
        public Boolean getHasMore() {
            return this.hasMore;
        }

        public GetLeaveRecordsResponseBodyResult setLeaveRecords(java.util.List<GetLeaveRecordsResponseBodyResultLeaveRecords> leaveRecords) {
            this.leaveRecords = leaveRecords;
            return this;
        }
        public java.util.List<GetLeaveRecordsResponseBodyResultLeaveRecords> getLeaveRecords() {
            return this.leaveRecords;
        }

    }

}
