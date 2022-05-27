// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripOrderResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("requestId")
    public String requestId;

    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static SyncTripOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncTripOrderResponseBody self = new SyncTripOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncTripOrderResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SyncTripOrderResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
