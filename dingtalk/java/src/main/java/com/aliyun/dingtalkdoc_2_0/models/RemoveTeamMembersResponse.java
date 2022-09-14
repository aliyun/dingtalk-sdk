// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public RemoveTeamMembersResponseBody body;

    public static RemoveTeamMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        RemoveTeamMembersResponse self = new RemoveTeamMembersResponse();
        return TeaModel.build(map, self);
    }

    public RemoveTeamMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public RemoveTeamMembersResponse setBody(RemoveTeamMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveTeamMembersResponseBody getBody() {
        return this.body;
    }

}
