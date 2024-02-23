// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectEntityResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncProjectEntityResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectEntityResponseBody self = new SyncProjectEntityResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncProjectEntityResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
