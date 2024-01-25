// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcalendar_1_0.models;

import com.aliyun.tea.*;

public class CreateAclsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateAclsResponseBody body;

    public static CreateAclsResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateAclsResponse self = new CreateAclsResponse();
        return TeaModel.build(map, self);
    }

    public CreateAclsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateAclsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateAclsResponse setBody(CreateAclsResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateAclsResponseBody getBody() {
        return this.body;
    }

}
