// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_integration_1_0.models;

import com.aliyun.tea.*;

public class CreateEventGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public java.util.Map<String, ?> body;

    public static CreateEventGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateEventGroupResponse self = new CreateEventGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateEventGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateEventGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateEventGroupResponse setBody(java.util.Map<String, ?> body) {
        this.body = body;
        return this;
    }
    public java.util.Map<String, ?> getBody() {
        return this.body;
    }

}
