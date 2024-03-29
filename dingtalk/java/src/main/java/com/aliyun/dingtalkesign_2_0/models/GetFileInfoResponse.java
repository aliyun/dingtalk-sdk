// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetFileInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFileInfoResponseBody body;

    public static GetFileInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFileInfoResponse self = new GetFileInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetFileInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFileInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFileInfoResponse setBody(GetFileInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFileInfoResponseBody getBody() {
        return this.body;
    }

}
