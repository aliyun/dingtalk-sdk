// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmail_1_0.models;

import com.aliyun.tea.*;

public class MoveMailFolderResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MoveMailFolderResponseBody body;

    public static MoveMailFolderResponse build(java.util.Map<String, ?> map) throws Exception {
        MoveMailFolderResponse self = new MoveMailFolderResponse();
        return TeaModel.build(map, self);
    }

    public MoveMailFolderResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MoveMailFolderResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MoveMailFolderResponse setBody(MoveMailFolderResponseBody body) {
        this.body = body;
        return this;
    }
    public MoveMailFolderResponseBody getBody() {
        return this.body;
    }

}
