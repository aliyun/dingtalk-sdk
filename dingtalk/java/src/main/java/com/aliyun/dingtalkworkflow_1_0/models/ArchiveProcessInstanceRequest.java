// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ArchiveProcessInstanceRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>133743186427339452</p>
     */
    @NameInMap("opUserId")
    public String opUserId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>a171de6c-8bxxxx</p>
     */
    @NameInMap("processInstanceId")
    public String processInstanceId;

    public static ArchiveProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        ArchiveProcessInstanceRequest self = new ArchiveProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public ArchiveProcessInstanceRequest setOpUserId(String opUserId) {
        this.opUserId = opUserId;
        return this;
    }
    public String getOpUserId() {
        return this.opUserId;
    }

    public ArchiveProcessInstanceRequest setProcessInstanceId(String processInstanceId) {
        this.processInstanceId = processInstanceId;
        return this;
    }
    public String getProcessInstanceId() {
        return this.processInstanceId;
    }

}
