// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class CategoryStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CategoryStatisticsResponseBody body;

    public static CategoryStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        CategoryStatisticsResponse self = new CategoryStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public CategoryStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CategoryStatisticsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CategoryStatisticsResponse setBody(CategoryStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public CategoryStatisticsResponseBody getBody() {
        return this.body;
    }

}
