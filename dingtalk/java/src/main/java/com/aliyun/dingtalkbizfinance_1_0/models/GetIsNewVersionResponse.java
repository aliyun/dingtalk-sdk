// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_1_0.models;

import com.aliyun.tea.*;

public class GetIsNewVersionResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetIsNewVersionResponseBody body;

    public static GetIsNewVersionResponse build(java.util.Map<String, ?> map) throws Exception {
        GetIsNewVersionResponse self = new GetIsNewVersionResponse();
        return TeaModel.build(map, self);
    }

    public GetIsNewVersionResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetIsNewVersionResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetIsNewVersionResponse setBody(GetIsNewVersionResponseBody body) {
        this.body = body;
        return this;
    }
    public GetIsNewVersionResponseBody getBody() {
        return this.body;
    }

}
