// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementCarResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BillSettementCarResponseBody body;

    public static BillSettementCarResponse build(java.util.Map<String, ?> map) throws Exception {
        BillSettementCarResponse self = new BillSettementCarResponse();
        return TeaModel.build(map, self);
    }

    public BillSettementCarResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BillSettementCarResponse setBody(BillSettementCarResponseBody body) {
        this.body = body;
        return this;
    }
    public BillSettementCarResponseBody getBody() {
        return this.body;
    }

}
