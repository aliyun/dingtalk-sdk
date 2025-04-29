// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class SubmitGetContentJobResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public SubmitGetContentJobResponseBody body;

    public static SubmitGetContentJobResponse build(java.util.Map<String, ?> map) throws Exception {
        SubmitGetContentJobResponse self = new SubmitGetContentJobResponse();
        return TeaModel.build(map, self);
    }

    public SubmitGetContentJobResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SubmitGetContentJobResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public SubmitGetContentJobResponse setBody(SubmitGetContentJobResponseBody body) {
        this.body = body;
        return this;
    }
    public SubmitGetContentJobResponseBody getBody() {
        return this.body;
    }

}
