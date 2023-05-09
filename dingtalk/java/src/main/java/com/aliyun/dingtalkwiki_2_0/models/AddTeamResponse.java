// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class AddTeamResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public AddTeamResponseBody body;

    public static AddTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        AddTeamResponse self = new AddTeamResponse();
        return TeaModel.build(map, self);
    }

    public AddTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AddTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AddTeamResponse setBody(AddTeamResponseBody body) {
        this.body = body;
        return this;
    }
    public AddTeamResponseBody getBody() {
        return this.body;
    }

}
