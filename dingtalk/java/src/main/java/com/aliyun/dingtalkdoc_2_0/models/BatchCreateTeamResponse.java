// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchCreateTeamResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public BatchCreateTeamResponseBody body;

    public static BatchCreateTeamResponse build(java.util.Map<String, ?> map) throws Exception {
        BatchCreateTeamResponse self = new BatchCreateTeamResponse();
        return TeaModel.build(map, self);
    }

    public BatchCreateTeamResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public BatchCreateTeamResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public BatchCreateTeamResponse setBody(BatchCreateTeamResponseBody body) {
        this.body = body;
        return this;
    }
    public BatchCreateTeamResponseBody getBody() {
        return this.body;
    }

}
