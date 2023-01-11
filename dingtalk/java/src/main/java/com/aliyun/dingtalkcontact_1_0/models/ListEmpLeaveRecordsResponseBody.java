// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsResponseBody extends TeaModel {
    /**
     * <p>分页token</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>离职记录列表</p>
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
         * <p>离职原因(oapi-开放平台删除，cancel-注销，leave-主动离职，unknown-未知原因，delete-管理员删除）</p>
         */
        @NameInMap("leaveReason")
        public String leaveReason;

        /**
         * <p>离职时间</p>
         */
        @NameInMap("leaveTime")
        public String leaveTime;

        /**
         * <p>手机号码</p>
         */
        @NameInMap("mobile")
        public String mobile;

        /**
         * <p>员工名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>国际电话区号</p>
         */
        @NameInMap("stateCode")
        public String stateCode;

        /**
         * <p>员工userid</p>
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
