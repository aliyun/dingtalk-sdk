// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetDataDeliverResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetDataDeliverResponseBody body;

    public static GetDataDeliverResponse build(java.util.Map<String, ?> map) throws Exception {
        GetDataDeliverResponse self = new GetDataDeliverResponse();
        return TeaModel.build(map, self);
    }

    public GetDataDeliverResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetDataDeliverResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetDataDeliverResponse setBody(GetDataDeliverResponseBody body) {
        this.body = body;
        return this;
    }
    public GetDataDeliverResponseBody getBody() {
        return this.body;
    }

}
