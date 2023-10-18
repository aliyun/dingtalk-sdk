// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMarketManagerTestResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DiotMarketManagerTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DiotMarketManagerTestResponseBody self = new DiotMarketManagerTestResponseBody();
        return TeaModel.build(map, self);
    }

    public DiotMarketManagerTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
