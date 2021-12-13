// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceResponseBody extends TeaModel {
    // 状态码
    @NameInMap("code")
    public String code;

    // 提示信息
    @NameInMap("message")
    public String message;

    // 返回结果
    @NameInMap("data")
    public java.util.List<QueryProcessesInstanceResponseBodyData> data;

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

    public QueryProcessesInstanceResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public QueryProcessesInstanceResponseBody setData(java.util.List<QueryProcessesInstanceResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryProcessesInstanceResponseBodyData> getData() {
        return this.data;
    }

    public static class QueryProcessesInstanceResponseBodyDataOriginator extends TeaModel {
        // 用户id
        @NameInMap("userId")
        public String userId;

        // 用户名称
        @NameInMap("name")
        public String name;

        // 所属组织id
        @NameInMap("departmentId")
        public String departmentId;

        // 所属组织名称
        @NameInMap("departmentName")
        public String departmentName;

        public static QueryProcessesInstanceResponseBodyDataOriginator build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesInstanceResponseBodyDataOriginator self = new QueryProcessesInstanceResponseBodyDataOriginator();
            return TeaModel.build(map, self);
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public QueryProcessesInstanceResponseBodyDataOriginator setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
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

    }

    public static class QueryProcessesInstanceResponseBodyData extends TeaModel {
        // 流程实例ID
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // 钉钉流程Id
        @NameInMap("dingTalkProcessId")
        public String dingTalkProcessId;

        // 流程名称
        @NameInMap("processDisplayName")
        public String processDisplayName;

        // 工作流模板的版本
        @NameInMap("processVersion")
        public Integer processVersion;

        // 流程所属的表单编码
        @NameInMap("schemaCode")
        public String schemaCode;

        // 流程关联的业务对象id
        @NameInMap("bizObjectId")
        public String bizObjectId;

        // 流程所属的应用编码
        @NameInMap("appCode")
        public String appCode;

        // 状态。Initiated=初始化完成，Starting=正在启动，Running=正在运行，Finishing=正在结束，Finished=已完成，Canceled=已取
        @NameInMap("state")
        public String state;

        // 流程发起人信息
        @NameInMap("originator")
        public QueryProcessesInstanceResponseBodyDataOriginator originator;

        // 创建时间
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        // 开始时间
        @NameInMap("startTimeGMT")
        public String startTimeGMT;

        // 完成时间
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        public static QueryProcessesInstanceResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesInstanceResponseBodyData self = new QueryProcessesInstanceResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryProcessesInstanceResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryProcessesInstanceResponseBodyData setDingTalkProcessId(String dingTalkProcessId) {
            this.dingTalkProcessId = dingTalkProcessId;
            return this;
        }
        public String getDingTalkProcessId() {
            return this.dingTalkProcessId;
        }

        public QueryProcessesInstanceResponseBodyData setProcessDisplayName(String processDisplayName) {
            this.processDisplayName = processDisplayName;
            return this;
        }
        public String getProcessDisplayName() {
            return this.processDisplayName;
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

        public QueryProcessesInstanceResponseBodyData setBizObjectId(String bizObjectId) {
            this.bizObjectId = bizObjectId;
            return this;
        }
        public String getBizObjectId() {
            return this.bizObjectId;
        }

        public QueryProcessesInstanceResponseBodyData setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryProcessesInstanceResponseBodyData setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public QueryProcessesInstanceResponseBodyData setOriginator(QueryProcessesInstanceResponseBodyDataOriginator originator) {
            this.originator = originator;
            return this;
        }
        public QueryProcessesInstanceResponseBodyDataOriginator getOriginator() {
            return this.originator;
        }

        public QueryProcessesInstanceResponseBodyData setCreatedTimeGMT(String createdTimeGMT) {
            this.createdTimeGMT = createdTimeGMT;
            return this;
        }
        public String getCreatedTimeGMT() {
            return this.createdTimeGMT;
        }

        public QueryProcessesInstanceResponseBodyData setStartTimeGMT(String startTimeGMT) {
            this.startTimeGMT = startTimeGMT;
            return this;
        }
        public String getStartTimeGMT() {
            return this.startTimeGMT;
        }

        public QueryProcessesInstanceResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

    }

}
