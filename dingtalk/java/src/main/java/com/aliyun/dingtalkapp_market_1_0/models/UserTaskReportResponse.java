// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class UserTaskReportResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public Boolean body;

    public static UserTaskReportResponse build(java.util.Map<String, ?> map) throws Exception {
        UserTaskReportResponse self = new UserTaskReportResponse();
        return TeaModel.build(map, self);
    }

    public UserTaskReportResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public UserTaskReportResponse setBody(Boolean body) {
        this.body = body;
        return this;
    }
    public Boolean getBody() {
        return this.body;
    }

}
