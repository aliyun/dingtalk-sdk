// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetFeedResponseBody body;

    public static GetFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        GetFeedResponse self = new GetFeedResponse();
        return TeaModel.build(map, self);
    }

    public GetFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetFeedResponse setBody(GetFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFeedResponseBody getBody() {
        return this.body;
    }

}
