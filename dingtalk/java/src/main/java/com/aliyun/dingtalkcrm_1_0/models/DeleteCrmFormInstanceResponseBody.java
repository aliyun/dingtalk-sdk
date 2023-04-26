// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class DeleteCrmFormInstanceResponseBody extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static DeleteCrmFormInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCrmFormInstanceResponseBody self = new DeleteCrmFormInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCrmFormInstanceResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
