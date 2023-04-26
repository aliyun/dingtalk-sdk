// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RemoveTenantResourceRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    public static RemoveTenantResourceRequest build(java.util.Map<String, ?> map) throws Exception {
        RemoveTenantResourceRequest self = new RemoveTenantResourceRequest();
        return TeaModel.build(map, self);
    }

    public RemoveTenantResourceRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

}
