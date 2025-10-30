// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeliverOneFeedResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeliverOneFeedResponseBody body;

    public static DeliverOneFeedResponse build(java.util.Map<String, ?> map) throws Exception {
        DeliverOneFeedResponse self = new DeliverOneFeedResponse();
        return TeaModel.build(map, self);
    }

    public DeliverOneFeedResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeliverOneFeedResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeliverOneFeedResponse setBody(DeliverOneFeedResponseBody body) {
        this.body = body;
        return this;
    }
    public DeliverOneFeedResponseBody getBody() {
        return this.body;
    }

}
