// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class ListTeamResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public ListTeamResponseBody body;

    public static ListTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        ListTeamResponse self = new ListTeamResponse();
        return TeaModel.build(map, self);
    }

    public ListTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListTeamResponse setBody(ListTeamResponseBody body) {
        this.body = body;
        return this;
    }
    public ListTeamResponseBody getBody() {
        return this.body;
    }

}
