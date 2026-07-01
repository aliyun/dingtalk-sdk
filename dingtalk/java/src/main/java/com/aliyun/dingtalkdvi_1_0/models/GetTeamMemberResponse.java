// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class GetTeamMemberResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetTeamMemberResponseBody body;

    public static GetTeamMemberResponse build(java.util.Map<String, ?> map) throws Exception {
        GetTeamMemberResponse self = new GetTeamMemberResponse();
        return TeaModel.build(map, self);
    }

    public GetTeamMemberResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetTeamMemberResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetTeamMemberResponse setBody(GetTeamMemberResponseBody body) {
        this.body = body;
        return this;
    }
    public GetTeamMemberResponseBody getBody() {
        return this.body;
    }

}
