// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrbrain_1_0.models;

import com.aliyun.tea.*;

public class SyncDataResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncDataResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncDataResponseBody self = new SyncDataResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncDataResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
