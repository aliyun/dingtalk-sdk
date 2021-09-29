// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RemoveTenantResourceResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RemoveTenantResourceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveTenantResourceResponseBody self = new RemoveTenantResourceResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveTenantResourceResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
