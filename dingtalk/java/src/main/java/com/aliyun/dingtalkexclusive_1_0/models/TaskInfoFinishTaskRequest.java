// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoFinishTaskRequest extends TeaModel {
    @NameInMap("cardDTO")
    public TaskInfoFinishTaskRequestCardDTO cardDTO;

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
    public java.util.List<TaskInfoFinishTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS;

    public static TaskInfoFinishTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoFinishTaskRequest self = new TaskInfoFinishTaskRequest();
        return TeaModel.build(map, self);
    }

    public TaskInfoFinishTaskRequest setCardDTO(TaskInfoFinishTaskRequestCardDTO cardDTO) {
        this.cardDTO = cardDTO;
        return this;
    }
    public TaskInfoFinishTaskRequestCardDTO getCardDTO() {
        return this.cardDTO;
    }

    public TaskInfoFinishTaskRequest setOperatorAccount(String operatorAccount) {
        this.operatorAccount = operatorAccount;
        return this;
    }
    public String getOperatorAccount() {
        return this.operatorAccount;
    }

    public TaskInfoFinishTaskRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public TaskInfoFinishTaskRequest setProjId(String projId) {
        this.projId = projId;
        return this;
    }
    public String getProjId() {
        return this.projId;
    }

    public TaskInfoFinishTaskRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public TaskInfoFinishTaskRequest setSendMsgFlag(Integer sendMsgFlag) {
        this.sendMsgFlag = sendMsgFlag;
        return this;
    }
    public Integer getSendMsgFlag() {
        return this.sendMsgFlag;
    }

    public TaskInfoFinishTaskRequest setTaskExecutePersonDTOS(java.util.List<TaskInfoFinishTaskRequestTaskExecutePersonDTOS> taskExecutePersonDTOS) {
        this.taskExecutePersonDTOS = taskExecutePersonDTOS;
        return this;
    }
    public java.util.List<TaskInfoFinishTaskRequestTaskExecutePersonDTOS> getTaskExecutePersonDTOS() {
        return this.taskExecutePersonDTOS;
    }

    public static class TaskInfoFinishTaskRequestCardDTO extends TeaModel {
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

        public static TaskInfoFinishTaskRequestCardDTO build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoFinishTaskRequestCardDTO self = new TaskInfoFinishTaskRequestCardDTO();
            return TeaModel.build(map, self);
        }

        public TaskInfoFinishTaskRequestCardDTO setAtAccount(String atAccount) {
            this.atAccount = atAccount;
            return this;
        }
        public String getAtAccount() {
            return this.atAccount;
        }

        public TaskInfoFinishTaskRequestCardDTO setCardCallbackUrl(String cardCallbackUrl) {
            this.cardCallbackUrl = cardCallbackUrl;
            return this;
        }
        public String getCardCallbackUrl() {
            return this.cardCallbackUrl;
        }

        public TaskInfoFinishTaskRequestCardDTO setContent(Object content) {
            this.content = content;
            return this;
        }
        public Object getContent() {
            return this.content;
        }

        public TaskInfoFinishTaskRequestCardDTO setIsAtAll(Boolean isAtAll) {
            this.isAtAll = isAtAll;
            return this;
        }
        public Boolean getIsAtAll() {
            return this.isAtAll;
        }

        public TaskInfoFinishTaskRequestCardDTO setReceiverAccount(String receiverAccount) {
            this.receiverAccount = receiverAccount;
            return this;
        }
        public String getReceiverAccount() {
            return this.receiverAccount;
        }

    }

    public static class TaskInfoFinishTaskRequestTaskExecutePersonDTOS extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("personType")
        public Integer personType;

        public static TaskInfoFinishTaskRequestTaskExecutePersonDTOS build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoFinishTaskRequestTaskExecutePersonDTOS self = new TaskInfoFinishTaskRequestTaskExecutePersonDTOS();
            return TeaModel.build(map, self);
        }

        public TaskInfoFinishTaskRequestTaskExecutePersonDTOS setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public TaskInfoFinishTaskRequestTaskExecutePersonDTOS setPersonType(Integer personType) {
            this.personType = personType;
            return this;
        }
        public Integer getPersonType() {
            return this.personType;
        }

    }

}
