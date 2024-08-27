// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumRedirectTasksByManagerRequest extends TeaModel {
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

    public static PremiumRedirectTasksByManagerRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumRedirectTasksByManagerRequest self = new PremiumRedirectTasksByManagerRequest();
        return TeaModel.build(map, self);
    }

    public PremiumRedirectTasksByManagerRequest setHandoverUserId(String handoverUserId) {
        this.handoverUserId = handoverUserId;
        return this;
    }
    public String getHandoverUserId() {
        return this.handoverUserId;
    }

    public PremiumRedirectTasksByManagerRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public PremiumRedirectTasksByManagerRequest setTaskIds(java.util.List<Long> taskIds) {
        this.taskIds = taskIds;
        return this;
    }
    public java.util.List<Long> getTaskIds() {
        return this.taskIds;
    }

    public PremiumRedirectTasksByManagerRequest setTransfereeUserId(String transfereeUserId) {
        this.transfereeUserId = transfereeUserId;
        return this;
    }
    public String getTransfereeUserId() {
        return this.transfereeUserId;
    }

}
