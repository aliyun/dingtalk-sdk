// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoUpdateTaskRequest extends TeaModel {
    @NameInMap("attr")
    public TaskInfoUpdateTaskRequestAttr attr;

    @NameInMap("canceldelTaskCardId")
    public String canceldelTaskCardId;

    @NameInMap("cardDTO")
    public TaskInfoUpdateTaskRequestCardDTO cardDTO;

    @NameInMap("detailUrl")
    public TaskInfoUpdateTaskRequestDetailUrl detailUrl;

    @NameInMap("finishTaskCardId")
    public String finishTaskCardId;

    @NameInMap("listOpenConversationId")
    public java.util.List<String> listOpenConversationId;

    @NameInMap("operateType")
    public Integer operateType;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operatorAccount")
    public String operatorAccount;

    @NameInMap("outTaskId")
    public String outTaskId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("projId")
    public String projId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("secretKey")
    public String secretKey;

    @NameInMap("sendMsgFlag")
    public Integer sendMsgFlag;

    @NameInMap("startTaskCardId")
    public String startTaskCardId;

    @NameInMap("taskContent")
    public String taskContent;

    @NameInMap("taskEndTime")
    public Long taskEndTime;

    @NameInMap("taskExecutePersonDTOS")
    public java.util.List<TaskInfoUpdateTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS;

    @NameInMap("taskTitle")
    public String taskTitle;

    @NameInMap("taskUrlMobile")
    public String taskUrlMobile;

    @NameInMap("taskUrlPc")
    public String taskUrlPc;

    @NameInMap("updateTaskCardId")
    public String updateTaskCardId;

    public static TaskInfoUpdateTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoUpdateTaskRequest self = new TaskInfoUpdateTaskRequest();
        return TeaModel.build(map, self);
    }

    public TaskInfoUpdateTaskRequest setAttr(TaskInfoUpdateTaskRequestAttr attr) {
        this.attr = attr;
        return this;
    }
    public TaskInfoUpdateTaskRequestAttr getAttr() {
        return this.attr;
    }

    public TaskInfoUpdateTaskRequest setCanceldelTaskCardId(String canceldelTaskCardId) {
        this.canceldelTaskCardId = canceldelTaskCardId;
        return this;
    }
    public String getCanceldelTaskCardId() {
        return this.canceldelTaskCardId;
    }

    public TaskInfoUpdateTaskRequest setCardDTO(TaskInfoUpdateTaskRequestCardDTO cardDTO) {
        this.cardDTO = cardDTO;
        return this;
    }
    public TaskInfoUpdateTaskRequestCardDTO getCardDTO() {
        return this.cardDTO;
    }

    public TaskInfoUpdateTaskRequest setDetailUrl(TaskInfoUpdateTaskRequestDetailUrl detailUrl) {
        this.detailUrl = detailUrl;
        return this;
    }
    public TaskInfoUpdateTaskRequestDetailUrl getDetailUrl() {
        return this.detailUrl;
    }

    public TaskInfoUpdateTaskRequest setFinishTaskCardId(String finishTaskCardId) {
        this.finishTaskCardId = finishTaskCardId;
        return this;
    }
    public String getFinishTaskCardId() {
        return this.finishTaskCardId;
    }

    public TaskInfoUpdateTaskRequest setListOpenConversationId(java.util.List<String> listOpenConversationId) {
        this.listOpenConversationId = listOpenConversationId;
        return this;
    }
    public java.util.List<String> getListOpenConversationId() {
        return this.listOpenConversationId;
    }

    public TaskInfoUpdateTaskRequest setOperateType(Integer operateType) {
        this.operateType = operateType;
        return this;
    }
    public Integer getOperateType() {
        return this.operateType;
    }

    public TaskInfoUpdateTaskRequest setOperatorAccount(String operatorAccount) {
        this.operatorAccount = operatorAccount;
        return this;
    }
    public String getOperatorAccount() {
        return this.operatorAccount;
    }

    public TaskInfoUpdateTaskRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public TaskInfoUpdateTaskRequest setProjId(String projId) {
        this.projId = projId;
        return this;
    }
    public String getProjId() {
        return this.projId;
    }

    public TaskInfoUpdateTaskRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public TaskInfoUpdateTaskRequest setSendMsgFlag(Integer sendMsgFlag) {
        this.sendMsgFlag = sendMsgFlag;
        return this;
    }
    public Integer getSendMsgFlag() {
        return this.sendMsgFlag;
    }

    public TaskInfoUpdateTaskRequest setStartTaskCardId(String startTaskCardId) {
        this.startTaskCardId = startTaskCardId;
        return this;
    }
    public String getStartTaskCardId() {
        return this.startTaskCardId;
    }

    public TaskInfoUpdateTaskRequest setTaskContent(String taskContent) {
        this.taskContent = taskContent;
        return this;
    }
    public String getTaskContent() {
        return this.taskContent;
    }

    public TaskInfoUpdateTaskRequest setTaskEndTime(Long taskEndTime) {
        this.taskEndTime = taskEndTime;
        return this;
    }
    public Long getTaskEndTime() {
        return this.taskEndTime;
    }

    public TaskInfoUpdateTaskRequest setTaskExecutePersonDTOS(java.util.List<TaskInfoUpdateTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS) {
        this.taskExecutePersonDTOS = taskExecutePersonDTOS;
        return this;
    }
    public java.util.List<TaskInfoUpdateTaskRequestTaskExecutePersonDTOS> getTaskExecutePersonDTOS() {
        return this.taskExecutePersonDTOS;
    }

    public TaskInfoUpdateTaskRequest setTaskTitle(String taskTitle) {
        this.taskTitle = taskTitle;
        return this;
    }
    public String getTaskTitle() {
        return this.taskTitle;
    }

    public TaskInfoUpdateTaskRequest setTaskUrlMobile(String taskUrlMobile) {
        this.taskUrlMobile = taskUrlMobile;
        return this;
    }
    public String getTaskUrlMobile() {
        return this.taskUrlMobile;
    }

    public TaskInfoUpdateTaskRequest setTaskUrlPc(String taskUrlPc) {
        this.taskUrlPc = taskUrlPc;
        return this;
    }
    public String getTaskUrlPc() {
        return this.taskUrlPc;
    }

    public TaskInfoUpdateTaskRequest setUpdateTaskCardId(String updateTaskCardId) {
        this.updateTaskCardId = updateTaskCardId;
        return this;
    }
    public String getUpdateTaskCardId() {
        return this.updateTaskCardId;
    }

    public static class TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr extends TeaModel {
        @NameInMap("attrCode")
        public String attrCode;

        @NameInMap("listAttrOptionsCode")
        public java.util.List<String> listAttrOptionsCode;

        public static TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr self = new TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr setAttrCode(String attrCode) {
            this.attrCode = attrCode;
            return this;
        }
        public String getAttrCode() {
            return this.attrCode;
        }

        public TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr setListAttrOptionsCode(java.util.List<String> listAttrOptionsCode) {
            this.listAttrOptionsCode = listAttrOptionsCode;
            return this;
        }
        public java.util.List<String> getListAttrOptionsCode() {
            return this.listAttrOptionsCode;
        }

    }

    public static class TaskInfoUpdateTaskRequestAttr extends TeaModel {
        @NameInMap("listTaskDynamicAttr")
        public java.util.List<TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr> listTaskDynamicAttr;

        public static TaskInfoUpdateTaskRequestAttr build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskRequestAttr self = new TaskInfoUpdateTaskRequestAttr();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskRequestAttr setListTaskDynamicAttr(java.util.List<TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr> listTaskDynamicAttr) {
            this.listTaskDynamicAttr = listTaskDynamicAttr;
            return this;
        }
        public java.util.List<TaskInfoUpdateTaskRequestAttrListTaskDynamicAttr> getListTaskDynamicAttr() {
            return this.listTaskDynamicAttr;
        }

    }

    public static class TaskInfoUpdateTaskRequestCardDTO extends TeaModel {
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

        public static TaskInfoUpdateTaskRequestCardDTO build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskRequestCardDTO self = new TaskInfoUpdateTaskRequestCardDTO();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskRequestCardDTO setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public TaskInfoUpdateTaskRequestCardDTO setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public TaskInfoUpdateTaskRequestCardDTO setContent(Object content) {
            this.content = content;
            return this;
        }
        public Object getContent() {
            return this.content;
        }

        public TaskInfoUpdateTaskRequestCardDTO setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public TaskInfoUpdateTaskRequestCardDTO setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

    }

    public static class TaskInfoUpdateTaskRequestDetailUrl extends TeaModel {
        @NameInMap("appUrl")
        public String appUrl;

        @NameInMap("pcUrl")
        public String pcUrl;

        public static TaskInfoUpdateTaskRequestDetailUrl build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskRequestDetailUrl self = new TaskInfoUpdateTaskRequestDetailUrl();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskRequestDetailUrl setAppUrl(String appUrl) {
            this.appUrl = appUrl;
            return this;
        }
        public String getAppUrl() {
            return this.appUrl;
        }

        public TaskInfoUpdateTaskRequestDetailUrl setPcUrl(String pcUrl) {
            this.pcUrl = pcUrl;
            return this;
        }
        public String getPcUrl() {
            return this.pcUrl;
        }

    }

    public static class TaskInfoUpdateTaskRequestTaskExecutePersonDTOS extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("personType")
        public Integer personType;

        public static TaskInfoUpdateTaskRequestTaskExecutePersonDTOS build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoUpdateTaskRequestTaskExecutePersonDTOS self = new TaskInfoUpdateTaskRequestTaskExecutePersonDTOS();
            return TeaModel.build(map, self);
        }

        public TaskInfoUpdateTaskRequestTaskExecutePersonDTOS setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public TaskInfoUpdateTaskRequestTaskExecutePersonDTOS setPersonType(Integer personType) {
            this.personType = personType;
            return this;
        }
        public Integer getPersonType() {
            return this.personType;
        }

    }

}
