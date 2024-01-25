// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class CreateTeamResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TeamVO body;

    public static CreateTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        CreateTeamResponse self = new CreateTeamResponse();
        return TeaModel.build(map, self);
    }

    public CreateTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CreateTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CreateTeamResponse setBody(TeamVO body) {
        this.body = body;
        return this;
    }
    public TeamVO getBody() {
        return this.body;
    }

}
