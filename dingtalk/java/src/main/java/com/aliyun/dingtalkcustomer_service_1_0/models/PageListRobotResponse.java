// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcustomer_service_1_0.models;

import com.aliyun.tea.*;

public class PageListRobotResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public PageListRobotResponseBody body;

    public static PageListRobotResponse build(java.util.Map<String, ?> map) throws Exception {
        PageListRobotResponse self = new PageListRobotResponse();
        return TeaModel.build(map, self);
    }

    public PageListRobotResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageListRobotResponse setBody(PageListRobotResponseBody body) {
        this.body = body;
        return this;
    }
    public PageListRobotResponseBody getBody() {
        return this.body;
    }

}
