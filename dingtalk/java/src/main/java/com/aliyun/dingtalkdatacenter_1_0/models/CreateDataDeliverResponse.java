// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CreateDataDeliverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateDataDeliverResponseBody body;

    public static CreateDataDeliverResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDataDeliverResponse self = new CreateDataDeliverResponse();
        return TeaModel.build(map, self);
    }

    public CreateDataDeliverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDataDeliverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDataDeliverResponse setBody(CreateDataDeliverResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateDataDeliverResponseBody getBody() {
        return this.body;
    }

}
