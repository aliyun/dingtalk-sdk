// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class TopicStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TopicStatisticsResponseBody body;

    public static TopicStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        TopicStatisticsResponse self = new TopicStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public TopicStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TopicStatisticsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TopicStatisticsResponse setBody(TopicStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public TopicStatisticsResponseBody getBody() {
        return this.body;
    }

}
