// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class BatchAddContactsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchAddContactsResponseBody body;

    public static BatchAddContactsResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchAddContactsResponse self = new BatchAddContactsResponse();
        return TeaModel.build(map, self);
    }

    public BatchAddContactsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchAddContactsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchAddContactsResponse setBody(BatchAddContactsResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchAddContactsResponseBody getBody() {
        return this.body;
    }

}
