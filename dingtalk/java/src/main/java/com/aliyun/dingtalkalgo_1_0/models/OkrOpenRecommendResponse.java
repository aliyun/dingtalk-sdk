// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class OkrOpenRecommendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public OkrOpenRecommendResponseBody body;

    public static OkrOpenRecommendResponse build(java.util.Map<String, ?> map) throws Exception {
        OkrOpenRecommendResponse self = new OkrOpenRecommendResponse();
        return TeaModel.build(map, self);
    }

    public OkrOpenRecommendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public OkrOpenRecommendResponse setBody(OkrOpenRecommendResponseBody body) {
        this.body = body;
        return this;
    }
    public OkrOpenRecommendResponseBody getBody() {
        return this.body;
    }

}
