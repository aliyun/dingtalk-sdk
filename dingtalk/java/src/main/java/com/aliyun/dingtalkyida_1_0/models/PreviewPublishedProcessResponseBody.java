// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class PreviewPublishedProcessResponseBody extends TeaModel {
    @NameInMap("result")
    public java.util.List<PreviewPublishedProcessResponseBodyResult> result;

    public static PreviewPublishedProcessResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PreviewPublishedProcessResponseBody self = new PreviewPublishedProcessResponseBody();
        return TeaModel.build(map, self);
    }

    public PreviewPublishedProcessResponseBody setResult(java.util.List<PreviewPublishedProcessResponseBodyResult> result) {
        this.result = result;
        return this;
    }
    public java.util.List<PreviewPublishedProcessResponseBodyResult> getResult() {
        return this.result;
    }

    public static class PreviewPublishedProcessResponseBodyResult extends TeaModel {
        @NameInMap("action")
        public String action;

        @NameInMap("actionExit")
        public String actionExit;

        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        @NameInMap("activityId")
        public String activityId;

        @NameInMap("dataId")
        public Long dataId;

        @NameInMap("digitalSign")
        public String digitalSign;

        @NameInMap("domains")
        public java.util.List<?> domains;

        @NameInMap("files")
        public String files;

        @NameInMap("operateTimeGMT")
        public String operateTimeGMT;

        @NameInMap("operateType")
        public String operateType;

        @NameInMap("operatorDisplayName")
        public String operatorDisplayName;

        @NameInMap("operatorName")
        public String operatorName;

        @NameInMap("operatorNickName")
        public String operatorNickName;

        @NameInMap("operatorPhotoUrl")
        public String operatorPhotoUrl;

        @NameInMap("operatorStatus")
        public String operatorStatus;

        @NameInMap("operatorUserId")
        public String operatorUserId;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("remark")
        public String remark;

        @NameInMap("showName")
        public String showName;

        @NameInMap("size")
        public Integer size;

        @NameInMap("taskExecuteType")
        public String taskExecuteType;

        @NameInMap("taskHoldTimeGMT")
        public Long taskHoldTimeGMT;

        @NameInMap("taskId")
        public String taskId;

        @NameInMap("taskType")
        public String taskType;

        @NameInMap("type")
        public String type;

        public static PreviewPublishedProcessResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            PreviewPublishedProcessResponseBodyResult self = new PreviewPublishedProcessResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public PreviewPublishedProcessResponseBodyResult setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public PreviewPublishedProcessResponseBodyResult setActionExit(String actionExit) {
            this.actionExit = actionExit;
            return this;
        }
        public String getActionExit() {
            return this.actionExit;
        }

        public PreviewPublishedProcessResponseBodyResult setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public PreviewPublishedProcessResponseBodyResult setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public PreviewPublishedProcessResponseBodyResult setDataId(Long dataId) {
            this.dataId = dataId;
            return this;
        }
        public Long getDataId() {
            return this.dataId;
        }

        public PreviewPublishedProcessResponseBodyResult setDigitalSign(String digitalSign) {
            this.digitalSign = digitalSign;
            return this;
        }
        public String getDigitalSign() {
            return this.digitalSign;
        }

        public PreviewPublishedProcessResponseBodyResult setDomains(java.util.List<?> domains) {
            this.domains = domains;
            return this;
        }
        public java.util.List<?> getDomains() {
            return this.domains;
        }

        public PreviewPublishedProcessResponseBodyResult setFiles(String files) {
            this.files = files;
            return this;
        }
        public String getFiles() {
            return this.files;
        }

        public PreviewPublishedProcessResponseBodyResult setOperateTimeGMT(String operateTimeGMT) {
            this.operateTimeGMT = operateTimeGMT;
            return this;
        }
        public String getOperateTimeGMT() {
            return this.operateTimeGMT;
        }

        public PreviewPublishedProcessResponseBodyResult setOperateType(String operateType) {
            this.operateType = operateType;
            return this;
        }
        public String getOperateType() {
            return this.operateType;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorDisplayName(String operatorDisplayName) {
            this.operatorDisplayName = operatorDisplayName;
            return this;
        }
        public String getOperatorDisplayName() {
            return this.operatorDisplayName;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorName(String operatorName) {
            this.operatorName = operatorName;
            return this;
        }
        public String getOperatorName() {
            return this.operatorName;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorNickName(String operatorNickName) {
            this.operatorNickName = operatorNickName;
            return this;
        }
        public String getOperatorNickName() {
            return this.operatorNickName;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorPhotoUrl(String operatorPhotoUrl) {
            this.operatorPhotoUrl = operatorPhotoUrl;
            return this;
        }
        public String getOperatorPhotoUrl() {
            return this.operatorPhotoUrl;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorStatus(String operatorStatus) {
            this.operatorStatus = operatorStatus;
            return this;
        }
        public String getOperatorStatus() {
            return this.operatorStatus;
        }

        public PreviewPublishedProcessResponseBodyResult setOperatorUserId(String operatorUserId) {
            this.operatorUserId = operatorUserId;
            return this;
        }
        public String getOperatorUserId() {
            return this.operatorUserId;
        }

        public PreviewPublishedProcessResponseBodyResult setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public PreviewPublishedProcessResponseBodyResult setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public PreviewPublishedProcessResponseBodyResult setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public PreviewPublishedProcessResponseBodyResult setSize(Integer size) {
            this.size = size;
            return this;
        }
        public Integer getSize() {
            return this.size;
        }

        public PreviewPublishedProcessResponseBodyResult setTaskExecuteType(String taskExecuteType) {
            this.taskExecuteType = taskExecuteType;
            return this;
        }
        public String getTaskExecuteType() {
            return this.taskExecuteType;
        }

        public PreviewPublishedProcessResponseBodyResult setTaskHoldTimeGMT(Long taskHoldTimeGMT) {
            this.taskHoldTimeGMT = taskHoldTimeGMT;
            return this;
        }
        public Long getTaskHoldTimeGMT() {
            return this.taskHoldTimeGMT;
        }

        public PreviewPublishedProcessResponseBodyResult setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public PreviewPublishedProcessResponseBodyResult setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public PreviewPublishedProcessResponseBodyResult setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
