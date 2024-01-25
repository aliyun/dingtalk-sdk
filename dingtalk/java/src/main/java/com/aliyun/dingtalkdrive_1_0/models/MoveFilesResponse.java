// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdrive_1_0.models;

import com.aliyun.tea.*;

public class MoveFilesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public MoveFilesResponseBody body;

    public static MoveFilesResponse build(java.util.Map<String, ?> map) throws Exception {
        MoveFilesResponse self = new MoveFilesResponse();
        return TeaModel.build(map, self);
    }

    public MoveFilesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public MoveFilesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public MoveFilesResponse setBody(MoveFilesResponseBody body) {
        this.body = body;
        return this;
    }
    public MoveFilesResponseBody getBody() {
        return this.body;
    }

}
