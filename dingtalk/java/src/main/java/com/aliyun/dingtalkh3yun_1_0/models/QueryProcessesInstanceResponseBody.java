// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesInstanceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<QueryProcessesInstanceResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
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
        /**
         * <strong>example:</strong>
         * <p>18f923a7-5a5e-426d-94ae-a55ad1a4b240</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <strong>example:</strong>
         * <p>研发中心</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>aea4d7a7-d162-4c77-9c44-7bd9cb8316a5</p>
         */
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
        /**
         * <strong>example:</strong>
         * <p>D000183D000185</p>
         */
        @NameInMap("appCode")
        public String appCode;

        /**
         * <strong>example:</strong>
         * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
         */
        @NameInMap("bizObjectId")
        public String bizObjectId;

        /**
         * <strong>example:</strong>
         * <p>2021-11-19 19:36:54</p>
         */
        @NameInMap("createdTimeGMT")
        public String createdTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("dingTalkProcessId")
        public String dingTalkProcessId;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("originator")
        public QueryProcessesInstanceResponseBodyDataOriginator originator;

        /**
         * <strong>example:</strong>
         * <p>报销管理</p>
         */
        @NameInMap("processDisplayName")
        public String processDisplayName;

        /**
         * <strong>example:</strong>
         * <p>3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("processVersion")
        public Integer processVersion;

        /**
         * <strong>example:</strong>
         * <p>D0001833abb0fb61524487eb01848207bc89b47</p>
         */
        @NameInMap("schemaCode")
        public String schemaCode;

        /**
         * <strong>example:</strong>
         * <p>2021-11-19 19:36:54</p>
         */
        @NameInMap("startTimeGMT")
        public String startTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>Running</p>
         */
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
