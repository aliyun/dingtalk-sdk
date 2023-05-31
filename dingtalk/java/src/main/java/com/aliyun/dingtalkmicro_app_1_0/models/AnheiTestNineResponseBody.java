// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiTestNineResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AnheiTestNineResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnheiTestNineResponseBody self = new AnheiTestNineResponseBody();
        return TeaModel.build(map, self);
    }

    public AnheiTestNineResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
