// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class RecordActionPointResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public RecordActionPointResponseBody body;

    public static RecordActionPointResponse build(java.util.Map<String, ?> map) throws Exception {
        RecordActionPointResponse self = new RecordActionPointResponse();
        return TeaModel.build(map, self);
    }

    public RecordActionPointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RecordActionPointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RecordActionPointResponse setBody(RecordActionPointResponseBody body) {
        this.body = body;
        return this;
    }
    public RecordActionPointResponseBody getBody() {
        return this.body;
    }

}
