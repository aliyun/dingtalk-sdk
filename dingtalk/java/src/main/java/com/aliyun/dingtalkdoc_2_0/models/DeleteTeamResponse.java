// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DeleteTeamResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TeamVO body;

    public static DeleteTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        DeleteTeamResponse self = new DeleteTeamResponse();
        return TeaModel.build(map, self);
    }

    public DeleteTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public DeleteTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public DeleteTeamResponse setBody(TeamVO body) {
        this.body = body;
        return this;
    }
    public TeamVO getBody() {
        return this.body;
    }

}
