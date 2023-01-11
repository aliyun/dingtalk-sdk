// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkh3yun_1_0.models;

import com.aliyun.tea.*;

public class QueryProcessesWorkItemsResponseBody extends TeaModel {
    /**
     * <p>状态码</p>
     */
    @NameInMap("code")
    public String code;

    /**
     * <p>返回结果</p>
     */
    @NameInMap("data")
    public java.util.List<QueryProcessesWorkItemsResponseBodyData> data;

    /**
     * <p>提示信息</p>
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
         * <p>用户直属的部门id</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <p>用户直属的部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户id</p>
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
         * <p>用户直属的部门id</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <p>用户直属的部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户id</p>
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
         * <p>用户直属的部门id</p>
         */
        @NameInMap("departmentId")
        public String departmentId;

        /**
         * <p>用户直属的部门名称</p>
         */
        @NameInMap("departmentName")
        public String departmentName;

        /**
         * <p>用户名称</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>用户id</p>
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
         * <p>活动编码</p>
         */
        @NameInMap("activityCode")
        public String activityCode;

        /**
         * <p>当前活动名称</p>
         */
        @NameInMap("activityName")
        public String activityName;

        /**
         * <p>应用编码</p>
         */
        @NameInMap("appCode")
        public String appCode;

        /**
         * <p>工作项所关联的业务对象id</p>
         */
        @NameInMap("bizObjectId")
        public String bizObjectId;

        /**
         * <p>对该工作项的意见</p>
         */
        @NameInMap("comment")
        public String comment;

        /**
         * <p>显示名称</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>完成时间</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        /**
         * <p>完成者</p>
         */
        @NameInMap("finisher")
        public QueryProcessesWorkItemsResponseBodyDataFinisher finisher;

        /**
         * <p>对该工作项是否同意</p>
         */
        @NameInMap("isApproval")
        public Boolean isApproval;

        /**
         * <p>是否已完成</p>
         */
        @NameInMap("isFinish")
        public Boolean isFinish;

        /**
         * <p>参与者</p>
         */
        @NameInMap("participant")
        public QueryProcessesWorkItemsResponseBodyDataParticipant participant;

        /**
         * <p>流程实例ID</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>工作流版本</p>
         */
        @NameInMap("processVersion")
        public String processVersion;

        /**
         * <p>转交工作的接收人。如无转接人，则为空</p>
         */
        @NameInMap("receiptor")
        public QueryProcessesWorkItemsResponseBodyDataReceiptor receiptor;

        /**
         * <p>接收时间</p>
         */
        @NameInMap("receiveTimeGMT")
        public String receiveTimeGMT;

        /**
         * <p>表单编码</p>
         */
        @NameInMap("schemaCode")
        public String schemaCode;

        /**
         * <p>开始这个任务的时间</p>
         */
        @NameInMap("startTimeGMT")
        public String startTimeGMT;

        /**
         * <p>状态。Waiting=等待的状态，Working=正在工作中的状态，Finished=处于完成状态，Canceled=已经被取消，Forwarded=已转交状态，Revoked=撤回</p>
         */
        @NameInMap("state")
        public String state;

        /**
         * <p>工作任务Id</p>
         */
        @NameInMap("workItemId")
        public String workItemId;

        /**
         * <p>工作项类型。Fill=普通工作项，Approve=审批类型工作项，Circulate=传阅</p>
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
