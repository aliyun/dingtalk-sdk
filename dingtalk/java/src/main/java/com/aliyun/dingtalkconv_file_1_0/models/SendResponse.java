// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendResponseBody body;

    public static SendResponse build(java.util.Map<String, ?> map) throws Exception {
        SendResponse self = new SendResponse();
        return TeaModel.build(map, self);
    }

    public SendResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendResponse setBody(SendResponseBody body) {
        this.body = body;
        return this;
    }
    public SendResponseBody getBody() {
        return this.body;
    }

}
