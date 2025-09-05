// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeliverNoticeCardResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeliverNoticeCardResponseBody body;

    public static DeliverNoticeCardResponse build(java.util.Map<String, ?> map) throws Exception {
        DeliverNoticeCardResponse self = new DeliverNoticeCardResponse();
        return TeaModel.build(map, self);
    }

    public DeliverNoticeCardResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeliverNoticeCardResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeliverNoticeCardResponse setBody(DeliverNoticeCardResponseBody body) {
        this.body = body;
        return this;
    }
    public DeliverNoticeCardResponseBody getBody() {
        return this.body;
    }

}
