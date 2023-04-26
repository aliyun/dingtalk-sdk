// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendLinkResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public SendLinkResponseBody body;

    public static SendLinkResponse build(java.util.Map<String, ?> map) throws Exception {
        SendLinkResponse self = new SendLinkResponse();
        return TeaModel.build(map, self);
    }

    public SendLinkResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendLinkResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SendLinkResponse setBody(SendLinkResponseBody body) {
        this.body = body;
        return this;
    }
    public SendLinkResponseBody getBody() {
        return this.body;
    }

}
