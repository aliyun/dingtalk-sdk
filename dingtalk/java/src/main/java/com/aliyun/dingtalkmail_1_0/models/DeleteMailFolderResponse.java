// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class DeleteMailFolderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteMailFolderResponseBody body;

    public static DeleteMailFolderResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteMailFolderResponse self = new DeleteMailFolderResponse();
        return TeaModel.build(map, self);
    }

    public DeleteMailFolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteMailFolderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteMailFolderResponse setBody(DeleteMailFolderResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteMailFolderResponseBody getBody() {
        return this.body;
    }

}
