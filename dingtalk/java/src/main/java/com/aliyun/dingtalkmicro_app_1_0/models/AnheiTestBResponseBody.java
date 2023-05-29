// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class AnheiTestBResponseBody extends TeaModel {
    @NameInMap("requestId")
    public String requestId;

    public static AnheiTestBResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AnheiTestBResponseBody self = new AnheiTestBResponseBody();
        return TeaModel.build(map, self);
    }

    public AnheiTestBResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
