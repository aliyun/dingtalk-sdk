// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class ListTeamMembersResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public ListTeamMembersResponseBody body;

    public static ListTeamMembersResponse build(java.util.Map<String, ?> map) throws Exception {
        ListTeamMembersResponse self = new ListTeamMembersResponse();
        return TeaModel.build(map, self);
    }

    public ListTeamMembersResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListTeamMembersResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListTeamMembersResponse setBody(ListTeamMembersResponseBody body) {
        this.body = body;
        return this;
    }
    public ListTeamMembersResponseBody getBody() {
        return this.body;
    }

}
