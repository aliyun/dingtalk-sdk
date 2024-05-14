// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class StartProcessInstanceResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("instanceId")
    public String instanceId;

    public static StartProcessInstanceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        StartProcessInstanceResponseBody self = new StartProcessInstanceResponseBody();
        return TeaModel.build(map, self);
    }

    public StartProcessInstanceResponseBody setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

}
