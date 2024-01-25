// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointAutoIssueSettingResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public QueryPointAutoIssueSettingResponseBody body;

    public static QueryPointAutoIssueSettingResponse build(java.util.Map<String, ?> map) throws Exception {
        QueryPointAutoIssueSettingResponse self = new QueryPointAutoIssueSettingResponse();
        return TeaModel.build(map, self);
    }

    public QueryPointAutoIssueSettingResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public QueryPointAutoIssueSettingResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public QueryPointAutoIssueSettingResponse setBody(QueryPointAutoIssueSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPointAutoIssueSettingResponseBody getBody() {
        return this.body;
    }

}
