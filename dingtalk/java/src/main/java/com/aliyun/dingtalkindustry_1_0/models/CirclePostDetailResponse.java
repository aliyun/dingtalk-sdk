// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class CirclePostDetailResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CirclePostDetailResponseBody body;

    public static CirclePostDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        CirclePostDetailResponse self = new CirclePostDetailResponse();
        return TeaModel.build(map, self);
    }

    public CirclePostDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CirclePostDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CirclePostDetailResponse setBody(CirclePostDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public CirclePostDetailResponseBody getBody() {
        return this.body;
    }

}
