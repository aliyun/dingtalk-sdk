// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class GetSpaceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetSpaceResponseBody body;

    public static GetSpaceResponse build(java.util.Map<String, ?> map) throws Exception {
        GetSpaceResponse self = new GetSpaceResponse();
        return TeaModel.build(map, self);
    }

    public GetSpaceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetSpaceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetSpaceResponse setBody(GetSpaceResponseBody body) {
        this.body = body;
        return this;
    }
    public GetSpaceResponseBody getBody() {
        return this.body;
    }

}
