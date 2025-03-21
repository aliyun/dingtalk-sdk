// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class CreateMailFolderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateMailFolderResponseBody body;

    public static CreateMailFolderResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateMailFolderResponse self = new CreateMailFolderResponse();
        return TeaModel.build(map, self);
    }

    public CreateMailFolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateMailFolderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateMailFolderResponse setBody(CreateMailFolderResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateMailFolderResponseBody getBody() {
        return this.body;
    }

}
