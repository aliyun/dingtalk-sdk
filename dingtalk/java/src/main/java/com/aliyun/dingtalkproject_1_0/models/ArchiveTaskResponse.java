// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class ArchiveTaskResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ArchiveTaskResponseBody body;

    public static ArchiveTaskResponse build(java.util.Map<String, ?> map) throws Exception {
        ArchiveTaskResponse self = new ArchiveTaskResponse();
        return TeaModel.build(map, self);
    }

    public ArchiveTaskResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ArchiveTaskResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ArchiveTaskResponse setBody(ArchiveTaskResponseBody body) {
        this.body = body;
        return this;
    }
    public ArchiveTaskResponseBody getBody() {
        return this.body;
    }

}
