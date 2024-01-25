// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class GetResidentInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetResidentInfoResponseBody body;

    public static GetResidentInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetResidentInfoResponse self = new GetResidentInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetResidentInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetResidentInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetResidentInfoResponse setBody(GetResidentInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetResidentInfoResponseBody getBody() {
        return this.body;
    }

}
