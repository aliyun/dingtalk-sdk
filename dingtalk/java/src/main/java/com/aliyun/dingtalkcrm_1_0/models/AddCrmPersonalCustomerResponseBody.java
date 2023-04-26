// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCrmPersonalCustomerResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static AddCrmPersonalCustomerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCrmPersonalCustomerResponseBody self = new AddCrmPersonalCustomerResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCrmPersonalCustomerResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
