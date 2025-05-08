// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class BatchUpdateExternalTitleResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchUpdateExternalTitleResponseBody body;

    public static BatchUpdateExternalTitleResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchUpdateExternalTitleResponse self = new BatchUpdateExternalTitleResponse();
        return TeaModel.build(map, self);
    }

    public BatchUpdateExternalTitleResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchUpdateExternalTitleResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchUpdateExternalTitleResponse setBody(BatchUpdateExternalTitleResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchUpdateExternalTitleResponseBody getBody() {
        return this.body;
    }

}
