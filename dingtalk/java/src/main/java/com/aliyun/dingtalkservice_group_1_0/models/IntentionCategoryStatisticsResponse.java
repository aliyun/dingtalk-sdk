// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class IntentionCategoryStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public IntentionCategoryStatisticsResponseBody body;

    public static IntentionCategoryStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        IntentionCategoryStatisticsResponse self = new IntentionCategoryStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public IntentionCategoryStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public IntentionCategoryStatisticsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public IntentionCategoryStatisticsResponse setBody(IntentionCategoryStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public IntentionCategoryStatisticsResponseBody getBody() {
        return this.body;
    }

}
