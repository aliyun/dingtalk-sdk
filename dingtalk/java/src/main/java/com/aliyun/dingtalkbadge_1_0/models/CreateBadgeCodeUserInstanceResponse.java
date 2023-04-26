// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbadge_1_0.models;

import com.aliyun.tea.*;

public class CreateBadgeCodeUserInstanceResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateBadgeCodeUserInstanceResponseBody body;

    public static CreateBadgeCodeUserInstanceResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateBadgeCodeUserInstanceResponse self = new CreateBadgeCodeUserInstanceResponse();
        return TeaModel.build(map, self);
    }

    public CreateBadgeCodeUserInstanceResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateBadgeCodeUserInstanceResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateBadgeCodeUserInstanceResponse setBody(CreateBadgeCodeUserInstanceResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateBadgeCodeUserInstanceResponseBody getBody() {
        return this.body;
    }

}
