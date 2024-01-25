// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class TransferEventResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TransferEventResponseBody body;

    public static TransferEventResponse build(java.util.Map<String, ?> map) throws Exception {
        TransferEventResponse self = new TransferEventResponse();
        return TeaModel.build(map, self);
    }

    public TransferEventResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TransferEventResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TransferEventResponse setBody(TransferEventResponseBody body) {
        this.body = body;
        return this;
    }
    public TransferEventResponseBody getBody() {
        return this.body;
    }

}
