// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkservice_group_1_0.models;

import com.aliyun.tea.*;

public class GroupStatisticsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GroupStatisticsResponseBody body;

    public static GroupStatisticsResponse build(java.util.Map<String, ?> map) throws Exception {
        GroupStatisticsResponse self = new GroupStatisticsResponse();
        return TeaModel.build(map, self);
    }

    public GroupStatisticsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GroupStatisticsResponse setBody(GroupStatisticsResponseBody body) {
        this.body = body;
        return this;
    }
    public GroupStatisticsResponseBody getBody() {
        return this.body;
    }

}
