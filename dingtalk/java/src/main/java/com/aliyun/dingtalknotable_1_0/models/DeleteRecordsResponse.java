// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public DeleteRecordsResponseBody body;

    public static DeleteRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecordsResponse self = new DeleteRecordsResponse();
        return TeaModel.build(map, self);
    }

    public DeleteRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteRecordsResponse setBody(DeleteRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public DeleteRecordsResponseBody getBody() {
        return this.body;
    }

}
