// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkorg_culture_1_0.models;

import com.aliyun.tea.*;

public class QueryPointAutoIssueSettingResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
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

    public QueryPointAutoIssueSettingResponse setBody(QueryPointAutoIssueSettingResponseBody body) {
        this.body = body;
        return this;
    }
    public QueryPointAutoIssueSettingResponseBody getBody() {
        return this.body;
    }

}
