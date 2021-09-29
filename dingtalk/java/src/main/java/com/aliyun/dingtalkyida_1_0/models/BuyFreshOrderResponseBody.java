// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class BuyFreshOrderResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static BuyFreshOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BuyFreshOrderResponseBody self = new BuyFreshOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public BuyFreshOrderResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
