// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesWorkItemsResponseBody extends TeaModel {
    @NameInMap("code")
    public String code;

    @NameInMap("data")
    public java.util.List<QueryProcessesWorkItemsResponseBodyData> data;

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
        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("name")
        public String name;

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
        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("name")
        public String name;

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
        @NameInMap("departmentId")
        public String departmentId;

        @NameInMap("departmentName")
        public String departmentName;

        @NameInMap("name")
        public String name;

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
        @NameInMap("activityCode")
        public String activityCode;

        @NameInMap("activityName")
        public String activityName;

        @NameInMap("appCode")
        public String appCode;

        @NameInMap("bizObjectId")
        public String bizObjectId;

        @NameInMap("comment")
        public String comment;

        @NameInMap("displayName")
        public String displayName;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("finisher")
        public QueryProcessesWorkItemsResponseBodyDataFinisher finisher;

        @NameInMap("isApproval")
        public Boolean isApproval;

        @NameInMap("isFinish")
        public Boolean isFinish;

        @NameInMap("participant")
        public QueryProcessesWorkItemsResponseBodyDataParticipant participant;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processVersion")
        public String processVersion;

        @NameInMap("receiptor")
        public QueryProcessesWorkItemsResponseBodyDataReceiptor receiptor;

        @NameInMap("receiveTimeGMT")
        public String receiveTimeGMT;

        @NameInMap("schemaCode")
        public String schemaCode;

        @NameInMap("startTimeGMT")
        public String startTimeGMT;

        @NameInMap("state")
        public String state;

        @NameInMap("workItemId")
        public String workItemId;

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
