// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsResponseBody extends TeaModel {
    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("records")
    public java.util.List<ListEmpLeaveRecordsResponseBodyRecords> records;

    public static ListEmpLeaveRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEmpLeaveRecordsResponseBody self = new ListEmpLeaveRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEmpLeaveRecordsResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListEmpLeaveRecordsResponseBody setRecords(java.util.List<ListEmpLeaveRecordsResponseBodyRecords> records) {
        this.records = records;
        return this;
    }
    public java.util.List<ListEmpLeaveRecordsResponseBodyRecords> getRecords() {
        return this.records;
    }

    public static class ListEmpLeaveRecordsResponseBodyRecords extends TeaModel {
        @NameInMap("leaveReason")
        public String leaveReason;

        @NameInMap("leaveTime")
        public String leaveTime;

        @NameInMap("mobile")
        public String mobile;

        @NameInMap("name")
        public String name;

        @NameInMap("stateCode")
        public String stateCode;

        @NameInMap("userId")
        public String userId;

        public static ListEmpLeaveRecordsResponseBodyRecords build(java.util.Map<String, ?> map) throws Exception {
            ListEmpLeaveRecordsResponseBodyRecords self = new ListEmpLeaveRecordsResponseBodyRecords();
            return TeaModel.build(map, self);
        }

        public ListEmpLeaveRecordsResponseBodyRecords setLeaveReason(String leaveReason) {
            this.leaveReason = leaveReason;
            return this;
        }
        public String getLeaveReason() {
            return this.leaveReason;
        }

        public ListEmpLeaveRecordsResponseBodyRecords setLeaveTime(String leaveTime) {
            this.leaveTime = leaveTime;
            return this;
        }
        public String getLeaveTime() {
            return this.leaveTime;
        }

        public ListEmpLeaveRecordsResponseBodyRecords setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public ListEmpLeaveRecordsResponseBodyRecords setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListEmpLeaveRecordsResponseBodyRecords setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public ListEmpLeaveRecordsResponseBodyRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

}
