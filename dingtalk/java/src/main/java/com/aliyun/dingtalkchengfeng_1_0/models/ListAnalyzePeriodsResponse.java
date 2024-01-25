// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListAnalyzePeriodsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
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

    public ListAnalyzePeriodsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public ListAnalyzePeriodsResponse setBody(ListAnalyzePeriodsResponseBody body) {
        this.body = body;
        return this;
    }
    public ListAnalyzePeriodsResponseBody getBody() {
        return this.body;
    }

}
