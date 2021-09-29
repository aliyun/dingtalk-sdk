// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class RenewApplicationAuthorizationServiceOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static RenewApplicationAuthorizationServiceOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RenewApplicationAuthorizationServiceOrderResponseBody self = new RenewApplicationAuthorizationServiceOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public RenewApplicationAuthorizationServiceOrderResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
