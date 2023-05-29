// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AyunTestResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AyunTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AyunTestResponseBody self = new AyunTestResponseBody();
        return TeaModel.build(map, self);
    }

    public AyunTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
