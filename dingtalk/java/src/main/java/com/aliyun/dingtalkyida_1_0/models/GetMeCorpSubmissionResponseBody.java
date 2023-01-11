// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetMeCorpSubmissionResponseBody extends TeaModel {
    /**
     * <p>data</p>
     */
    @NameInMap("data")
    public java.util.List<GetMeCorpSubmissionResponseBodyData> data;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Long pageNumber;

    /**
     * <p>总数量</p>
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
        /**
         * <p>buName</p>
         */
        @NameInMap("buName")
        public String buName;

        /**
         * <p>email</p>
         */
        @NameInMap("email")
        public String email;

        /**
         * <p>empType</p>
         */
        @NameInMap("employeeType")
        public String employeeType;

        /**
         * <p>employeeTypeInformation</p>
         */
        @NameInMap("employeeTypeInformation")
        public String employeeTypeInformation;

        /**
         * <p>hrgWorkNo</p>
         */
        @NameInMap("humanResourceGroupWorkNumber")
        public String humanResourceGroupWorkNumber;

        /**
         * <p>isSystemAdmin</p>
         */
        @NameInMap("isSystemAdmin")
        public Boolean isSystemAdmin;

        /**
         * <p>level</p>
         */
        @NameInMap("level")
        public String level;

        /**
         * <p>name</p>
         */
        @NameInMap("name")
        public String name;

        /**
         * <p>nickName</p>
         */
        @NameInMap("nickName")
        public String nickName;

        /**
         * <p>orderNum</p>
         */
        @NameInMap("orderNumber")
        public String orderNumber;

        /**
         * <p>personalPhoto</p>
         */
        @NameInMap("personalPhoto")
        public String personalPhoto;

        /**
         * <p>personalPhotoUrl</p>
         */
        @NameInMap("personalPhotoUrl")
        public String personalPhotoUrl;

        /**
         * <p>pinyinNameAll</p>
         */
        @NameInMap("pinyinNameAll")
        public String pinyinNameAll;

        /**
         * <p>pinyinNick</p>
         */
        @NameInMap("pinyinNickName")
        public String pinyinNickName;

        /**
         * <p>state</p>
         */
        @NameInMap("state")
        public String state;

        /**
         * <p>superUserId</p>
         */
        @NameInMap("superUserId")
        public String superUserId;

        /**
         * <p>tbWang</p>
         */
        @NameInMap("tbWang")
        public String tbWang;

        /**
         * <p>userId</p>
         */
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
        /**
         * <p>activityId</p>
         */
        @NameInMap("activityId")
        public String activityId;

        /**
         * <p>activityInstanceStatus</p>
         */
        @NameInMap("activityInstanceStatus")
        public String activityInstanceStatus;

        /**
         * <p>activityName</p>
         */
        @NameInMap("activityName")
        public String activityName;

        /**
         * <p>activityNameEn</p>
         */
        @NameInMap("activityNameEn")
        public String activityNameEn;

        /**
         * <p>id</p>
         */
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
        /**
         * <p>actioner</p>
         */
        @NameInMap("actioner")
        public java.util.List<GetMeCorpSubmissionResponseBodyDataActioner> actioner;

        /**
         * <p>actionerId</p>
         */
        @NameInMap("actionerId")
        public java.util.List<String> actionerId;

        /**
         * <p>actionerName</p>
         */
        @NameInMap("actionerName")
        public java.util.List<String> actionerName;

        /**
         * <p>appType</p>
         */
        @NameInMap("appType")
        public String appType;

        /**
         * <p>createTime</p>
         */
        @NameInMap("createTimeGMT")
        public String createTimeGMT;

        /**
         * <p>currentActivityInstances</p>
         */
        @NameInMap("currentActivityInstances")
        public java.util.List<GetMeCorpSubmissionResponseBodyDataCurrentActivityInstances> currentActivityInstances;

        /**
         * <p>dataMap</p>
         */
        @NameInMap("dataMap")
        public java.util.Map<String, ?> dataMap;

        /**
         * <p>dataType</p>
         */
        @NameInMap("dataType")
        public String dataType;

        /**
         * <p>finishTime</p>
         */
        @NameInMap("finishTimeGMT")
        public String finishTimeGMT;

        /**
         * <p>formInstanceId</p>
         */
        @NameInMap("formInstanceId")
        public String formInstanceId;

        /**
         * <p>formUuid</p>
         */
        @NameInMap("formUuid")
        public String formUuid;

        /**
         * <p>instValue</p>
         */
        @NameInMap("instanceValue")
        public String instanceValue;

        /**
         * <p>modifiedTime</p>
         */
        @NameInMap("modifiedTimeGMT")
        public String modifiedTimeGMT;

        /**
         * <p>originatorAvatar</p>
         */
        @NameInMap("originatorAvatar")
        public String originatorAvatar;

        /**
         * <p>originatorDisplayName</p>
         */
        @NameInMap("originatorDisplayName")
        public String originatorDisplayName;

        /**
         * <p>originatorId</p>
         */
        @NameInMap("originatorId")
        public String originatorId;

        /**
         * <p>processApprovedResult</p>
         */
        @NameInMap("processApprovedResult")
        public String processApprovedResult;

        /**
         * <p>processApprovedResultText</p>
         */
        @NameInMap("processApprovedResultText")
        public String processApprovedResultText;

        /**
         * <p>processCode</p>
         */
        @NameInMap("processCode")
        public String processCode;

        /**
         * <p>processId</p>
         */
        @NameInMap("processId")
        public Long processId;

        /**
         * <p>processInstanceId</p>
         */
        @NameInMap("processInstanceId")
        public String processInstanceId;

        /**
         * <p>processInstanceStatus</p>
         */
        @NameInMap("processInstanceStatus")
        public String processInstanceStatus;

        /**
         * <p>processInstanceStatusText</p>
         */
        @NameInMap("processInstanceStatusText")
        public String processInstanceStatusText;

        /**
         * <p>processName</p>
         */
        @NameInMap("processName")
        public String processName;

        /**
         * <p>title</p>
         */
        @NameInMap("title")
        public String title;

        /**
         * <p>version</p>
         */
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
