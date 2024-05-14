// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class UpdateCrmPersonalCustomerResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    public static UpdateCrmPersonalCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCrmPersonalCustomerResponseBody self = new UpdateCrmPersonalCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCrmPersonalCustomerResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
