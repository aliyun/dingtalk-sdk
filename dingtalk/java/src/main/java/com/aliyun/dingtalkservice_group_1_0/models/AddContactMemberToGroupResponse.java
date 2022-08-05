// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class AddContactMemberToGroupResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddContactMemberToGroupResponseBody body;

    public static AddContactMemberToGroupResponse build(java.util.Map<String, ?> map) throws Exception {
        AddContactMemberToGroupResponse self = new AddContactMemberToGroupResponse();
        return TeaModel.build(map, self);
    }

    public AddContactMemberToGroupResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddContactMemberToGroupResponse setBody(AddContactMemberToGroupResponseBody body) {
        this.body = body;
        return this;
    }
    public AddContactMemberToGroupResponseBody getBody() {
        return this.body;
    }

}
