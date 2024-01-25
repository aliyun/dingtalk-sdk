// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetDentryResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDentryResponseBody body;

    public static GetDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDentryResponse self = new GetDentryResponse();
        return TeaModel.build(map, self);
    }

    public GetDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDentryResponse setBody(GetDentryResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDentryResponseBody getBody() {
        return this.body;
    }

}
