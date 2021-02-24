// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class RoaDuheYsTestResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    public static RoaDuheYsTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RoaDuheYsTestResponseBody self = new RoaDuheYsTestResponseBody();
        return TeaModel.build(map, self);
    }

    public RoaDuheYsTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
