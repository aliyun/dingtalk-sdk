// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteWorkflowInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>xxxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteWorkflowInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteWorkflowInstanceRequest self = new DeleteWorkflowInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteWorkflowInstanceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public DeleteWorkflowInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
