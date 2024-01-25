// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMarketManagerResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DiotMarketManagerResponseBody body;

    public static DiotMarketManagerResponse build(java.util.Map<String, ?> map) throws Exception {
        DiotMarketManagerResponse self = new DiotMarketManagerResponse();
        return TeaModel.build(map, self);
    }

    public DiotMarketManagerResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DiotMarketManagerResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DiotMarketManagerResponse setBody(DiotMarketManagerResponseBody body) {
        this.body = body;
        return this;
    }
    public DiotMarketManagerResponseBody getBody() {
        return this.body;
    }

}
