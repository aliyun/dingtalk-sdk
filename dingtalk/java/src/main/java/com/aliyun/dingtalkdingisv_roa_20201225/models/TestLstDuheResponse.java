// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdingisv_roa_20201225.models;

import com.aliyun.tea.*;

public class TestLstDuheResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public TestLstDuheResponseBody body;

    public static TestLstDuheResponse build(java.util.Map<String, ?> map) throws Exception {
        TestLstDuheResponse self = new TestLstDuheResponse();
        return TeaModel.build(map, self);
    }

    public TestLstDuheResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TestLstDuheResponse setBody(TestLstDuheResponseBody body) {
        this.body = body;
        return this;
    }
    public TestLstDuheResponseBody getBody() {
        return this.body;
    }

}
