// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class GetDefineResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDefineResponseBody body;

    public static GetDefineResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDefineResponse self = new GetDefineResponse();
        return TeaModel.build(map, self);
    }

    public GetDefineResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDefineResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDefineResponse setBody(GetDefineResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDefineResponseBody getBody() {
        return this.body;
    }

}
