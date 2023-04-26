// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class BoundTemplateToTeamResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public BoundTemplateToTeamResponseBody body;

    public static BoundTemplateToTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        BoundTemplateToTeamResponse self = new BoundTemplateToTeamResponse();
        return TeaModel.build(map, self);
    }

    public BoundTemplateToTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BoundTemplateToTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BoundTemplateToTeamResponse setBody(BoundTemplateToTeamResponseBody body) {
        this.body = body;
        return this;
    }
    public BoundTemplateToTeamResponseBody getBody() {
        return this.body;
    }

}
