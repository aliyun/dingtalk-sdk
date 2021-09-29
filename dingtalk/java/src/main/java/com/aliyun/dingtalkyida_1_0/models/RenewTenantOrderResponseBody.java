// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewTenantOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RenewTenantOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RenewTenantOrderResponseBody self = new RenewTenantOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public RenewTenantOrderResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
