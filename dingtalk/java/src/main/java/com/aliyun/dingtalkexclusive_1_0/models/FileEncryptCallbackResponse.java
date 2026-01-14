// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileEncryptCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FileEncryptCallbackResponseBody body;

    public static FileEncryptCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        FileEncryptCallbackResponse self = new FileEncryptCallbackResponse();
        return TeaModel.build(map, self);
    }

    public FileEncryptCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileEncryptCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileEncryptCallbackResponse setBody(FileEncryptCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public FileEncryptCallbackResponseBody getBody() {
        return this.body;
    }

}
