// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOperationRecordsResponseBody extends TeaModel {
    // 流程实例操作记录数组
    @NameInMap("result")
    public java.util.List<GetOperationRecordsResponseBodyResult> result;

    public static GetOperationRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetOperationRecordsResponseBody self = new GetOperationRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public GetOperationRecordsResponseBody setResult(java.util.List<GetOperationRecordsResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<GetOperationRecordsResponseBodyResult> getResult() {
        return this.result;
    }

    public static class GetOperationRecordsResponseBodyResult extends TeaModel {
        // action
        @NameInMap("action")
        public String action;

        // actionExt
        @NameInMap("actionExit")
        public String actionExit;

        // activeTime
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        // activityId
        @NameInMap("activityId")
        public String activityId;

        // id
        @NameInMap("dataId")
        public Long dataId;

        // digitalSign
        @NameInMap("digitalSign")
        public String digitalSign;

        // files
        @NameInMap("files")
        public String files;

        // operateTime
        @NameInMap("operateTimeGMT")
        public String operateTimeGMT;

        // operateType
        @NameInMap("operateType")
        public String operateType;

        // operatorDisplayName
        @NameInMap("operatorDisplayName")
        public String operatorDisplayName;

        // operatorName
        @NameInMap("operatorName")
        public String operatorName;

        // operatorNick
        @NameInMap("operatorNickName")
        public String operatorNickName;

        // operatorPhotoUrl
        @NameInMap("operatorPhotoUrl")
        public String operatorPhotoUrl;

        // operatorStatus
        @NameInMap("operatorStatus")
        public String operatorStatus;

        // operator
        @NameInMap("operatorUserId")
        public String operatorUserId;

        // processInstanceId
        @NameInMap("processInstanceId")
        public String processInstanceId;

        // remark
        @NameInMap("remark")
        public String remark;

        // showName
        @NameInMap("showName")
        public String showName;

        // size
        @NameInMap("size")
        public Integer size;

        // taskExecuteType
        @NameInMap("taskExecuteType")
        public String taskExecuteType;

        // taskHoldTime
        @NameInMap("taskHoldTimeGMT")
        public Long taskHoldTimeGMT;

        // taskId
        @NameInMap("taskId")
        public String taskId;

        // taskType
        @NameInMap("taskType")
        public String taskType;

        // type
        @NameInMap("type")
        public String type;

        public static GetOperationRecordsResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            GetOperationRecordsResponseBodyResult self = new GetOperationRecordsResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public GetOperationRecordsResponseBodyResult setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public GetOperationRecordsResponseBodyResult setActionExit(String actionExit) {
            this.actionExit = actionExit;
            return this;
        }
        public String getActionExit() {
            return this.actionExit;
        }

        public GetOperationRecordsResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetOperationRecordsResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetOperationRecordsResponseBodyResult setDataId(Long dataId) {
            this.dataId = dataId;
            return this;
        }
        public Long getDataId() {
            return this.dataId;
        }

        public GetOperationRecordsResponseBodyResult setDigitalSign(String digitalSign) {
            this.digitalSign = digitalSign;
            return this;
        }
        public String getDigitalSign() {
            return this.digitalSign;
        }

        public GetOperationRecordsResponseBodyResult setFiles(String files) {
            this.files = files;
            return this;
        }
        public String getFiles() {
            return this.files;
        }

        public GetOperationRecordsResponseBodyResult setOperateTimeGMT(String operateTimeGMT) {
            this.operateTimeGMT = operateTimeGMT;
            return this;
        }
        public String getOperateTimeGMT() {
            return this.operateTimeGMT;
        }

        public GetOperationRecordsResponseBodyResult setOperateType(String operateType) {
            this.operateType = operateType;
            return this;
        }
        public String getOperateType() {
            return this.operateType;
        }

        public GetOperationRecordsResponseBodyResult setOperatorDisplayName(String operatorDisplayName) {
            this.operatorDisplayName = operatorDisplayName;
            return this;
        }
        public String getOperatorDisplayName() {
            return this.operatorDisplayName;
        }

        public GetOperationRecordsResponseBodyResult setOperatorName(String operatorName) {
            this.operatorName = operatorName;
            return this;
        }
        public String getOperatorName() {
            return this.operatorName;
        }

        public GetOperationRecordsResponseBodyResult setOperatorNickName(String operatorNickName) {
            this.operatorNickName = operatorNickName;
            return this;
        }
        public String getOperatorNickName() {
            return this.operatorNickName;
        }

        public GetOperationRecordsResponseBodyResult setOperatorPhotoUrl(String operatorPhotoUrl) {
            this.operatorPhotoUrl = operatorPhotoUrl;
            return this;
        }
        public String getOperatorPhotoUrl() {
            return this.operatorPhotoUrl;
        }

        public GetOperationRecordsResponseBodyResult setOperatorStatus(String operatorStatus) {
            this.operatorStatus = operatorStatus;
            return this;
        }
        public String getOperatorStatus() {
            return this.operatorStatus;
        }

        public GetOperationRecordsResponseBodyResult setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

        public GetOperationRecordsResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetOperationRecordsResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetOperationRecordsResponseBodyResult setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public GetOperationRecordsResponseBodyResult setSize(Integer size) {
            this.size = size;
            return this;
        }
        public Integer getSize() {
            return this.size;
        }

        public GetOperationRecordsResponseBodyResult setTaskExecuteType(String taskExecuteType) {
            this.taskExecuteType = taskExecuteType;
            return this;
        }
        public String getTaskExecuteType() {
            return this.taskExecuteType;
        }

        public GetOperationRecordsResponseBodyResult setTaskHoldTimeGMT(Long taskHoldTimeGMT) {
            this.taskHoldTimeGMT = taskHoldTimeGMT;
            return this;
        }
        public Long getTaskHoldTimeGMT() {
            return this.taskHoldTimeGMT;
        }

        public GetOperationRecordsResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetOperationRecordsResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetOperationRecordsResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
