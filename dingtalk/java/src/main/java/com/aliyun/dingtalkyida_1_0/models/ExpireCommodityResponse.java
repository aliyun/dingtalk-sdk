// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ExpireCommodityResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ExpireCommodityResponseBody body;

    public static ExpireCommodityResponse build(java.util.Map<String, ?> map) throws Exception {
        ExpireCommodityResponse self = new ExpireCommodityResponse();
        return TeaModel.build(map, self);
    }

    public ExpireCommodityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ExpireCommodityResponse setBody(ExpireCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public ExpireCommodityResponseBody getBody() {
        return this.body;
    }

}
