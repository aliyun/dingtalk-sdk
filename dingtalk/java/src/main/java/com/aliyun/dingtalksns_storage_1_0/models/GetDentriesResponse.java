// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetDentriesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDentriesResponseBody body;

    public static GetDentriesResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDentriesResponse self = new GetDentriesResponse();
        return TeaModel.build(map, self);
    }

    public GetDentriesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDentriesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDentriesResponse setBody(GetDentriesResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDentriesResponseBody getBody() {
        return this.body;
    }

}
