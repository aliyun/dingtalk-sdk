// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>DCCD7A656FFA6F07</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
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
        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>oapi</p>
         */
        @NameInMap("leaveReason")
        public String leaveReason;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>2021-01-06T11:47:37Z</p>
         */
        @NameInMap("leaveTime")
        public String leaveTime;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>185xxxx7676</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>86</p>
         */
        @NameInMap("stateCode")
        public String stateCode;

        /**
         * <p>This parameter is required.</p>
         * 
         * <strong>example:</strong>
         * <p>10000</p>
         */
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
