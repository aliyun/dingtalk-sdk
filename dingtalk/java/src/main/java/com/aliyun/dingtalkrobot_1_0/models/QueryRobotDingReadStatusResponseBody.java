// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class QueryRobotDingReadStatusResponseBody extends TeaModel {
    @NameInMap("result")
    public QueryRobotDingReadStatusResponseBodyResult result;

    @NameInMap("success")
    public Boolean success;

    public static QueryRobotDingReadStatusResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryRobotDingReadStatusResponseBody self = new QueryRobotDingReadStatusResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryRobotDingReadStatusResponseBody setResult(QueryRobotDingReadStatusResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public QueryRobotDingReadStatusResponseBodyResult getResult() {
        return this.result;
    }

    public QueryRobotDingReadStatusResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList extends TeaModel {
        @NameInMap("readStatus")
        public String readStatus;

        @NameInMap("userId")
        public String userId;

        public static QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList build(java.util.Map<String, ?> map) throws Exception {
            QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList self = new QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList();
            return TeaModel.build(map, self);
        }

        public QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList setReadStatus(String readStatus) {
            this.readStatus = readStatus;
            return this;
        }
        public String getReadStatus() {
            return this.readStatus;
        }

        public QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryRobotDingReadStatusResponseBodyResult extends TeaModel {
        @NameInMap("robotDingReadInfoList")
        public java.util.List<QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList> robotDingReadInfoList;

        public static QueryRobotDingReadStatusResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            QueryRobotDingReadStatusResponseBodyResult self = new QueryRobotDingReadStatusResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public QueryRobotDingReadStatusResponseBodyResult setRobotDingReadInfoList(java.util.List<QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList> robotDingReadInfoList) {
            this.robotDingReadInfoList = robotDingReadInfoList;
            return this;
        }
        public java.util.List<QueryRobotDingReadStatusResponseBodyResultRobotDingReadInfoList> getRobotDingReadInfoList() {
            return this.robotDingReadInfoList;
        }

    }

}
