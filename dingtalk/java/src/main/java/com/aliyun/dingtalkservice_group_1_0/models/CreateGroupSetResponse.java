// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupSetResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateGroupSetResponseBody body;

    public static CreateGroupSetResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupSetResponse self = new CreateGroupSetResponse();
        return TeaModel.build(map, self);
    }

    public CreateGroupSetResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateGroupSetResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateGroupSetResponse setBody(CreateGroupSetResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateGroupSetResponseBody getBody() {
        return this.body;
    }

}
