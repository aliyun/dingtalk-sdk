// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class ListEmpLeaveRecordsResponseBody extends TeaModel {
    // errorMsg
    @NameInMap("errorMsg")
    public String errorMsg;

    // dingOpenErrcode
    @NameInMap("dingOpenErrcode")
    public Integer dingOpenErrcode;

    // success
    @NameInMap("success")
    public Boolean success;

    // result
    @NameInMap("result")
    public ListEmpLeaveRecordsResponseBodyResult result;

    public static ListEmpLeaveRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ListEmpLeaveRecordsResponseBody self = new ListEmpLeaveRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public ListEmpLeaveRecordsResponseBody setErrorMsg(String errorMsg) {
        this.errorMsg = errorMsg;
        return this;
    }
    public String getErrorMsg() {
        return this.errorMsg;
    }

    public ListEmpLeaveRecordsResponseBody setDingOpenErrcode(Integer dingOpenErrcode) {
        this.dingOpenErrcode = dingOpenErrcode;
        return this;
    }
    public Integer getDingOpenErrcode() {
        return this.dingOpenErrcode;
    }

    public ListEmpLeaveRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public ListEmpLeaveRecordsResponseBody setResult(ListEmpLeaveRecordsResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public ListEmpLeaveRecordsResponseBodyResult getResult() {
        return this.result;
    }

    public static class ListEmpLeaveRecordsResponseBodyResultRecords extends TeaModel {
        // 员工userid
        @NameInMap("userId")
        public String userId;

        // 员工名称
        @NameInMap("name")
        public String name;

        // 国际电话区号
        @NameInMap("stateCode")
        public String stateCode;

        // 手机号码
        @NameInMap("mobile")
        public String mobile;

        // 离职时间
        @NameInMap("leaveTime")
        public String leaveTime;

        // 离职原因(oapi-开放平台删除，cancel-注销，leave-主动离职，unknown-未知原因，delete-管理员删除）
        @NameInMap("leaveReason")
        public String leaveReason;

        public static ListEmpLeaveRecordsResponseBodyResultRecords build(java.util.Map<String, ?> map) throws Exception {
            ListEmpLeaveRecordsResponseBodyResultRecords self = new ListEmpLeaveRecordsResponseBodyResultRecords();
            return TeaModel.build(map, self);
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setStateCode(String stateCode) {
            this.stateCode = stateCode;
            return this;
        }
        public String getStateCode() {
            return this.stateCode;
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setMobile(String mobile) {
            this.mobile = mobile;
            return this;
        }
        public String getMobile() {
            return this.mobile;
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setLeaveTime(String leaveTime) {
            this.leaveTime = leaveTime;
            return this;
        }
        public String getLeaveTime() {
            return this.leaveTime;
        }

        public ListEmpLeaveRecordsResponseBodyResultRecords setLeaveReason(String leaveReason) {
            this.leaveReason = leaveReason;
            return this;
        }
        public String getLeaveReason() {
            return this.leaveReason;
        }

    }

    public static class ListEmpLeaveRecordsResponseBodyResult extends TeaModel {
        // 分页token
        @NameInMap("nextToken")
        public String nextToken;

        // 离职记录列表
        @NameInMap("records")
        public java.util.List<ListEmpLeaveRecordsResponseBodyResultRecords> records;

        public static ListEmpLeaveRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            ListEmpLeaveRecordsResponseBodyResult self = new ListEmpLeaveRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public ListEmpLeaveRecordsResponseBodyResult setNextToken(String nextToken) {
            this.nextToken = nextToken;
            return this;
        }
        public String getNextToken() {
            return this.nextToken;
        }

        public ListEmpLeaveRecordsResponseBodyResult setRecords(java.util.List<ListEmpLeaveRecordsResponseBodyResultRecords> records) {
            this.records = records;
            return this;
        }
        public java.util.List<ListEmpLeaveRecordsResponseBodyResultRecords> getRecords() {
            return this.records;
        }

    }

}
