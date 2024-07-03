// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class CloseDataDeliverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CloseDataDeliverResponseBody body;

    public static CloseDataDeliverResponse build(java.util.Map<String, ?> map) throws Exception {
        CloseDataDeliverResponse self = new CloseDataDeliverResponse();
        return TeaModel.build(map, self);
    }

    public CloseDataDeliverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CloseDataDeliverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CloseDataDeliverResponse setBody(CloseDataDeliverResponseBody body) {
        this.body = body;
        return this;
    }
    public CloseDataDeliverResponseBody getBody() {
        return this.body;
    }

}
