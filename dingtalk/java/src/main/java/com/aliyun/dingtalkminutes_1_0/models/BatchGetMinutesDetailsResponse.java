// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class BatchGetMinutesDetailsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchGetMinutesDetailsResponseBody body;

    public static BatchGetMinutesDetailsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchGetMinutesDetailsResponse self = new BatchGetMinutesDetailsResponse();
        return TeaModel.build(map, self);
    }

    public BatchGetMinutesDetailsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchGetMinutesDetailsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchGetMinutesDetailsResponse setBody(BatchGetMinutesDetailsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchGetMinutesDetailsResponseBody getBody() {
        return this.body;
    }

}
