// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateManagementGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CreateManagementGroupResponseBody body;

    public static CreateManagementGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateManagementGroupResponse self = new CreateManagementGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateManagementGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateManagementGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateManagementGroupResponse setBody(CreateManagementGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateManagementGroupResponseBody getBody() {
        return this.body;
    }

}
