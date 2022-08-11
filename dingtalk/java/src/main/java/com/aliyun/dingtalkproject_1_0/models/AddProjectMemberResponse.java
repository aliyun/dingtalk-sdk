// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class AddProjectMemberResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public AddProjectMemberResponseBody body;

    public static AddProjectMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        AddProjectMemberResponse self = new AddProjectMemberResponse();
        return TeaModel.build(map, self);
    }

    public AddProjectMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddProjectMemberResponse setBody(AddProjectMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public AddProjectMemberResponseBody getBody() {
        return this.body;
    }

}
