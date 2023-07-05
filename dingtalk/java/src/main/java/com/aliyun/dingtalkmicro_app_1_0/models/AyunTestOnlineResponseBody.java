// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AyunTestOnlineResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AyunTestOnlineResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AyunTestOnlineResponseBody self = new AyunTestOnlineResponseBody();
        return TeaModel.build(map, self);
    }

    public AyunTestOnlineResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
