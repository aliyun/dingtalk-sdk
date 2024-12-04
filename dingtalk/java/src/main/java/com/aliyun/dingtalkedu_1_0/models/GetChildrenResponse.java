// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetChildrenResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetChildrenResponseBody body;

    public static GetChildrenResponse build(java.util.Map<String, ?> map) throws Exception {
        GetChildrenResponse self = new GetChildrenResponse();
        return TeaModel.build(map, self);
    }

    public GetChildrenResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetChildrenResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetChildrenResponse setBody(GetChildrenResponseBody body) {
        this.body = body;
        return this;
    }
    public GetChildrenResponseBody getBody() {
        return this.body;
    }

}
