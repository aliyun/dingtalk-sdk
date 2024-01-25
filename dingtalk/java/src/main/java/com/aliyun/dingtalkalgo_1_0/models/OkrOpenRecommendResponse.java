// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkalgo_1_0.models;

import com.aliyun.tea.*;

public class OkrOpenRecommendResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public OkrOpenRecommendResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public OkrOpenRecommendResponse setBody(OkrOpenRecommendResponseBody body) {
        this.body = body;
        return this;
    }
    public OkrOpenRecommendResponseBody getBody() {
        return this.body;
    }

}
