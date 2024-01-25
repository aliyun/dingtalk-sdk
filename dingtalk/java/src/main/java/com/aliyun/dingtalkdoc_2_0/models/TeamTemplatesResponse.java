// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class TeamTemplatesResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TeamTemplatesResponseBody body;

    public static TeamTemplatesResponse build(java.util.Map<String, ?> map) throws Exception {
        TeamTemplatesResponse self = new TeamTemplatesResponse();
        return TeaModel.build(map, self);
    }

    public TeamTemplatesResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TeamTemplatesResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TeamTemplatesResponse setBody(TeamTemplatesResponseBody body) {
        this.body = body;
        return this;
    }
    public TeamTemplatesResponseBody getBody() {
        return this.body;
    }

}
