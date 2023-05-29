// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AppStatusManagerTestRequest extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AppStatusManagerTestRequest build(java.util.Map<String, ?> map) throws Exception {
        AppStatusManagerTestRequest self = new AppStatusManagerTestRequest();
        return TeaModel.build(map, self);
    }

    public AppStatusManagerTestRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
