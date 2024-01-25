// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateSecondaryManagementGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateSecondaryManagementGroupResponseBody body;

    public static CreateSecondaryManagementGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateSecondaryManagementGroupResponse self = new CreateSecondaryManagementGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateSecondaryManagementGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateSecondaryManagementGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateSecondaryManagementGroupResponse setBody(CreateSecondaryManagementGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSecondaryManagementGroupResponseBody getBody() {
        return this.body;
    }

}
