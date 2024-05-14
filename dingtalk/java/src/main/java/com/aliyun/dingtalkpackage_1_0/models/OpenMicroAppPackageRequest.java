// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkpackage_1_0.models;

import com.aliyun.tea.*;

public class OpenMicroAppPackageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentId")
    public Long agentId;

    public static OpenMicroAppPackageRequest build(java.util.Map<String, ?> map) throws Exception {
        OpenMicroAppPackageRequest self = new OpenMicroAppPackageRequest();
        return TeaModel.build(map, self);
    }

    public OpenMicroAppPackageRequest setAgentId(Long agentId) {
        this.agentId = agentId;
        return this;
    }
    public Long getAgentId() {
        return this.agentId;
    }

}
