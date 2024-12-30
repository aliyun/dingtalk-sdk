// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ArchiveProcessInstanceResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ArchiveProcessInstanceResponseBody body;

    public static ArchiveProcessInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        ArchiveProcessInstanceResponse self = new ArchiveProcessInstanceResponse();
        return TeaModel.build(map, self);
    }

    public ArchiveProcessInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ArchiveProcessInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ArchiveProcessInstanceResponse setBody(ArchiveProcessInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public ArchiveProcessInstanceResponseBody getBody() {
        return this.body;
    }

}
