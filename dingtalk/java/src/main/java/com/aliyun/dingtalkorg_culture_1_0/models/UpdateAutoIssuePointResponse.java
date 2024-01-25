// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class UpdateAutoIssuePointResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public UpdateAutoIssuePointResponseBody body;

    public static UpdateAutoIssuePointResponse build(java.util.Map<String, ?> map) throws Exception {
        UpdateAutoIssuePointResponse self = new UpdateAutoIssuePointResponse();
        return TeaModel.build(map, self);
    }

    public UpdateAutoIssuePointResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UpdateAutoIssuePointResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public UpdateAutoIssuePointResponse setBody(UpdateAutoIssuePointResponseBody body) {
        this.body = body;
        return this;
    }
    public UpdateAutoIssuePointResponseBody getBody() {
        return this.body;
    }

}
