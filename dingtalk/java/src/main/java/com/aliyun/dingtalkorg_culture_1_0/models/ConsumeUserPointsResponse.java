// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class ConsumeUserPointsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ConsumeUserPointsResponseBody body;

    public static ConsumeUserPointsResponse build(java.util.Map<String, ?> map) throws Exception {
        ConsumeUserPointsResponse self = new ConsumeUserPointsResponse();
        return TeaModel.build(map, self);
    }

    public ConsumeUserPointsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ConsumeUserPointsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ConsumeUserPointsResponse setBody(ConsumeUserPointsResponseBody body) {
        this.body = body;
        return this;
    }
    public ConsumeUserPointsResponseBody getBody() {
        return this.body;
    }

}
