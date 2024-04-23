// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class UpdateRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateRecordsResponseBody body;

    public static UpdateRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateRecordsResponse self = new UpdateRecordsResponse();
        return TeaModel.build(map, self);
    }

    public UpdateRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateRecordsResponse setBody(UpdateRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateRecordsResponseBody getBody() {
        return this.body;
    }

}
