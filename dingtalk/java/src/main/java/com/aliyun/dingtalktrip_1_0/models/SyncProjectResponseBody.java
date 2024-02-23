// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrip_1_0.models;

import com.aliyun.tea.*;

public class SyncProjectResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SyncProjectResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SyncProjectResponseBody self = new SyncProjectResponseBody();
        return TeaModel.build(map, self);
    }

    public SyncProjectResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
