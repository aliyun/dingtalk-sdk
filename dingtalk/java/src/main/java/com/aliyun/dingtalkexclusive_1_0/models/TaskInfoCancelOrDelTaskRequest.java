// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoCancelOrDelTaskRequest extends TeaModel {
    @NameInMap("cardDTO")
    public TaskInfoCancelOrDelTaskRequestCardDTO cardDTO;

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

    @NameInMap("taskExecutePersonDTOS")
    public java.util.List<TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS;

    public static TaskInfoCancelOrDelTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoCancelOrDelTaskRequest self = new TaskInfoCancelOrDelTaskRequest();
        return TeaModel.build(map, self);
    }

    public TaskInfoCancelOrDelTaskRequest setCardDTO(TaskInfoCancelOrDelTaskRequestCardDTO cardDTO) {
        this.cardDTO = cardDTO;
        return this;
    }
    public TaskInfoCancelOrDelTaskRequestCardDTO getCardDTO() {
        return this.cardDTO;
    }

    public TaskInfoCancelOrDelTaskRequest setOperatorAccount(String operatorAccount) {
        this.operatorAccount = operatorAccount;
        return this;
    }
    public String getOperatorAccount() {
        return this.operatorAccount;
    }

    public TaskInfoCancelOrDelTaskRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public TaskInfoCancelOrDelTaskRequest setProjId(String projId) {
        this.projId = projId;
        return this;
    }
    public String getProjId() {
        return this.projId;
    }

    public TaskInfoCancelOrDelTaskRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public TaskInfoCancelOrDelTaskRequest setSendMsgFlag(Integer sendMsgFlag) {
        this.sendMsgFlag = sendMsgFlag;
        return this;
    }
    public Integer getSendMsgFlag() {
        return this.sendMsgFlag;
    }

    public TaskInfoCancelOrDelTaskRequest setTaskExecutePersonDTOS(java.util.List<TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS) {
        this.taskExecutePersonDTOS = taskExecutePersonDTOS;
        return this;
    }
    public java.util.List<TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS> getTaskExecutePersonDTOS() {
        return this.taskExecutePersonDTOS;
    }

    public static class TaskInfoCancelOrDelTaskRequestCardDTO extends TeaModel {
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

        public static TaskInfoCancelOrDelTaskRequestCardDTO build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCancelOrDelTaskRequestCardDTO self = new TaskInfoCancelOrDelTaskRequestCardDTO();
            return TeaModel.build(map, self);
        }

        public TaskInfoCancelOrDelTaskRequestCardDTO setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public TaskInfoCancelOrDelTaskRequestCardDTO setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public TaskInfoCancelOrDelTaskRequestCardDTO setContent(Object content) {
            this.content = content;
            return this;
        }
        public Object getContent() {
            return this.content;
        }

        public TaskInfoCancelOrDelTaskRequestCardDTO setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public TaskInfoCancelOrDelTaskRequestCardDTO setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

    }

    public static class TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("personType")
        public Integer personType;

        public static TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS self = new TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS();
            return TeaModel.build(map, self);
        }

        public TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public TaskInfoCancelOrDelTaskRequestTaskExecutePersonDTOS setPersonType(Integer personType) {
            this.personType = personType;
            return this;
        }
        public Integer getPersonType() {
            return this.personType;
        }

    }

}
