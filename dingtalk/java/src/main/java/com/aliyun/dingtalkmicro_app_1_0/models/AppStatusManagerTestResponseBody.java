// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AppStatusManagerTestResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AppStatusManagerTestResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AppStatusManagerTestResponseBody self = new AppStatusManagerTestResponseBody();
        return TeaModel.build(map, self);
    }

    public AppStatusManagerTestResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
