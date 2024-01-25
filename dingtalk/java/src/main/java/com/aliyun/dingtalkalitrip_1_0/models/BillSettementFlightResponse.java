// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalitrip_1_0.models;

import com.aliyun.tea.*;

public class BillSettementFlightResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BillSettementFlightResponseBody body;

    public static BillSettementFlightResponse build(java.util.Map<String, ?> map) throws Exception {
        BillSettementFlightResponse self = new BillSettementFlightResponse();
        return TeaModel.build(map, self);
    }

    public BillSettementFlightResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BillSettementFlightResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BillSettementFlightResponse setBody(BillSettementFlightResponseBody body) {
        this.body = body;
        return this;
    }
    public BillSettementFlightResponseBody getBody() {
        return this.body;
    }

}
