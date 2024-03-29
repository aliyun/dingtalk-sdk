// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdevicemng_1_0.models;

import com.aliyun.tea.*;

public class SendMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendMsgResponseBody body;

    public static SendMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendMsgResponse self = new SendMsgResponse();
        return TeaModel.build(map, self);
    }

    public SendMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendMsgResponse setBody(SendMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendMsgResponseBody getBody() {
        return this.body;
    }

}
