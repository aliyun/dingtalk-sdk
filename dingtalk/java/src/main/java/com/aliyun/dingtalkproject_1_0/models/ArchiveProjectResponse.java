// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class ArchiveProjectResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ArchiveProjectResponseBody body;

    public static ArchiveProjectResponse build(java.util.Map<String, ?> map) throws Exception {
        ArchiveProjectResponse self = new ArchiveProjectResponse();
        return TeaModel.build(map, self);
    }

    public ArchiveProjectResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ArchiveProjectResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ArchiveProjectResponse setBody(ArchiveProjectResponseBody body) {
        this.body = body;
        return this;
    }
    public ArchiveProjectResponseBody getBody() {
        return this.body;
    }

}
