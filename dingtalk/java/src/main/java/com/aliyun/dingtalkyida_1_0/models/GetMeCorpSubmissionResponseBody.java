// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetMeCorpSubmissionResponseBody extends TeaModel {
    @NameInMap("data")
    public java.util.List<GetMeCorpSubmissionResponseBodyData> data;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("totalCount")
    public Long totalCount;

    public static GetMeCorpSubmissionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetMeCorpSubmissionResponseBody self = new GetMeCorpSubmissionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetMeCorpSubmissionResponseBody setData(java.util.List<GetMeCorpSubmissionResponseBodyData> data) {
        this.data = data;
        return this;
    }
    public java.util.List<GetMeCorpSubmissionResponseBodyData> getData() {
        return this.data;
    }

    public GetMeCorpSubmissionResponseBody setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetMeCorpSubmissionResponseBody setTotalCount(Long totalCount) {
        this.totalCount = totalCount;
        return this;
    }
    public Long getTotalCount() {
        return this.totalCount;
    }

    public static class GetMeCorpSubmissionResponseBodyDataActioner extends TeaModel {
        @NameInMap("buName")
        public String buName;

        @NameInMap("email")
        public String email;

        @NameInMap("employeeType")
        public String employeeType;

        @NameInMap("employeeTypeInformation")
        public String employeeTypeInformation;

        @NameInMap("humanResourceGroupWorkNumber")
        public String humanResourceGroupWorkNumber;

        @NameInMap("isSystemAdmin")
        public Boolean isSystemAdmin;

        @NameInMap("level")
        public String level;

        @NameInMap("name")
        public String name;

        @NameInMap("nickName")
        public String nickName;

        @NameInMap("orderNumber")
        public String orderNumber;

        @NameInMap("personalPhoto")
        public String personalPhoto;

        @NameInMap("personalPhotoUrl")
        public String personalPhotoUrl;

        @NameInMap("pinyinNameAll")
        public String pinyinNameAll;

        @NameInMap("pinyinNickName")
        public String pinyinNickName;

        @NameInMap("state")
        public String state;

        @NameInMap("superUserId")
        public String superUserId;

        @NameInMap("tbWang")
        public String tbWang;

        @NameInMap("userId")
        public String userId;

        public static GetMeCorpSubmissionResponseBodyDataActioner build(java.util.Map<String, ?> map) throws Exception {
            GetMeCorpSubmissionResponseBodyDataActioner self = new GetMeCorpSubmissionResponseBodyDataActioner();
            return TeaModel.build(map, self);
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setBuName(String buName) {
            this.buName = buName;
            return this;
        }
        public String getBuName() {
            return this.buName;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setEmail(String email) {
            this.email = email;
            return this;
        }
        public String getEmail() {
            return this.email;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setEmployeeType(String employeeType) {
            this.employeeType = employeeType;
            return this;
        }
        public String getEmployeeType() {
            return this.employeeType;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setEmployeeTypeInformation(String employeeTypeInformation) {
            this.employeeTypeInformation = employeeTypeInformation;
            return this;
        }
        public String getEmployeeTypeInformation() {
            return this.employeeTypeInformation;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setHumanResourceGroupWorkNumber(String humanResourceGroupWorkNumber) {
            this.humanResourceGroupWorkNumber = humanResourceGroupWorkNumber;
            return this;
        }
        public String getHumanResourceGroupWorkNumber() {
            return this.humanResourceGroupWorkNumber;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setIsSystemAdmin(Boolean isSystemAdmin) {
            this.isSystemAdmin = isSystemAdmin;
            return this;
        }
        public Boolean getIsSystemAdmin() {
            return this.isSystemAdmin;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setLevel(String level) {
            this.level = level;
            return this;
        }
        public String getLevel() {
            return this.level;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setNickName(String nickName) {
            this.nickName = nickName;
            return this;
        }
        public String getNickName() {
            return this.nickName;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setOrderNumber(String orderNumber) {
            this.orderNumber = orderNumber;
            return this;
        }
        public String getOrderNumber() {
            return this.orderNumber;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setPersonalPhoto(String personalPhoto) {
            this.personalPhoto = personalPhoto;
            return this;
        }
        public String getPersonalPhoto() {
            return this.personalPhoto;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setPersonalPhotoUrl(String personalPhotoUrl) {
            this.personalPhotoUrl = personalPhotoUrl;
            return this;
        }
        public String getPersonalPhotoUrl() {
            return this.personalPhotoUrl;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setPinyinNameAll(String pinyinNameAll) {
            this.pinyinNameAll = pinyinNameAll;
            return this;
        }
        public String getPinyinNameAll() {
            return this.pinyinNameAll;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setPinyinNickName(String pinyinNickName) {
            this.pinyinNickName = pinyinNickName;
            return this;
        }
        public String getPinyinNickName() {
            return this.pinyinNickName;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setState(String state) {
            this.state = state;
            return this;
        }
        public String getState() {
            return this.state;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setSuperUserId(String superUserId) {
            this.superUserId = superUserId;
            return this;
        }
        public String getSuperUserId() {
            return this.superUserId;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setTbWang(String tbWang) {
            this.tbWang = tbWang;
            return this;
        }
        public String getTbWang() {
            return this.tbWang;
        }

        public GetMeCorpSubmissionResponseBodyDataActioner setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

    }

    public static class GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances extends TeaModel {
        @NameInMap("activityId")
        public String activityId;

        @NameInMap("activityInstanceStatus")
        public String activityInstanceStatus;

        @NameInMap("activityName")
        public String activityName;

        @NameInMap("activityNameEn")
        public String activityNameEn;

        @NameInMap("id")
        public Long id;

        public static GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances build(java.util.Map<String, ?> map) throws Exception {
            GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances self = new GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances();
            return TeaModel.build(map, self);
        }

        public GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances setActivityInstanceStatus(String activityInstanceStatus) {
            this.activityInstanceStatus = activityInstanceStatus;
            return this;
        }
        public String getActivityInstanceStatus() {
            return this.activityInstanceStatus;
        }

        public GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances setActivityNameEn(String activityNameEn) {
            this.activityNameEn = activityNameEn;
            return this;
        }
        public String getActivityNameEn() {
            return this.activityNameEn;
        }

        public GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

    public static class GetMeCorpSubmissionResponseBodyData extends TeaModel {
        @NameInMap("actioner")
        public java.util.List<GetMeCorpSubmissionResponseBodyDataActioner> actioner;

        @NameInMap("actionerId")
        public java.util.List<String> actionerId;

        @NameInMap("actionerName")
        public java.util.List<String> actionerName;

        @NameInMap("appType")
        public String appType;

        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        @NameInMap("currentActivityInstances")
        public java.util.List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> currentActivityInstances;

        @NameInMap("dataMap")
        public java.util.Map<String, ?> dataMap;

        @NameInMap("dataType")
        public String dataType;

        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        @NameInMap("formInstanceId")
        public String formInstanceId;

        @NameInMap("formUuid")
        public String formUuid;

        @NameInMap("instanceValue")
        public String instanceValue;

        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        @NameInMap("originatorAvatar")
        public String originatorAvatar;

        @NameInMap("originatorDisplayName")
        public String originatorDisplayName;

        @NameInMap("originatorId")
        public String originatorId;

        @NameInMap("processApprovedResult")
        public String processApprovedResult;

        @NameInMap("processApprovedResultText")
        public String processApprovedResultText;

        @NameInMap("processCode")
        public String processCode;

        @NameInMap("processId")
        public Long processId;

        @NameInMap("processInstanceId")
        public String processInstanceId;

        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        @NameInMap("processInstanceStatusText")
        public String processInstanceStatusText;

        @NameInMap("processName")
        public String processName;

        @NameInMap("title")
        public String title;

        @NameInMap("version")
        public Long version;

        public static GetMeCorpSubmissionResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetMeCorpSubmissionResponseBodyData self = new GetMeCorpSubmissionResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetMeCorpSubmissionResponseBodyData setActioner(java.util.List<GetMeCorpSubmissionResponseBodyDataActioner> actioner) {
            this.actioner = actioner;
            return this;
        }
        public java.util.List<GetMeCorpSubmissionResponseBodyDataActioner> getActioner() {
            return this.actioner;
        }

        public GetMeCorpSubmissionResponseBodyData setActionerId(java.util.List<String> actionerId) {
            this.actionerId = actionerId;
            return this;
        }
        public java.util.List<String> getActionerId() {
            return this.actionerId;
        }

        public GetMeCorpSubmissionResponseBodyData setActionerName(java.util.List<String> actionerName) {
            this.actionerName = actionerName;
            return this;
        }
        public java.util.List<String> getActionerName() {
            return this.actionerName;
        }

        public GetMeCorpSubmissionResponseBodyData setAppType(String appType) {
            this.appType = appType;
            return this;
        }
        public String getAppType() {
            return this.appType;
        }

        public GetMeCorpSubmissionResponseBodyData setCreateTimeGMT(String createTimeGMT) {
            this.createTimeGMT = createTimeGMT;
            return this;
        }
        public String getCreateTimeGMT() {
            return this.createTimeGMT;
        }

        public GetMeCorpSubmissionResponseBodyData setCurrentActivityInstances(java.util.List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> currentActivityInstances) {
            this.currentActivityInstances = currentActivityInstances;
            return this;
        }
        public java.util.List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> getCurrentActivityInstances() {
            return this.currentActivityInstances;
        }

        public GetMeCorpSubmissionResponseBodyData setDataMap(java.util.Map<String, ?> dataMap) {
            this.dataMap = dataMap;
            return this;
        }
        public java.util.Map<String, ?> getDataMap() {
            return this.dataMap;
        }

        public GetMeCorpSubmissionResponseBodyData setDataType(String dataType) {
            this.dataType = dataType;
            return this;
        }
        public String getDataType() {
            return this.dataType;
        }

        public GetMeCorpSubmissionResponseBodyData setFinishTimeGMT(String finishTimeGMT) {
            this.finishTimeGMT = finishTimeGMT;
            return this;
        }
        public String getFinishTimeGMT() {
            return this.finishTimeGMT;
        }

        public GetMeCorpSubmissionResponseBodyData setFormInstanceId(String formInstanceId) {
            this.formInstanceId = formInstanceId;
            return this;
        }
        public String getFormInstanceId() {
            return this.formInstanceId;
        }

        public GetMeCorpSubmissionResponseBodyData setFormUuid(String formUuid) {
            this.formUuid = formUuid;
            return this;
        }
        public String getFormUuid() {
            return this.formUuid;
        }

        public GetMeCorpSubmissionResponseBodyData setInstanceValue(String instanceValue) {
            this.instanceValue = instanceValue;
            return this;
        }
        public String getInstanceValue() {
            return this.instanceValue;
        }

        public GetMeCorpSubmissionResponseBodyData setModifiedTimeGMT(String modifiedTimeGMT) {
            this.modifiedTimeGMT = modifiedTimeGMT;
            return this;
        }
        public String getModifiedTimeGMT() {
            return this.modifiedTimeGMT;
        }

        public GetMeCorpSubmissionResponseBodyData setOriginatorAvatar(String originatorAvatar) {
            this.originatorAvatar = originatorAvatar;
            return this;
        }
        public String getOriginatorAvatar() {
            return this.originatorAvatar;
        }

        public GetMeCorpSubmissionResponseBodyData setOriginatorDisplayName(String originatorDisplayName) {
            this.originatorDisplayName = originatorDisplayName;
            return this;
        }
        public String getOriginatorDisplayName() {
            return this.originatorDisplayName;
        }

        public GetMeCorpSubmissionResponseBodyData setOriginatorId(String originatorId) {
            this.originatorId = originatorId;
            return this;
        }
        public String getOriginatorId() {
            return this.originatorId;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessApprovedResult(String processApprovedResult) {
            this.processApprovedResult = processApprovedResult;
            return this;
        }
        public String getProcessApprovedResult() {
            return this.processApprovedResult;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessApprovedResultText(String processApprovedResultText) {
            this.processApprovedResultText = processApprovedResultText;
            return this;
        }
        public String getProcessApprovedResultText() {
            return this.processApprovedResultText;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessCode(String processCode) {
            this.processCode = processCode;
            return this;
        }
        public String getProcessCode() {
            return this.processCode;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessId(Long processId) {
            this.processId = processId;
            return this;
        }
        public Long getProcessId() {
            return this.processId;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessInstanceId(String processInstanceId) {
            this.processInstanceId = processInstanceId;
            return this;
        }
        public String getProcessInstanceId() {
            return this.processInstanceId;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessInstanceStatus(String processInstanceStatus) {
            this.processInstanceStatus = processInstanceStatus;
            return this;
        }
        public String getProcessInstanceStatus() {
            return this.processInstanceStatus;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessInstanceStatusText(String processInstanceStatusText) {
            this.processInstanceStatusText = processInstanceStatusText;
            return this;
        }
        public String getProcessInstanceStatusText() {
            return this.processInstanceStatusText;
        }

        public GetMeCorpSubmissionResponseBodyData setProcessName(String processName) {
            this.processName = processName;
            return this;
        }
        public String getProcessName() {
            return this.processName;
        }

        public GetMeCorpSubmissionResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetMeCorpSubmissionResponseBodyData setVersion(Long version) {
            this.version = version;
            return this;
        }
        public Long getVersion() {
            return this.version;
        }

    }

}
