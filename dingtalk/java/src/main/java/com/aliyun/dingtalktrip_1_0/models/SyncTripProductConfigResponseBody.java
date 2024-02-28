// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncTripProductConfigResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncTripProductConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncTripProductConfigResponseBody self = new SyncTripProductConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncTripProductConfigResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
