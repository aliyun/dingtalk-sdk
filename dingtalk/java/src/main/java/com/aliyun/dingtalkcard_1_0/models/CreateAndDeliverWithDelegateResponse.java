// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CreateAndDeliverWithDelegateResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAndDeliverWithDelegateResponseBody body;

    public static CreateAndDeliverWithDelegateResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAndDeliverWithDelegateResponse self = new CreateAndDeliverWithDelegateResponse();
        return TeaModel.build(map, self);
    }

    public CreateAndDeliverWithDelegateResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAndDeliverWithDelegateResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAndDeliverWithDelegateResponse setBody(CreateAndDeliverWithDelegateResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAndDeliverWithDelegateResponseBody getBody() {
        return this.body;
    }

}
