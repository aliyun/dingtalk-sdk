// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmPersonalCustomerResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static DeleteCrmPersonalCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmPersonalCustomerResponseBody self = new DeleteCrmPersonalCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCrmPersonalCustomerResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
