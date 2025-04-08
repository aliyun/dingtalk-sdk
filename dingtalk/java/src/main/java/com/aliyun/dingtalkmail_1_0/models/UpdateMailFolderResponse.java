// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class UpdateMailFolderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateMailFolderResponseBody body;

    public static UpdateMailFolderResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateMailFolderResponse self = new UpdateMailFolderResponse();
        return TeaModel.build(map, self);
    }

    public UpdateMailFolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateMailFolderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateMailFolderResponse setBody(UpdateMailFolderResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateMailFolderResponseBody getBody() {
        return this.body;
    }

}
