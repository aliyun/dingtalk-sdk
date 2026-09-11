// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUuidByIdOrUrlResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetUuidByIdOrUrlResponseBody body;

    public static GetUuidByIdOrUrlResponse build(java.util.Map<String, ?> map) throws Exception {
        GetUuidByIdOrUrlResponse self = new GetUuidByIdOrUrlResponse();
        return TeaModel.build(map, self);
    }

    public GetUuidByIdOrUrlResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetUuidByIdOrUrlResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetUuidByIdOrUrlResponse setBody(GetUuidByIdOrUrlResponseBody body) {
        this.body = body;
        return this;
    }
    public GetUuidByIdOrUrlResponseBody getBody() {
        return this.body;
    }

}
