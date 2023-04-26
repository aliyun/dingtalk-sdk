// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateDentryResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public DentryVO body;

    public static CreateDentryResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateDentryResponse self = new CreateDentryResponse();
        return TeaModel.build(map, self);
    }

    public CreateDentryResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateDentryResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateDentryResponse setBody(DentryVO body) {
        this.body = body;
        return this;
    }
    public DentryVO getBody() {
        return this.body;
    }

}
