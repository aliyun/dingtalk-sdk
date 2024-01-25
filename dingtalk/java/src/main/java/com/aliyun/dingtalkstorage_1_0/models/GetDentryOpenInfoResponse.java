// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryOpenInfoResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDentryOpenInfoResponseBody body;

    public static GetDentryOpenInfoResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDentryOpenInfoResponse self = new GetDentryOpenInfoResponse();
        return TeaModel.build(map, self);
    }

    public GetDentryOpenInfoResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDentryOpenInfoResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDentryOpenInfoResponse setBody(GetDentryOpenInfoResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDentryOpenInfoResponseBody getBody() {
        return this.body;
    }

}
