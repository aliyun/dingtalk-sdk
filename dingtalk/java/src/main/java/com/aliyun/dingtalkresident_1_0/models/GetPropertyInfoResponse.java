// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetPropertyInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetPropertyInfoResponseBody body;

    public static GetPropertyInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetPropertyInfoResponse self = new GetPropertyInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetPropertyInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetPropertyInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetPropertyInfoResponse setBody(GetPropertyInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetPropertyInfoResponseBody getBody() {
        return this.body;
    }

}
