// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class CreateCollectionOrderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateCollectionOrderResponseBody body;

    public static CreateCollectionOrderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateCollectionOrderResponse self = new CreateCollectionOrderResponse();
        return TeaModel.build(map, self);
    }

    public CreateCollectionOrderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateCollectionOrderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateCollectionOrderResponse setBody(CreateCollectionOrderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateCollectionOrderResponseBody getBody() {
        return this.body;
    }

}
