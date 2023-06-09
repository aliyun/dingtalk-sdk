// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetOutGroupsByPageResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public GetOutGroupsByPageResponseBody body;

    public static GetOutGroupsByPageResponse build(java.util.Map<String, ?> map) throws Exception {
        GetOutGroupsByPageResponse self = new GetOutGroupsByPageResponse();
        return TeaModel.build(map, self);
    }

    public GetOutGroupsByPageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetOutGroupsByPageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetOutGroupsByPageResponse setBody(GetOutGroupsByPageResponseBody body) {
        this.body = body;
        return this;
    }
    public GetOutGroupsByPageResponseBody getBody() {
        return this.body;
    }

}
