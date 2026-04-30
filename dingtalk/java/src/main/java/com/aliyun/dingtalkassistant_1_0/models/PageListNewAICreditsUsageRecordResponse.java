// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class PageListNewAICreditsUsageRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageListNewAICreditsUsageRecordResponseBody body;

    public static PageListNewAICreditsUsageRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListNewAICreditsUsageRecordResponse self = new PageListNewAICreditsUsageRecordResponse();
        return TeaModel.build(map, self);
    }

    public PageListNewAICreditsUsageRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListNewAICreditsUsageRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageListNewAICreditsUsageRecordResponse setBody(PageListNewAICreditsUsageRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListNewAICreditsUsageRecordResponseBody getBody() {
        return this.body;
    }

}
