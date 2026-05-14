// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_2_0.models;

import com.aliyun.tea.*;

public class PageListAICreditsUsageResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageListAICreditsUsageResponseBody body;

    public static PageListAICreditsUsageResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListAICreditsUsageResponse self = new PageListAICreditsUsageResponse();
        return TeaModel.build(map, self);
    }

    public PageListAICreditsUsageResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListAICreditsUsageResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageListAICreditsUsageResponse setBody(PageListAICreditsUsageResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListAICreditsUsageResponseBody getBody() {
        return this.body;
    }

}
