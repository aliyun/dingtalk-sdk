// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class SendMsgByTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendMsgByTaskResponseBody body;

    public static SendMsgByTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        SendMsgByTaskResponse self = new SendMsgByTaskResponse();
        return TeaModel.build(map, self);
    }

    public SendMsgByTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendMsgByTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendMsgByTaskResponse setBody(SendMsgByTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public SendMsgByTaskResponseBody getBody() {
        return this.body;
    }

}
