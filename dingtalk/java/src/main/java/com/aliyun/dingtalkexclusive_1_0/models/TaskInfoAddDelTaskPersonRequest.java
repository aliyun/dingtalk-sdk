// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TaskInfoAddDelTaskPersonRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("operateType")
    public Integer operateType;

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

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("secretKey")
    public String secretKey;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("taskExecutePersonDTOS")
    public java.util.List<TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS> taskExecutePersonDTOS;

    public static TaskInfoAddDelTaskPersonRequest build(java.util.Map<String, ?> map) throws Exception {
        TaskInfoAddDelTaskPersonRequest self = new TaskInfoAddDelTaskPersonRequest();
        return TeaModel.build(map, self);
    }

    public TaskInfoAddDelTaskPersonRequest setOperateType(Integer operateType) {
        this.operateType = operateType;
        return this;
    }
    public Integer getOperateType() {
        return this.operateType;
    }

    public TaskInfoAddDelTaskPersonRequest setOperatorAccount(String operatorAccount) {
        this.operatorAccount = operatorAccount;
        return this;
    }
    public String getOperatorAccount() {
        return this.operatorAccount;
    }

    public TaskInfoAddDelTaskPersonRequest setOutTaskId(String outTaskId) {
        this.outTaskId = outTaskId;
        return this;
    }
    public String getOutTaskId() {
        return this.outTaskId;
    }

    public TaskInfoAddDelTaskPersonRequest setProjId(String projId) {
        this.projId = projId;
        return this;
    }
    public String getProjId() {
        return this.projId;
    }

    public TaskInfoAddDelTaskPersonRequest setSecretKey(String secretKey) {
        this.secretKey = secretKey;
        return this;
    }
    public String getSecretKey() {
        return this.secretKey;
    }

    public TaskInfoAddDelTaskPersonRequest setTaskExecutePersonDTOS(java.util.List<TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS> taskExecutePersonDTOS) {
        this.taskExecutePersonDTOS = taskExecutePersonDTOS;
        return this;
    }
    public java.util.List<TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS> getTaskExecutePersonDTOS() {
        return this.taskExecutePersonDTOS;
    }

    public static class TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS extends TeaModel {
        @NameInMap("employeeCode")
        public String employeeCode;

        @NameInMap("personType")
        public Integer personType;

        public static TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS build(java.util.Map<String, ?> map) throws Exception {
            TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS self = new TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS();
            return TeaModel.build(map, self);
        }

        public TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS setEmployeeCode(String employeeCode) {
            this.employeeCode = employeeCode;
            return this;
        }
        public String getEmployeeCode() {
            return this.employeeCode;
        }

        public TaskInfoAddDelTaskPersonRequestTaskExecutePersonDTOS setPersonType(Integer personType) {
            this.personType = personType;
            return this;
        }
        public Integer getPersonType() {
            return this.personType;
        }

    }

}
