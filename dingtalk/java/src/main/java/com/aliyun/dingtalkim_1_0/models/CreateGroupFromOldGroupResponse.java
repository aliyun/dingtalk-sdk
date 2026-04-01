// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class CreateGroupFromOldGroupResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public CreateGroupFromOldGroupResponseBody body;

    public static CreateGroupFromOldGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateGroupFromOldGroupResponse self = new CreateGroupFromOldGroupResponse();
        return TeaModel.build(map, self);
    }

    public CreateGroupFromOldGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateGroupFromOldGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateGroupFromOldGroupResponse setBody(CreateGroupFromOldGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public CreateGroupFromOldGroupResponseBody getBody() {
        return this.body;
    }

}
