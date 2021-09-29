// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyAuthorizationOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BuyAuthorizationOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BuyAuthorizationOrderResponseBody self = new BuyAuthorizationOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public BuyAuthorizationOrderResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
