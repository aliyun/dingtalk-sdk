// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class CreateSecondaryManagementGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public CreateSecondaryManagementGroupResponse setBody(CreateSecondaryManagementGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateSecondaryManagementGroupResponseBody getBody() {
        return this.body;
    }

}
