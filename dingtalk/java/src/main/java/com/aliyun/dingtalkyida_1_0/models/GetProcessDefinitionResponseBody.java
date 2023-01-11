// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetProcessDefinitionResponseBody extends TeaModel {
    /**
     * <p>formUuid</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>originator</p>
     */
    @NameInMap("originator")
    public GetProcessDefinitionResponseBodyOriginator originator;

    /**
     * <p>outResult</p>
     */
    @NameInMap("outResult")
    public String outResult;

    /**
     * <p>owners</p>
     */
    @NameInMap("owners")
    public java.util.List<GetProcessDefinitionResponseBodyOwners> owners;

    /**
     * <p>processId</p>
     */
    @NameInMap("processId")
    public String processId;

    /**
     * <p>processInstanceId</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    /**
     * <p>status</p>
     */
    @NameInMap("status")
    public String status;

    /**
     * <p>tasks</p>
     */
    @NameInMap("tasks")
    public java.util.List<GetProcessDefinitionResponseBodyTasks> tasks;

    /**
     * <p>title</p>
     */
    @NameInMap("title")
    public String title;

    /**
     * <p>variables</p>
     */
    @NameInMap("variables")
    public java.util.Map<String, ?> variables;

    public static GetProcessDefinitionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProcessDefinitionResponseBody self = new GetProcessDefinitionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProcessDefinitionResponseBody setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public GetProcessDefinitionResponseBody setOriginator(GetProcessDefinitionResponseBodyOriginator originator) {
        this.originator = originator;
        return this;
    }
    public GetProcessDefinitionResponseBodyOriginator getOriginator() {
        return this.originator;
    }

    public GetProcessDefinitionResponseBody setOutResult(String outResult) {
        this.outResult = outResult;
        return this;
    }
    public String getOutResult() {
        return this.outResult;
    }

    public GetProcessDefinitionResponseBody setOwners(java.util.List<GetProcessDefinitionResponseBodyOwners> owners) {
        this.owners = owners;
        return this;
    }
    public java.util.List<GetProcessDefinitionResponseBodyOwners> getOwners() {
        return this.owners;
    }

    public GetProcessDefinitionResponseBody setProcessId(String processId) {
        this.processId = processId;
        return this;
    }
    public String getProcessId() {
        return this.processId;
    }

    public GetProcessDefinitionResponseBody setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

    public GetProcessDefinitionResponseBody setStatus(String status) {
        this.status = status;
        return this;
    }
    public String getStatus() {
        return this.status;
    }

    public GetProcessDefinitionResponseBody setTasks(java.util.List<GetProcessDefinitionResponseBodyTasks> tasks) {
        this.tasks = tasks;
        return this;
    }
    public java.util.List<GetProcessDefinitionResponseBodyTasks> getTasks() {
        return this.tasks;
    }

    public GetProcessDefinitionResponseBody setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

    public GetProcessDefinitionResponseBody setVariables(java.util.Map<String, ?> variables) {
        this.variables = variables;
        return this;
    }
    public java.util.Map<String, ?> getVariables() {
        return this.variables;
    }

    public static class GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments extends TeaModel {
        /**
         * <p>deptName</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>deptNameEn</p>
         */
        @NameInMap("deptNameInEnglish")
        public String deptNameInEnglish;

        /**
         * <p>deptNo</p>
         */
        @NameInMap("deptNo")
        public String deptNo;

        /**
         * <p>deptPath</p>
         */
        @NameInMap("deptPath")
        public String deptPath;

        /**
         * <p>humanSourceGroupOrderNum</p>
         */
        @NameInMap("humanSourceGroupOrderNumber")
        public String humanSourceGroupOrderNumber;

        /**
         * <p>humanSourceGroupWorkNo</p>
         */
        @NameInMap("humanSourceGroupWorkNo")
        public String humanSourceGroupWorkNo;

        /**
         * <p>id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>masterWorkNo</p>
         */
        @NameInMap("masterWorkNo")
        public String masterWorkNo;

        public static GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments self = new GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setDeptNameInEnglish(String deptNameInEnglish) {
            this.deptNameInEnglish = deptNameInEnglish;
            return this;
        }
        public String getDeptNameInEnglish() {
            return this.deptNameInEnglish;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setDeptPath(String deptPath) {
            this.deptPath = deptPath;
            return this;
        }
        public String getDeptPath() {
            return this.deptPath;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setHumanSourceGroupOrderNumber(String humanSourceGroupOrderNumber) {
            this.humanSourceGroupOrderNumber = humanSourceGroupOrderNumber;
            return this;
        }
        public String getHumanSourceGroupOrderNumber() {
            return this.humanSourceGroupOrderNumber;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setHumanSourceGroupWorkNo(String humanSourceGroupWorkNo) {
            this.humanSourceGroupWorkNo = humanSourceGroupWorkNo;
            return this;
        }
        public String getHumanSourceGroupWorkNo() {
            return this.humanSourceGroupWorkNo;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments setMasterWorkNo(String masterWorkNo) {
            this.masterWorkNo = masterWorkNo;
            return this;
        }
        public String getMasterWorkNo() {
            return this.masterWorkNo;
        }

    }

    public static class GetProcessDefinitionResponseBodyOriginator extends TeaModel {
        /**
         * <p>departmentDescription</p>
         */
        @NameInMap("departmentDescription")
        public String departmentDescription;

        /**
         * <p>displayEnName</p>
         */
        @NameInMap("displayEnName")
        public String displayEnName;

        /**
         * <p>displayName</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>masterDataDepartments</p>
         */
        @NameInMap("masterDataDepartments")
        public java.util.List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> masterDataDepartments;

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
         * <p>status</p>
         */
        @NameInMap("status")
        public String status;

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

        /**
         * <p>userInfo</p>
         */
        @NameInMap("userInfo")
        public String userInfo;

        public static GetProcessDefinitionResponseBodyOriginator build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyOriginator self = new GetProcessDefinitionResponseBodyOriginator();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyOriginator setDepartmentDescription(String departmentDescription) {
            this.departmentDescription = departmentDescription;
            return this;
        }
        public String getDepartmentDescription() {
            return this.departmentDescription;
        }

        public GetProcessDefinitionResponseBodyOriginator setDisplayEnName(String displayEnName) {
            this.displayEnName = displayEnName;
            return this;
        }
        public String getDisplayEnName() {
            return this.displayEnName;
        }

        public GetProcessDefinitionResponseBodyOriginator setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetProcessDefinitionResponseBodyOriginator setMasterDataDepartments(java.util.List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> masterDataDepartments) {
            this.masterDataDepartments = masterDataDepartments;
            return this;
        }
        public java.util.List<GetProcessDefinitionResponseBodyOriginatorMasterDataDepartments> getMasterDataDepartments() {
            return this.masterDataDepartments;
        }

        public GetProcessDefinitionResponseBodyOriginator setOrderNumber(String orderNumber) {
            this.orderNumber = orderNumber;
            return this;
        }
        public String getOrderNumber() {
            return this.orderNumber;
        }

        public GetProcessDefinitionResponseBodyOriginator setPersonalPhoto(String personalPhoto) {
            this.personalPhoto = personalPhoto;
            return this;
        }
        public String getPersonalPhoto() {
            return this.personalPhoto;
        }

        public GetProcessDefinitionResponseBodyOriginator setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessDefinitionResponseBodyOriginator setTbWang(String tbWang) {
            this.tbWang = tbWang;
            return this;
        }
        public String getTbWang() {
            return this.tbWang;
        }

        public GetProcessDefinitionResponseBodyOriginator setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetProcessDefinitionResponseBodyOriginator setUserInfo(String userInfo) {
            this.userInfo = userInfo;
            return this;
        }
        public String getUserInfo() {
            return this.userInfo;
        }

    }

    public static class GetProcessDefinitionResponseBodyOwnersMasterDataDepartments extends TeaModel {
        /**
         * <p>deptName</p>
         */
        @NameInMap("deptName")
        public String deptName;

        /**
         * <p>deptNameEn</p>
         */
        @NameInMap("deptNameInEnglish")
        public String deptNameInEnglish;

        /**
         * <p>deptNo</p>
         */
        @NameInMap("deptNo")
        public String deptNo;

        /**
         * <p>deptPath</p>
         */
        @NameInMap("deptPath")
        public String deptPath;

        /**
         * <p>humanSourceGroupOrderNum</p>
         */
        @NameInMap("humanSourceGroupOrderNumber")
        public String humanSourceGroupOrderNumber;

        /**
         * <p>humanSourceGroupWorkNo</p>
         */
        @NameInMap("humanSourceGroupWorkNo")
        public String humanSourceGroupWorkNo;

        /**
         * <p>id</p>
         */
        @NameInMap("id")
        public Long id;

        /**
         * <p>masterWorkNo</p>
         */
        @NameInMap("masterWorkNo")
        public String masterWorkNo;

        public static GetProcessDefinitionResponseBodyOwnersMasterDataDepartments build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyOwnersMasterDataDepartments self = new GetProcessDefinitionResponseBodyOwnersMasterDataDepartments();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setDeptName(String deptName) {
            this.deptName = deptName;
            return this;
        }
        public String getDeptName() {
            return this.deptName;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setDeptNameInEnglish(String deptNameInEnglish) {
            this.deptNameInEnglish = deptNameInEnglish;
            return this;
        }
        public String getDeptNameInEnglish() {
            return this.deptNameInEnglish;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setDeptNo(String deptNo) {
            this.deptNo = deptNo;
            return this;
        }
        public String getDeptNo() {
            return this.deptNo;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setDeptPath(String deptPath) {
            this.deptPath = deptPath;
            return this;
        }
        public String getDeptPath() {
            return this.deptPath;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setHumanSourceGroupOrderNumber(String humanSourceGroupOrderNumber) {
            this.humanSourceGroupOrderNumber = humanSourceGroupOrderNumber;
            return this;
        }
        public String getHumanSourceGroupOrderNumber() {
            return this.humanSourceGroupOrderNumber;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setHumanSourceGroupWorkNo(String humanSourceGroupWorkNo) {
            this.humanSourceGroupWorkNo = humanSourceGroupWorkNo;
            return this;
        }
        public String getHumanSourceGroupWorkNo() {
            return this.humanSourceGroupWorkNo;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

        public GetProcessDefinitionResponseBodyOwnersMasterDataDepartments setMasterWorkNo(String masterWorkNo) {
            this.masterWorkNo = masterWorkNo;
            return this;
        }
        public String getMasterWorkNo() {
            return this.masterWorkNo;
        }

    }

    public static class GetProcessDefinitionResponseBodyOwners extends TeaModel {
        /**
         * <p>departmentDescription</p>
         */
        @NameInMap("departmentDescription")
        public String departmentDescription;

        /**
         * <p>displayEnName</p>
         */
        @NameInMap("displayEnName")
        public String displayEnName;

        /**
         * <p>displayName</p>
         */
        @NameInMap("displayName")
        public String displayName;

        /**
         * <p>masterDataDepartments</p>
         */
        @NameInMap("masterDataDepartments")
        public java.util.List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> masterDataDepartments;

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
         * <p>status</p>
         */
        @NameInMap("status")
        public String status;

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

        /**
         * <p>userInfo</p>
         */
        @NameInMap("userInfo")
        public String userInfo;

        public static GetProcessDefinitionResponseBodyOwners build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyOwners self = new GetProcessDefinitionResponseBodyOwners();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyOwners setDepartmentDescription(String departmentDescription) {
            this.departmentDescription = departmentDescription;
            return this;
        }
        public String getDepartmentDescription() {
            return this.departmentDescription;
        }

        public GetProcessDefinitionResponseBodyOwners setDisplayEnName(String displayEnName) {
            this.displayEnName = displayEnName;
            return this;
        }
        public String getDisplayEnName() {
            return this.displayEnName;
        }

        public GetProcessDefinitionResponseBodyOwners setDisplayName(String displayName) {
            this.displayName = displayName;
            return this;
        }
        public String getDisplayName() {
            return this.displayName;
        }

        public GetProcessDefinitionResponseBodyOwners setMasterDataDepartments(java.util.List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> masterDataDepartments) {
            this.masterDataDepartments = masterDataDepartments;
            return this;
        }
        public java.util.List<GetProcessDefinitionResponseBodyOwnersMasterDataDepartments> getMasterDataDepartments() {
            return this.masterDataDepartments;
        }

        public GetProcessDefinitionResponseBodyOwners setOrderNumber(String orderNumber) {
            this.orderNumber = orderNumber;
            return this;
        }
        public String getOrderNumber() {
            return this.orderNumber;
        }

        public GetProcessDefinitionResponseBodyOwners setPersonalPhoto(String personalPhoto) {
            this.personalPhoto = personalPhoto;
            return this;
        }
        public String getPersonalPhoto() {
            return this.personalPhoto;
        }

        public GetProcessDefinitionResponseBodyOwners setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessDefinitionResponseBodyOwners setTbWang(String tbWang) {
            this.tbWang = tbWang;
            return this;
        }
        public String getTbWang() {
            return this.tbWang;
        }

        public GetProcessDefinitionResponseBodyOwners setUserId(String userId) {
            this.userId = userId;
            return this;
        }
        public String getUserId() {
            return this.userId;
        }

        public GetProcessDefinitionResponseBodyOwners setUserInfo(String userInfo) {
            this.userInfo = userInfo;
            return this;
        }
        public String getUserInfo() {
            return this.userInfo;
        }

    }

    public static class GetProcessDefinitionResponseBodyTasksActivity extends TeaModel {
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
        @NameInMap("activityNameInEnglish")
        public String activityNameInEnglish;

        /**
         * <p>id</p>
         */
        @NameInMap("id")
        public Long id;

        public static GetProcessDefinitionResponseBodyTasksActivity build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyTasksActivity self = new GetProcessDefinitionResponseBodyTasksActivity();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyTasksActivity setActivityId(String activityId) {
            this.activityId = activityId;
            return this;
        }
        public String getActivityId() {
            return this.activityId;
        }

        public GetProcessDefinitionResponseBodyTasksActivity setActivityInstanceStatus(String activityInstanceStatus) {
            this.activityInstanceStatus = activityInstanceStatus;
            return this;
        }
        public String getActivityInstanceStatus() {
            return this.activityInstanceStatus;
        }

        public GetProcessDefinitionResponseBodyTasksActivity setActivityName(String activityName) {
            this.activityName = activityName;
            return this;
        }
        public String getActivityName() {
            return this.activityName;
        }

        public GetProcessDefinitionResponseBodyTasksActivity setActivityNameInEnglish(String activityNameInEnglish) {
            this.activityNameInEnglish = activityNameInEnglish;
            return this;
        }
        public String getActivityNameInEnglish() {
            return this.activityNameInEnglish;
        }

        public GetProcessDefinitionResponseBodyTasksActivity setId(Long id) {
            this.id = id;
            return this;
        }
        public Long getId() {
            return this.id;
        }

    }

    public static class GetProcessDefinitionResponseBodyTasks extends TeaModel {
        /**
         * <p>actioner</p>
         */
        @NameInMap("actionerId")
        public String actionerId;

        /**
         * <p>activity</p>
         */
        @NameInMap("activity")
        public GetProcessDefinitionResponseBodyTasksActivity activity;

        /**
         * <p>status</p>
         */
        @NameInMap("status")
        public String status;

        /**
         * <p>taskId</p>
         */
        @NameInMap("taskId")
        public Long taskId;

        public static GetProcessDefinitionResponseBodyTasks build(java.util.Map<String, ?> map) throws Exception {
            GetProcessDefinitionResponseBodyTasks self = new GetProcessDefinitionResponseBodyTasks();
            return TeaModel.build(map, self);
        }

        public GetProcessDefinitionResponseBodyTasks setActionerId(String actionerId) {
            this.actionerId = actionerId;
            return this;
        }
        public String getActionerId() {
            return this.actionerId;
        }

        public GetProcessDefinitionResponseBodyTasks setActivity(GetProcessDefinitionResponseBodyTasksActivity activity) {
            this.activity = activity;
            return this;
        }
        public GetProcessDefinitionResponseBodyTasksActivity getActivity() {
            return this.activity;
        }

        public GetProcessDefinitionResponseBodyTasks setStatus(String status) {
            this.status = status;
            return this;
        }
        public String getStatus() {
            return this.status;
        }

        public GetProcessDefinitionResponseBodyTasks setTaskId(Long taskId) {
            this.taskId = taskId;
            return this;
        }
        public Long getTaskId() {
            return this.taskId;
        }

    }

}
