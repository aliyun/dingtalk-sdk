// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class BatchQueryRolesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchQueryRolesResponseBody body;

    public static BatchQueryRolesResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryRolesResponse self = new BatchQueryRolesResponse();
        return TeaModel.build(map, self);
    }

    public BatchQueryRolesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchQueryRolesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchQueryRolesResponse setBody(BatchQueryRolesResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchQueryRolesResponseBody getBody() {
        return this.body;
    }

}
