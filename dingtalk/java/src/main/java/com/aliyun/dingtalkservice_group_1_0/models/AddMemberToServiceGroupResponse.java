// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddMemberToServiceGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddMemberToServiceGroupResponseBody body;

    public static AddMemberToServiceGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        AddMemberToServiceGroupResponse self = new AddMemberToServiceGroupResponse();
        return TeaModel.build(map, self);
    }

    public AddMemberToServiceGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddMemberToServiceGroupResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddMemberToServiceGroupResponse setBody(AddMemberToServiceGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public AddMemberToServiceGroupResponseBody getBody() {
        return this.body;
    }

}
