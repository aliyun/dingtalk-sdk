// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontent_1_0.models;

import com.aliyun.tea.*;

public class GetFeedResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public GetFeedResponse setBody(GetFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public GetFeedResponseBody getBody() {
        return this.body;
    }

}
