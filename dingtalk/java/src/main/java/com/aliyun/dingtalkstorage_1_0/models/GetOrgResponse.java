// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetOrgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetOrgResponseBody body;

    public static GetOrgResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOrgResponse self = new GetOrgResponse();
        return TeaModel.build(map, self);
    }

    public GetOrgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOrgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOrgResponse setBody(GetOrgResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOrgResponseBody getBody() {
        return this.body;
    }

}
