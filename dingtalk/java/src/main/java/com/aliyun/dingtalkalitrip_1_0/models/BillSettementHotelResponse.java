// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementHotelResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public BillSettementHotelResponseBody body;

    public static BillSettementHotelResponse build(java.util.Map<String, ?> map) throws Exception {
        BillSettementHotelResponse self = new BillSettementHotelResponse();
        return TeaModel.build(map, self);
    }

    public BillSettementHotelResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BillSettementHotelResponse setBody(BillSettementHotelResponseBody body) {
        this.body = body;
        return this;
    }
    public BillSettementHotelResponseBody getBody() {
        return this.body;
    }

}
