// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmcp_1_0.models;

import com.aliyun.tea.*;

public class DeleteMcpRequest extends TeaModel {
    @NameInMap("instanceId")
    public String instanceId;

    public static DeleteMcpRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteMcpRequest self = new DeleteMcpRequest();
        return TeaModel.build(map, self);
    }

    public DeleteMcpRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
