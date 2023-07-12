// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMarketManagerResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DiotMarketManagerResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DiotMarketManagerResponseBody self = new DiotMarketManagerResponseBody();
        return TeaModel.build(map, self);
    }

    public DiotMarketManagerResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
