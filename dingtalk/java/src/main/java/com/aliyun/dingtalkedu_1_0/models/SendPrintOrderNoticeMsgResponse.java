// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class SendPrintOrderNoticeMsgResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SendPrintOrderNoticeMsgResponseBody body;

    public static SendPrintOrderNoticeMsgResponse build(java.util.Map<String, ?> map) throws Exception {
        SendPrintOrderNoticeMsgResponse self = new SendPrintOrderNoticeMsgResponse();
        return TeaModel.build(map, self);
    }

    public SendPrintOrderNoticeMsgResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendPrintOrderNoticeMsgResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendPrintOrderNoticeMsgResponse setBody(SendPrintOrderNoticeMsgResponseBody body) {
        this.body = body;
        return this;
    }
    public SendPrintOrderNoticeMsgResponseBody getBody() {
        return this.body;
    }

}
