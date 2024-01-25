// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ReleaseCommodityResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ReleaseCommodityResponseBody body;

    public static ReleaseCommodityResponse build(java.util.Map<String, ?> map) throws Exception {
        ReleaseCommodityResponse self = new ReleaseCommodityResponse();
        return TeaModel.build(map, self);
    }

    public ReleaseCommodityResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ReleaseCommodityResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ReleaseCommodityResponse setBody(ReleaseCommodityResponseBody body) {
        this.body = body;
        return this;
    }
    public ReleaseCommodityResponseBody getBody() {
        return this.body;
    }

}
