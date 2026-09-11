// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class SetWorkflowTaskAgentRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentStaffId")
    public String agentStaffId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("all")
    public Boolean all;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2026-08-25</p>
     */
    @NameInMap("endDate")
    public String endDate;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("fromStaffId")
    public String fromStaffId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("managerStaffId")
    public String managerStaffId;

    @NameInMap("processCodes")
    public java.util.List<String> processCodes;

    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>2026-08-25</p>
     */
    @NameInMap("startDate")
    public String startDate;

    public static SetWorkflowTaskAgentRequest build(java.util.Map<String, ?> map) throws Exception {
        SetWorkflowTaskAgentRequest self = new SetWorkflowTaskAgentRequest();
        return TeaModel.build(map, self);
    }

    public SetWorkflowTaskAgentRequest setAgentStaffId(String agentStaffId) {
        this.agentStaffId = agentStaffId;
        return this;
    }
    public String getAgentStaffId() {
        return this.agentStaffId;
    }

    public SetWorkflowTaskAgentRequest setAll(Boolean all) {
        this.all = all;
        return this;
    }
    public Boolean getAll() {
        return this.all;
    }

    public SetWorkflowTaskAgentRequest setEndDate(String endDate) {
        this.endDate = endDate;
        return this;
    }
    public String getEndDate() {
        return this.endDate;
    }

    public SetWorkflowTaskAgentRequest setFromStaffId(String fromStaffId) {
        this.fromStaffId = fromStaffId;
        return this;
    }
    public String getFromStaffId() {
        return this.fromStaffId;
    }

    public SetWorkflowTaskAgentRequest setManagerStaffId(String managerStaffId) {
        this.managerStaffId = managerStaffId;
        return this;
    }
    public String getManagerStaffId() {
        return this.managerStaffId;
    }

    public SetWorkflowTaskAgentRequest setProcessCodes(java.util.List<String> processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public java.util.List<String> getProcessCodes() {
        return this.processCodes;
    }

    public SetWorkflowTaskAgentRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SetWorkflowTaskAgentRequest setStartDate(String startDate) {
        this.startDate = startDate;
        return this;
    }
    public String getStartDate() {
        return this.startDate;
    }

}
