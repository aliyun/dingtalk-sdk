// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListAnalyzePeriodsResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public ListAnalyzePeriodsResponseBody body;

    public static ListAnalyzePeriodsResponse build(java.util.Map<String, ?> map) throws Exception {
        ListAnalyzePeriodsResponse self = new ListAnalyzePeriodsResponse();
        return TeaModel.build(map, self);
    }

    public ListAnalyzePeriodsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public ListAnalyzePeriodsResponse setBody(ListAnalyzePeriodsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAnalyzePeriodsResponseBody getBody() {
        return this.body;
    }

}
