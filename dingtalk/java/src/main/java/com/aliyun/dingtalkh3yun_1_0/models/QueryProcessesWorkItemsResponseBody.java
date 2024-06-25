// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesWorkItemsResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>success</p>
     */
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<QueryProcessesWorkItemsResponseBodyData> data;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>OK</p>
     */
    @NameInMap("message")
    public String message;

    public static QueryProcessesWorkItemsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        QueryProcessesWorkItemsResponseBody self = new QueryProcessesWorkItemsResponseBody();
        return TeaModel.build(map, self);
    }

    public QueryProcessesWorkItemsResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public QueryProcessesWorkItemsResponseBody setData(java.util.List<QueryProcessesWorkItemsResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<QueryProcessesWorkItemsResponseBodyData> getData() {
        return this.data;
    }

    public QueryProcessesWorkItemsResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public static class QueryProcessesWorkItemsResponseBodyDataFinisher extends TeaModel {
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

        public static QueryProcessesWorkItemsResponseBodyDataFinisher build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesWorkItemsResponseBodyDataFinisher self = new QueryProcessesWorkItemsResponseBodyDataFinisher();
            return TeaModel.build(map, self);
        }

        public QueryProcessesWorkItemsResponseBodyDataFinisher setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryProcessesWorkItemsResponseBodyDataFinisher setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryProcessesWorkItemsResponseBodyDataFinisher setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProcessesWorkItemsResponseBodyDataFinisher setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryProcessesWorkItemsResponseBodyDataParticipant extends TeaModel {
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

        public static QueryProcessesWorkItemsResponseBodyDataParticipant build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesWorkItemsResponseBodyDataParticipant self = new QueryProcessesWorkItemsResponseBodyDataParticipant();
            return TeaModel.build(map, self);
        }

        public QueryProcessesWorkItemsResponseBodyDataParticipant setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryProcessesWorkItemsResponseBodyDataParticipant setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryProcessesWorkItemsResponseBodyDataParticipant setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProcessesWorkItemsResponseBodyDataParticipant setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryProcessesWorkItemsResponseBodyDataReceiptor extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("userId")
        public String userId;

        public static QueryProcessesWorkItemsResponseBodyDataReceiptor build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesWorkItemsResponseBodyDataReceiptor self = new QueryProcessesWorkItemsResponseBodyDataReceiptor();
            return TeaModel.build(map, self);
        }

        public QueryProcessesWorkItemsResponseBodyDataReceiptor setDepartmentId(String departmentId) {
            this.departmentId = departmentId;
            return this;
        }
        public String getDepartmentId() {
            return this.departmentId;
        }

        public QueryProcessesWorkItemsResponseBodyDataReceiptor setDepartmentName(String departmentName) {
            this.departmentName = departmentName;
            return this;
        }
        public String getDepartmentName() {
            return this.departmentName;
        }

        public QueryProcessesWorkItemsResponseBodyDataReceiptor setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public QueryProcessesWorkItemsResponseBodyDataReceiptor setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class QueryProcessesWorkItemsResponseBodyData extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>Activity1</p>
         */
        @NameInMap("activityCode")
        public String activityCode;

        /**
         * <strong>example:</strong>
         * <p>发起流程</p>
         */
        @NameInMap("activityName")
        public String activityName;

        /**
         * <strong>example:</strong>
         * <p>D000001</p>
         */
        @NameInMap("appCode")
        public String appCode;

        /**
         * <strong>example:</strong>
         * <p>106f870b-4d1c-4cd0-85b3-2e866798e947</p>
         */
        @NameInMap("bizObjectId")
        public String bizObjectId;

        /**
         * <strong>example:</strong>
         * <p>同意</p>
         */
        @NameInMap("comment")
        public String comment;

        /**
         * <strong>example:</strong>
         * <p>发起流程</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <strong>example:</strong>
         * <p>null</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("finisher")
        public QueryProcessesWorkItemsResponseBodyDataFinisher finisher;

        /**
         * <strong>example:</strong>
         * <p>true</p>
         */
        @NameInMap("isApproval")
        public Boolean isApproval;

        /**
         * <strong>example:</strong>
         * <p>false</p>
         */
        @NameInMap("isFinish")
        public Boolean isFinish;

        @NameInMap("participant")
        public QueryProcessesWorkItemsResponseBodyDataParticipant participant;

        /**
         * <strong>example:</strong>
         * <p>006f870b-4d1c-4cd0-85b3-2e866798e947</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <strong>example:</strong>
         * <p>3</p>
         */
        @NameInMap("processVersion")
        public String processVersion;

        @NameInMap("receiptor")
        public QueryProcessesWorkItemsResponseBodyDataReceiptor receiptor;

        /**
         * <strong>example:</strong>
         * <p>2021-11-19 19:36:54</p>
         */
        @NameInMap("receiveTimeGMT")
        public String receiveTimeGMT;

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
         * <p>Waiting</p>
         */
        @NameInMap("state")
        public String state;

        /**
         * <strong>example:</strong>
         * <p>3d0ad4a4-d7d5-4196-9f2c-3ed246f2b713</p>
         */
        @NameInMap("workItemId")
        public String workItemId;

        /**
         * <strong>example:</strong>
         * <p>Fill</p>
         */
        @NameInMap("workItemType")
        public String workItemType;

        public static QueryProcessesWorkItemsResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            QueryProcessesWorkItemsResponseBodyData self = new QueryProcessesWorkItemsResponseBodyData();
            return TeaModel.build(map, self);
        }

        public QueryProcessesWorkItemsResponseBodyData setActivityCode(String activityCode) {
            this.activityCode = activityCode;
            return this;
        }
        public String getActivityCode() {
            return this.activityCode;
        }

        public QueryProcessesWorkItemsResponseBodyData setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public QueryProcessesWorkItemsResponseBodyData setAppCode(String appCode) {
            this.appCode = appCode;
            return this;
        }
        public String getAppCode() {
            return this.appCode;
        }

        public QueryProcessesWorkItemsResponseBodyData setBizObjectId(String bizObjectId) {
            this.bizObjectId = bizObjectId;
            return this;
        }
        public String getBizObjectId() {
            return this.bizObjectId;
        }

        public QueryProcessesWorkItemsResponseBodyData setComment(String comment) {
            this.comment = comment;
            return this;
        }
        public String getComment() {
            return this.comment;
        }

        public QueryProcessesWorkItemsResponseBodyData setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public QueryProcessesWorkItemsResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public QueryProcessesWorkItemsResponseBodyData setFinisher(QueryProcessesWorkItemsResponseBodyDataFinisher finisher) {
            this.finisher = finisher;
            return this;
        }
        public QueryProcessesWorkItemsResponseBodyDataFinisher getFinisher() {
            return this.finisher;
        }

        public QueryProcessesWorkItemsResponseBodyData setIsApproval(Boolean isApproval) {
            this.isApproval = isApproval;
            return this;
        }
        public Boolean getIsApproval() {
            return this.isApproval;
        }

        public QueryProcessesWorkItemsResponseBodyData setIsFinish(Boolean isFinish) {
            this.isFinish = isFinish;
            return this;
        }
        public Boolean getIsFinish() {
            return this.isFinish;
        }

        public QueryProcessesWorkItemsResponseBodyData setParticipant(QueryProcessesWorkItemsResponseBodyDataParticipant participant) {
            this.participant = participant;
            return this;
        }
        public QueryProcessesWorkItemsResponseBodyDataParticipant getParticipant() {
            return this.participant;
        }

        public QueryProcessesWorkItemsResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public QueryProcessesWorkItemsResponseBodyData setProcessVersion(String processVersion) {
            this.processVersion = processVersion;
            return this;
        }
        public String getProcessVersion() {
            return this.processVersion;
        }

        public QueryProcessesWorkItemsResponseBodyData setReceiptor(QueryProcessesWorkItemsResponseBodyDataReceiptor receiptor) {
            this.receiptor = receiptor;
            return this;
        }
        public QueryProcessesWorkItemsResponseBodyDataReceiptor getReceiptor() {
            return this.receiptor;
        }

        public QueryProcessesWorkItemsResponseBodyData setReceiveTimeGMT(String receiveTimeGMT) {
            this.receiveTimeGMT = receiveTimeGMT;
            return this;
        }
        public String getReceiveTimeGMT() {
            return this.receiveTimeGMT;
        }

        public QueryProcessesWorkItemsResponseBodyData setSchemaCode(String schemaCode) {
            this.schemaCode = schemaCode;
            return this;
        }
        public String getSchemaCode() {
            return this.schemaCode;
        }

        public QueryProcessesWorkItemsResponseBodyData setStartTimeGMT(String startTimeGMT) {
            this.startTimeGMT = startTimeGMT;
            return this;
        }
        public String getStartTimeGMT() {
            return this.startTimeGMT;
        }

        public QueryProcessesWorkItemsResponseBodyData setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public QueryProcessesWorkItemsResponseBodyData setWorkItemId(String workItemId) {
            this.workItemId = workItemId;
            return this;
        }
        public String getWorkItemId() {
            return this.workItemId;
        }

        public QueryProcessesWorkItemsResponseBodyData setWorkItemType(String workItemType) {
            this.workItemType = workItemType;
            return this;
        }
        public String getWorkItemType() {
            return this.workItemType;
        }

    }

}
