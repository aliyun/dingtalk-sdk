// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdiot_1_0.models;

import com.aliyun.tea.*;

public class DiotMarketManagerTestResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DiotMarketManagerTestResponseBody body;

    public static DiotMarketManagerTestResponse build(java.util.Map<String, ?> map) throws Exception {
        DiotMarketManagerTestResponse self = new DiotMarketManagerTestResponse();
        return TeaModel.build(map, self);
    }

    public DiotMarketManagerTestResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DiotMarketManagerTestResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DiotMarketManagerTestResponse setBody(DiotMarketManagerTestResponseBody body) {
        this.body = body;
        return this;
    }
    public DiotMarketManagerTestResponseBody getBody() {
        return this.body;
    }

}
