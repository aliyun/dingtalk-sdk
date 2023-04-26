// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class InsertSectionConfigResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public InsertSectionConfigResponseBody body;

    public static InsertSectionConfigResponse build(java.util.Map<String, ?> map) throws Exception {
        InsertSectionConfigResponse self = new InsertSectionConfigResponse();
        return TeaModel.build(map, self);
    }

    public InsertSectionConfigResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public InsertSectionConfigResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public InsertSectionConfigResponse setBody(InsertSectionConfigResponseBody body) {
        this.body = body;
        return this;
    }
    public InsertSectionConfigResponseBody getBody() {
        return this.body;
    }

}
