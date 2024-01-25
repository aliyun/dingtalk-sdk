// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class RemoveTeamMembersResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public RemoveTeamMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public RemoveTeamMembersResponse setBody(RemoveTeamMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public RemoveTeamMembersResponseBody getBody() {
        return this.body;
    }

}
