// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiPResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AnheiPResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnheiPResponseBody self = new AnheiPResponseBody();
        return TeaModel.build(map, self);
    }

    public AnheiPResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
