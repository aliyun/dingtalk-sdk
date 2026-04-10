// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class FileDecryptCallbackResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FileDecryptCallbackResponseBody body;

    public static FileDecryptCallbackResponse build(java.util.Map<String, ?> map) throws Exception {
        FileDecryptCallbackResponse self = new FileDecryptCallbackResponse();
        return TeaModel.build(map, self);
    }

    public FileDecryptCallbackResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FileDecryptCallbackResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FileDecryptCallbackResponse setBody(FileDecryptCallbackResponseBody body) {
        this.body = body;
        return this;
    }
    public FileDecryptCallbackResponseBody getBody() {
        return this.body;
    }

}
