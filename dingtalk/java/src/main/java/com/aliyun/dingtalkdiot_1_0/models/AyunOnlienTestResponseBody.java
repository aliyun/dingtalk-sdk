// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class AyunOnlienTestResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AyunOnlienTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AyunOnlienTestResponseBody self = new AyunOnlienTestResponseBody();
        return TeaModel.build(map, self);
    }

    public AyunOnlienTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
