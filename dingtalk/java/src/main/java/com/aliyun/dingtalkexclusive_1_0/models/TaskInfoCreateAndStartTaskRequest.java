// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoCreateAndStartTaskRequest extends TeaModel {
    @NameInMap("attr")
    public TaskInfoCreateAndStartTaskRequestAttr attr;

    @NameInMap("backlogDTO")
    public TaskInfoCreateAndStartTaskRequestBacklogDTO backlogDTO;

    @NameInMap("backlogGenerateFlag")
    public Integer backlogGenerateFlag;

    @NameInMap("businessCode")
    public String businessCode;

    @NameInMap("canceldelTaskCardId")
    public String canceldelTaskCardId;

    @NameInMap("cardDTO")
    public TaskInfoCreateAndStartTaskRequestCardDTO cardDTO;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("customFlag")
    public Integer customFlag;

    @NameInMap("detailUrl")
    public TaskInfoCreateAndStartTaskRequestDetailUrl detailUrl;

    @NameInMap("finishTaskCardId")
    public String finishTaskCardId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorAccount")
    public String operatorAccount;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outTaskId")
    public String outTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("projId")
    public String projId;

    @NameInMap("robotCode")
    public String robotCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("secretKey")
    public String secretKey;

    @NameInMap("sendMsgFlag")
    public Integer sendMsgFlag;

    @NameInMap("sort")
    public Integer sort;

    @NameInMap("startTaskCardId")
    public String startTaskCardId;

    @NameInMap("state")
    public Integer state;

    @NameInMap("taskContent")
    public String taskContent;

    @NameInMap("taskEndTime")
    public Long taskEndTime;

    @NameInMap("taskExecutePersonDTOS")
    public java.util.List<TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS;

    @NameInMap("taskGroupDTOList")
    public java.util.List<TaskInfoCreateAndStartTaskRequestTaskGroupDTOList> taskGroupDTOList;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskSystem")
    public String taskSystem;

    @NameInMap("taskTemplCode")
    public String taskTemplCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskTitle")
    public String taskTitle;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskType")
    public String taskType;

    @NameInMap("taskUrlMobile")
    public String taskUrlMobile;

    @NameInMap("taskUrlPc")
    public String taskUrlPc;

    @NameInMap("updateTaskCardId")
    public String updateTaskCardId;

    public static TaskInfoCreateAndStartTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoCreateAndStartTaskRequest self = new TaskInfoCreateAndStartTaskRequest();
        return TeaModel.build(map, self);
    }

    public TaskInfoCreateAndStartTaskRequest setAttr(TaskInfoCreateAndStartTaskRequestAttr attr) {
        this.attr = attr;
        return this;
    }
    public TaskInfoCreateAndStartTaskRequestAttr getAttr() {
        return this.attr;
    }

    public TaskInfoCreateAndStartTaskRequest setBacklogDTO(TaskInfoCreateAndStartTaskRequestBacklogDTO backlogDTO) {
        this.backlogDTO = backlogDTO;
        return this;
    }
    public TaskInfoCreateAndStartTaskRequestBacklogDTO getBacklogDTO() {
        return this.backlogDTO;
    }

    public TaskInfoCreateAndStartTaskRequest setBacklogGenerateFlag(Integer backlogGenerateFlag) {
        this.backlogGenerateFlag = backlogGenerateFlag;
        return this;
    }
    public Integer getBacklogGenerateFlag() {
        return this.backlogGenerateFlag;
    }

    public TaskInfoCreateAndStartTaskRequest setBusinessCode(String businessCode) {
        this.businessCode = businessCode;
        return this;
    }
    public String getBusinessCode() {
        return this.businessCode;
    }

    public TaskInfoCreateAndStartTaskRequest setCanceldelTaskCardId(String canceldelTaskCardId) {
        this.canceldelTaskCardId = canceldelTaskCardId;
        return this;
    }
    public String getCanceldelTaskCardId() {
        return this.canceldelTaskCardId;
    }

    public TaskInfoCreateAndStartTaskRequest setCardDTO(TaskInfoCreateAndStartTaskRequestCardDTO cardDTO) {
        this.cardDTO = cardDTO;
        return this;
    }
    public TaskInfoCreateAndStartTaskRequestCardDTO getCardDTO() {
        return this.cardDTO;
    }

    public TaskInfoCreateAndStartTaskRequest setCustomFlag(Integer customFlag) {
        this.customFlag = customFlag;
        return this;
    }
    public Integer getCustomFlag() {
        return this.customFlag;
    }

    public TaskInfoCreateAndStartTaskRequest setDetailUrl(TaskInfoCreateAndStartTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public TaskInfoCreateAndStartTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public TaskInfoCreateAndStartTaskRequest setFinishTaskCardId(String finishTaskCardId) {
        this.finishTaskCardId = finishTaskCardId;
        return this;
    }
    public String getFinishTaskCardId() {
        return this.finishTaskCardId;
    }

    public TaskInfoCreateAndStartTaskRequest setOperatorAccount(String operatorAccount) {
        this.operatorAccount = operatorAccount;
        return this;
    }
    public String getOperatorAccount() {
        return this.operatorAccount;
    }

    public TaskInfoCreateAndStartTaskRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public TaskInfoCreateAndStartTaskRequest setProjId(String projId) {
        this.projId = projId;
        return this;
    }
    public String getProjId() {
        return this.projId;
    }

    public TaskInfoCreateAndStartTaskRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

    public TaskInfoCreateAndStartTaskRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public TaskInfoCreateAndStartTaskRequest setSendMsgFlag(Integer sendMsgFlag) {
        this.sendMsgFlag = sendMsgFlag;
        return this;
    }
    public Integer getSendMsgFlag() {
        return this.sendMsgFlag;
    }

    public TaskInfoCreateAndStartTaskRequest setSort(Integer sort) {
        this.sort = sort;
        return this;
    }
    public Integer getSort() {
        return this.sort;
    }

    public TaskInfoCreateAndStartTaskRequest setStartTaskCardId(String startTaskCardId) {
        this.startTaskCardId = startTaskCardId;
        return this;
    }
    public String getStartTaskCardId() {
        return this.startTaskCardId;
    }

    public TaskInfoCreateAndStartTaskRequest setState(Integer state) {
        this.state = state;
        return this;
    }
    public Integer getState() {
        return this.state;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskContent(String taskContent) {
        this.taskContent = taskContent;
        return this;
    }
    public String getTaskContent() {
        return this.taskContent;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskEndTime(Long taskEndTime) {
        this.taskEndTime = taskEndTime;
        return this;
    }
    public Long getTaskEndTime() {
        return this.taskEndTime;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskExecutePersonDTOS(java.util.List<TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS) {
        this.taskExecutePersonDTOS = taskExecutePersonDTOS;
        return this;
    }
    public java.util.List<TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS> getTaskExecutePersonDTOS() {
        return this.taskExecutePersonDTOS;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskGroupDTOList(java.util.List<TaskInfoCreateAndStartTaskRequestTaskGroupDTOList> taskGroupDTOList) {
        this.taskGroupDTOList = taskGroupDTOList;
        return this;
    }
    public java.util.List<TaskInfoCreateAndStartTaskRequestTaskGroupDTOList> getTaskGroupDTOList() {
        return this.taskGroupDTOList;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskSystem(String taskSystem) {
        this.taskSystem = taskSystem;
        return this;
    }
    public String getTaskSystem() {
        return this.taskSystem;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskTemplCode(String taskTemplCode) {
        this.taskTemplCode = taskTemplCode;
        return this;
    }
    public String getTaskTemplCode() {
        return this.taskTemplCode;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskTitle(String taskTitle) {
        this.taskTitle = taskTitle;
        return this;
    }
    public String getTaskTitle() {
        return this.taskTitle;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskType(String taskType) {
        this.taskType = taskType;
        return this;
    }
    public String getTaskType() {
        return this.taskType;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskUrlMobile(String taskUrlMobile) {
        this.taskUrlMobile = taskUrlMobile;
        return this;
    }
    public String getTaskUrlMobile() {
        return this.taskUrlMobile;
    }

    public TaskInfoCreateAndStartTaskRequest setTaskUrlPc(String taskUrlPc) {
        this.taskUrlPc = taskUrlPc;
        return this;
    }
    public String getTaskUrlPc() {
        return this.taskUrlPc;
    }

    public TaskInfoCreateAndStartTaskRequest setUpdateTaskCardId(String updateTaskCardId) {
        this.updateTaskCardId = updateTaskCardId;
        return this;
    }
    public String getUpdateTaskCardId() {
        return this.updateTaskCardId;
    }

    public static class TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr extends TeaModel {
        @NameInMap("attrCode")
        public String attrCode;

        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr self = new TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestAttr extends TeaModel {
        @NameInMap("listTaskDynamicAttr")
        public java.util.List<TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr> listTaskDynamicAttr;

        public static TaskInfoCreateAndStartTaskRequestAttr build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestAttr self = new TaskInfoCreateAndStartTaskRequestAttr();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestAttr setListTaskDynamicAttr(java.util.List<TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr> listTaskDynamicAttr) {
            this.listTaskDynamicAttr = listTaskDynamicAttr;
            return this;
        }
        public java.util.List<TaskInfoCreateAndStartTaskRequestAttrListTaskDynamicAttr> getListTaskDynamicAttr() {
            return this.listTaskDynamicAttr;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestBacklogDTOContent extends TeaModel {
        @NameInMap("isOnlyShowExecutor")
        public Boolean isOnlyShowExecutor;

        @NameInMap("priority")
        public Integer priority;

        public static TaskInfoCreateAndStartTaskRequestBacklogDTOContent build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestBacklogDTOContent self = new TaskInfoCreateAndStartTaskRequestBacklogDTOContent();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestBacklogDTOContent setIsOnlyShowExecutor(Boolean isOnlyShowExecutor) {
            this.isOnlyShowExecutor = isOnlyShowExecutor;
            return this;
        }
        public Boolean getIsOnlyShowExecutor() {
            return this.isOnlyShowExecutor;
        }

        public TaskInfoCreateAndStartTaskRequestBacklogDTOContent setPriority(Integer priority) {
            this.priority = priority;
            return this;
        }
        public Integer getPriority() {
            return this.priority;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestBacklogDTO extends TeaModel {
        @NameInMap("content")
        public TaskInfoCreateAndStartTaskRequestBacklogDTOContent content;

        public static TaskInfoCreateAndStartTaskRequestBacklogDTO build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestBacklogDTO self = new TaskInfoCreateAndStartTaskRequestBacklogDTO();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestBacklogDTO setContent(TaskInfoCreateAndStartTaskRequestBacklogDTOContent content) {
            this.content = content;
            return this;
        }
        public TaskInfoCreateAndStartTaskRequestBacklogDTOContent getContent() {
            return this.content;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestCardDTO extends TeaModel {
        @NameInMap("atAccount")
        public String atAccount;

        @NameInMap("cardCallbackUrl")
        public String cardCallbackUrl;

        @NameInMap("content")
        public Object content;

        @NameInMap("isAtAll")
        public Boolean isAtAll;

        @NameInMap("receiverAccount")
        public String receiverAccount;

        public static TaskInfoCreateAndStartTaskRequestCardDTO build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestCardDTO self = new TaskInfoCreateAndStartTaskRequestCardDTO();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestCardDTO setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public TaskInfoCreateAndStartTaskRequestCardDTO setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public TaskInfoCreateAndStartTaskRequestCardDTO setContent(Object content) {
            this.content = content;
            return this;
        }
        public Object getContent() {
            return this.content;
        }

        public TaskInfoCreateAndStartTaskRequestCardDTO setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public TaskInfoCreateAndStartTaskRequestCardDTO setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        public static TaskInfoCreateAndStartTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestDetailUrl self = new TaskInfoCreateAndStartTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public TaskInfoCreateAndStartTaskRequestDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("personType")
        public Integer personType;

        public static TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS self = new TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public TaskInfoCreateAndStartTaskRequestTaskExecutePersonDTOS setPersonType(Integer personType) {
            this.personType = personType;
            return this;
        }
        public Integer getPersonType() {
            return this.personType;
        }

    }

    public static class TaskInfoCreateAndStartTaskRequestTaskGroupDTOList extends TeaModel {
        @NameInMap("openConversationId")
        public String openConversationId;

        public static TaskInfoCreateAndStartTaskRequestTaskGroupDTOList build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCreateAndStartTaskRequestTaskGroupDTOList self = new TaskInfoCreateAndStartTaskRequestTaskGroupDTOList();
            return TeaModel.build(map, self);
        }

        public TaskInfoCreateAndStartTaskRequestTaskGroupDTOList setOpenConversationId(String openConversationId) {
            this.openConversationId = openConversationId;
            return this;
        }
        public String getOpenConversationId() {
            return this.openConversationId;
        }

    }

}
