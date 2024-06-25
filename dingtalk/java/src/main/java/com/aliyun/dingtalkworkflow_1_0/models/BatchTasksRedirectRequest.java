// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class BatchTasksRedirectRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staffId-B</p>
     */
    @NameInMap("handoverUserId")
    public String handoverUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager-12</p>
     */
    @NameInMap("managerUserId")
    public String managerUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("taskIds")
    public java.util.List<Long> taskIds;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>staffId-A</p>
     */
    @NameInMap("transfereeUserId")
    public String transfereeUserId;

    public static BatchTasksRedirectRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchTasksRedirectRequest self = new BatchTasksRedirectRequest();
        return TeaModel.build(map, self);
    }

    public BatchTasksRedirectRequest setHandoverUserId(String handoverUserId) {
        this.handoverUserId = handoverUserId;
        return this;
    }
    public String getHandoverUserId() {
        return this.handoverUserId;
    }

    public BatchTasksRedirectRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public BatchTasksRedirectRequest setTaskIds(java.util.List<Long> taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public java.util.List<Long> getTaskIds() {
        return this.taskIds;
    }

    public BatchTasksRedirectRequest setTransfereeUserId(String transfereeUserId) {
        this.transfereeUserId = transfereeUserId;
        return this;
    }
    public String getTransfereeUserId() {
        return this.transfereeUserId;
    }

}
