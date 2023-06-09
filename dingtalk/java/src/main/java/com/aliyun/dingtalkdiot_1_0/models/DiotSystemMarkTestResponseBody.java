// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotSystemMarkTestResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static DiotSystemMarkTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DiotSystemMarkTestResponseBody self = new DiotSystemMarkTestResponseBody();
        return TeaModel.build(map, self);
    }

    public DiotSystemMarkTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
