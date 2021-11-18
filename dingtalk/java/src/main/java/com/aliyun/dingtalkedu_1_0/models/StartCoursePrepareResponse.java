// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class StartCoursePrepareResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public StartCoursePrepareResponseBody body;

    public static StartCoursePrepareResponse build(java.util.Map<String, ?> map) throws Exception {
        StartCoursePrepareResponse self = new StartCoursePrepareResponse();
        return TeaModel.build(map, self);
    }

    public StartCoursePrepareResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public StartCoursePrepareResponse setBody(StartCoursePrepareResponseBody body) {
        this.body = body;
        return this;
    }
    public StartCoursePrepareResponseBody getBody() {
        return this.body;
    }

}
