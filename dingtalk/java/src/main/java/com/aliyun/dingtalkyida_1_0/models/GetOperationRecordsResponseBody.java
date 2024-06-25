// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetOperationRecordsResponseBody extends TeaModel {
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

    public static class GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>开发部成立于2000年</p>
         */
        @NameInMap("departmentDescription")
        public String departmentDescription;

        /**
         * <strong>example:</strong>
         * <p>测试应用</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <strong>example:</strong>
         * <p>ZhangSan</p>
         */
        @NameInMap("displayNameInEnglish")
        public String displayNameInEnglish;

        /**
         * <strong>example:</strong>
         * <p>o-YDJKINSSDLLND</p>
         */
        @NameInMap("orderNumber")
        public String orderNumber;

        /**
         * <strong>example:</strong>
         * <p><a href="https://abc.com/a.png">https://abc.com/a.png</a></p>
         */
        @NameInMap("personalPhoto")
        public String personalPhoto;

        /**
         * <strong>example:</strong>
         * <p>running</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <strong>example:</strong>
         * <p>ding173982232112232</p>
         */
        @NameInMap("userId")
        public String userId;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("userInformation")
        public String userInformation;

        public static GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList build(java.util.Map<String, ?> map) throws Exception {
            GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList self = new GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList();
            return TeaModel.build(map, self);
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setDepartmentDescription(String departmentDescription) {
            this.departmentDescription = departmentDescription;
            return this;
        }
        public String getDepartmentDescription() {
            return this.departmentDescription;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setDisplayNameInEnglish(String displayNameInEnglish) {
            this.displayNameInEnglish = displayNameInEnglish;
            return this;
        }
        public String getDisplayNameInEnglish() {
            return this.displayNameInEnglish;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setOrderNumber(String orderNumber) {
            this.orderNumber = orderNumber;
            return this;
        }
        public String getOrderNumber() {
            return this.orderNumber;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setPersonalPhoto(String personalPhoto) {
            this.personalPhoto = personalPhoto;
            return this;
        }
        public String getPersonalPhoto() {
            return this.personalPhoto;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList setUserInformation(String userInformation) {
            this.userInformation = userInformation;
            return this;
        }
        public String getUserInformation() {
            return this.userInformation;
        }

    }

    public static class GetOperationRecordsResponseBodyResultDomainList extends TeaModel {
        /**
         * <strong>example:</strong>
         * <p>return</p>
         */
        @NameInMap("action")
        public String action;

        /**
         * <strong>example:</strong>
         * <p>2021-02-01</p>
         */
        @NameInMap("activeTimeGMT")
        public String activeTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>act-xxaanfaf</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <strong>example:</strong>
         * <p><a href="https://oss.com/Signature.pdf">https://oss.com/Signature.pdf</a></p>
         */
        @NameInMap("digitalSignature")
        public String digitalSignature;

        /**
         * <strong>example:</strong>
         * <p><a href="https://oss.com/a.pdf">https://oss.com/a.pdf</a></p>
         */
        @NameInMap("files")
        public String files;

        /**
         * <strong>example:</strong>
         * <p>同意</p>
         */
        @NameInMap("formatAction")
        public String formatAction;

        /**
         * <strong>example:</strong>
         * <p>2021-01-01</p>
         */
        @NameInMap("operateTimeGMT")
        public String operateTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>remove</p>
         */
        @NameInMap("operateType")
        public String operateType;

        /**
         * <strong>example:</strong>
         * <p>manager123</p>
         */
        @NameInMap("operator")
        public String operator;

        /**
         * <strong>example:</strong>
         * <p>1732223326,1232321888,12188991</p>
         */
        @NameInMap("operatorAgentIdList")
        public java.util.List<GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList> operatorAgentIdList;

        /**
         * <strong>example:</strong>
         * <p>张三</p>
         */
        @NameInMap("operatorDisplayName")
        public String operatorDisplayName;

        /**
         * <strong>example:</strong>
         * <p>李四</p>
         */
        @NameInMap("operatorName")
        public String operatorName;

        /**
         * <strong>example:</strong>
         * <p>无冬</p>
         */
        @NameInMap("operatorNickName")
        public String operatorNickName;

        /**
         * <strong>example:</strong>
         * <p><a href="https://oss.com/a.jpeg">https://oss.com/a.jpeg</a></p>
         */
        @NameInMap("operatorPhotoUrl")
        public String operatorPhotoUrl;

        /**
         * <strong>example:</strong>
         * <p>良好</p>
         */
        @NameInMap("operatorStatus")
        public String operatorStatus;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("remark")
        public String remark;

        /**
         * <strong>example:</strong>
         * <p>请购类型</p>
         */
        @NameInMap("showName")
        public String showName;

        /**
         * <strong>example:</strong>
         * <p>12</p>
         */
        @NameInMap("size")
        public Integer size;

        /**
         * <strong>example:</strong>
         * <p>同步</p>
         */
        @NameInMap("taskExecuteType")
        public String taskExecuteType;

        /**
         * <strong>example:</strong>
         * <p>2021-01-01</p>
         */
        @NameInMap("taskHoldTimeGMT")
        public Long taskHoldTimeGMT;

        /**
         * <strong>example:</strong>
         * <p>task-123</p>
         */
        @NameInMap("taskId")
        public String taskId;

        /**
         * <strong>example:</strong>
         * <p>append task</p>
         */
        @NameInMap("taskType")
        public String taskType;

        /**
         * <strong>example:</strong>
         * <p>i18n</p>
         */
        @NameInMap("type")
        public String type;

        public static GetOperationRecordsResponseBodyResultDomainList build(java.util.Map<String, ?> map) throws Exception {
            GetOperationRecordsResponseBodyResultDomainList self = new GetOperationRecordsResponseBodyResultDomainList();
            return TeaModel.build(map, self);
        }

        public GetOperationRecordsResponseBodyResultDomainList setAction(String action) {
            this.action = action;
            return this;
        }
        public String getAction() {
            return this.action;
        }

        public GetOperationRecordsResponseBodyResultDomainList setActiveTimeGMT(String activeTimeGMT) {
            this.activeTimeGMT = activeTimeGMT;
            return this;
        }
        public String getActiveTimeGMT() {
            return this.activeTimeGMT;
        }

        public GetOperationRecordsResponseBodyResultDomainList setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetOperationRecordsResponseBodyResultDomainList setDigitalSignature(String digitalSignature) {
            this.digitalSignature = digitalSignature;
            return this;
        }
        public String getDigitalSignature() {
            return this.digitalSignature;
        }

        public GetOperationRecordsResponseBodyResultDomainList setFiles(String files) {
            this.files = files;
            return this;
        }
        public String getFiles() {
            return this.files;
        }

        public GetOperationRecordsResponseBodyResultDomainList setFormatAction(String formatAction) {
            this.formatAction = formatAction;
            return this;
        }
        public String getFormatAction() {
            return this.formatAction;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperateTimeGMT(String operateTimeGMT) {
            this.operateTimeGMT = operateTimeGMT;
            return this;
        }
        public String getOperateTimeGMT() {
            return this.operateTimeGMT;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperateType(String operateType) {
            this.operateType = operateType;
            return this;
        }
        public String getOperateType() {
            return this.operateType;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperator(String operator) {
            this.operator = operator;
            return this;
        }
        public String getOperator() {
            return this.operator;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorAgentIdList(java.util.List<GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList> operatorAgentIdList) {
            this.operatorAgentIdList = operatorAgentIdList;
            return this;
        }
        public java.util.List<GetOperationRecordsResponseBodyResultDomainListOperatorAgentIdList> getOperatorAgentIdList() {
            return this.operatorAgentIdList;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorDisplayName(String operatorDisplayName) {
            this.operatorDisplayName = operatorDisplayName;
            return this;
        }
        public String getOperatorDisplayName() {
            return this.operatorDisplayName;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorName(String operatorName) {
            this.operatorName = operatorName;
            return this;
        }
        public String getOperatorName() {
            return this.operatorName;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorNickName(String operatorNickName) {
            this.operatorNickName = operatorNickName;
            return this;
        }
        public String getOperatorNickName() {
            return this.operatorNickName;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorPhotoUrl(String operatorPhotoUrl) {
            this.operatorPhotoUrl = operatorPhotoUrl;
            return this;
        }
        public String getOperatorPhotoUrl() {
            return this.operatorPhotoUrl;
        }

        public GetOperationRecordsResponseBodyResultDomainList setOperatorStatus(String operatorStatus) {
            this.operatorStatus = operatorStatus;
            return this;
        }
        public String getOperatorStatus() {
            return this.operatorStatus;
        }

        public GetOperationRecordsResponseBodyResultDomainList setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetOperationRecordsResponseBodyResultDomainList setRemark(String remark) {
            this.remark = remark;
            return this;
        }
        public String getRemark() {
            return this.remark;
        }

        public GetOperationRecordsResponseBodyResultDomainList setShowName(String showName) {
            this.showName = showName;
            return this;
        }
        public String getShowName() {
            return this.showName;
        }

        public GetOperationRecordsResponseBodyResultDomainList setSize(Integer size) {
            this.size = size;
            return this;
        }
        public Integer getSize() {
            return this.size;
        }

        public GetOperationRecordsResponseBodyResultDomainList setTaskExecuteType(String taskExecuteType) {
            this.taskExecuteType = taskExecuteType;
            return this;
        }
        public String getTaskExecuteType() {
            return this.taskExecuteType;
        }

        public GetOperationRecordsResponseBodyResultDomainList setTaskHoldTimeGMT(Long taskHoldTimeGMT) {
            this.taskHoldTimeGMT = taskHoldTimeGMT;
            return this;
        }
        public Long getTaskHoldTimeGMT() {
            return this.taskHoldTimeGMT;
        }

        public GetOperationRecordsResponseBodyResultDomainList setTaskId(String taskId) {
            this.taskId = taskId;
            return this;
        }
        public String getTaskId() {
            return this.taskId;
        }

        public GetOperationRecordsResponseBodyResultDomainList setTaskType(String taskType) {
            this.taskType = taskType;
            return this;
        }
        public String getTaskType() {
            return this.taskType;
        }

        public GetOperationRecordsResponseBodyResultDomainList setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

    public static class GetOperationRecordsResponseBodyResult extends TeaModel {
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

        @NameInMap("domainList")
        public java.util.List<GetOperationRecordsResponseBodyResultDomainList> domainList;

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

        public GetOperationRecordsResponseBodyResult setDomainList(java.util.List<GetOperationRecordsResponseBodyResultDomainList> domainList) {
            this.domainList = domainList;
            return this;
        }
        public java.util.List<GetOperationRecordsResponseBodyResultDomainList> getDomainList() {
            return this.domainList;
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
