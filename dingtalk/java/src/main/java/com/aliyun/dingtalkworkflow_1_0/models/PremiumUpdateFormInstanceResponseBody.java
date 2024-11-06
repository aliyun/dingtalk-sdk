// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumUpdateFormInstanceResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static PremiumUpdateFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        PremiumUpdateFormInstanceResponseBody self = new PremiumUpdateFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public PremiumUpdateFormInstanceResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
