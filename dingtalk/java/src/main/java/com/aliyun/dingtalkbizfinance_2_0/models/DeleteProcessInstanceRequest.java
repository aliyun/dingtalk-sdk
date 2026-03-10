// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class DeleteProcessInstanceRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    /**
     * <strong>example:</strong>
     * <p>xxxx</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteProcessInstanceRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteProcessInstanceRequest self = new DeleteProcessInstanceRequest();
        return TeaModel.build(map, self);
    }

    public DeleteProcessInstanceRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public DeleteProcessInstanceRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
