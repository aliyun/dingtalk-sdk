// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<QueryProcessesInstanceResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("message")
    public String message;

    public static QueryProcessesInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesInstanceResponseBody self = new QueryProcessesInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProcessesInstanceResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryProcessesInstanceResponseBody setData(java.util.List<QueryProcessesInstanceResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryProcessesInstanceResponseBodyData> getData() {
        return this.data;
    }

    public QueryProcessesInstanceResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class QueryProcessesInstanceResponseBodyDataOriginator extends TeaModel {
        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("name")
        public String name;

        @NameInMap("userId")
        public String userId;

        public static QueryProcessesInstanceResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesInstanceResponseBodyDataOriginator self = new QueryProcessesInstanceResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryProcessesInstanceResponseBodyData extends TeaModel {
        @NameInMap("appCode")
        public String appCode;

        @NameInMap("bizObjectId")
        public String bizObjectId;

        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        @NameInMap("dingTalkProcessId")
        public String dingTalkProcessId;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("originator")
        public QueryProcessesInstanceResponseBodyDataOriginator originator;

        @NameInMap("processDisplayName")
        public String processDisplayName;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processVersion")
        public Integer processVersion;

        @NameInMap("schemaCode")
        public String schemaCode;

        @NameInMap("startTimeGMT")
        public String startTimeGMT;

        @NameInMap("state")
        public String state;

        public static QueryProcessesInstanceResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesInstanceResponseBodyData self = new QueryProcessesInstanceResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryProcessesInstanceResponseBodyData setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryProcessesInstanceResponseBodyData setBizObjectId(String bizObjectId) {
            this.bizObjectId = bizObjectId;
            return this;
        }
        public String getBizObjectId() {
            return this.bizObjectId;
        }

        public QueryProcessesInstanceResponseBodyData setCreatedTimeGMT(String createdTimeGMT) {
            this.createdTimeGMT = createdTimeGMT;
            return this;
        }
        public String getCreatedTimeGMT() {
            return this.createdTimeGMT;
        }

        public QueryProcessesInstanceResponseBodyData setDingTalkProcessId(String dingTalkProcessId) {
            this.dingTalkProcessId = dingTalkProcessId;
            return this;
        }
        public String getDingTalkProcessId() {
            return this.dingTalkProcessId;
        }

        public QueryProcessesInstanceResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public QueryProcessesInstanceResponseBodyData setOriginator(QueryProcessesInstanceResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public QueryProcessesInstanceResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public QueryProcessesInstanceResponseBodyData setProcessDisplayName(String processDisplayName) {
            this.processDisplayName = processDisplayName;
            return this;
        }
        public String getProcessDisplayName() {
            return this.processDisplayName;
        }

        public QueryProcessesInstanceResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryProcessesInstanceResponseBodyData setProcessVersion(Integer processVersion) {
            this.processVersion = processVersion;
            return this;
        }
        public Integer getProcessVersion() {
            return this.processVersion;
        }

        public QueryProcessesInstanceResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

        public QueryProcessesInstanceResponseBodyData setStartTimeGMT(String startTimeGMT) {
            this.startTimeGMT = startTimeGMT;
            return this;
        }
        public String getStartTimeGMT() {
            return this.startTimeGMT;
        }

        public QueryProcessesInstanceResponseBodyData setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

    }

}
