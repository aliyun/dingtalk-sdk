// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalFiscalYearschemeListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public AgoalFiscalYearschemeListResponseBody body;

    public static AgoalFiscalYearschemeListResponse build(java.util.Map<String, ?> map) throws Exception {
        AgoalFiscalYearschemeListResponse self = new AgoalFiscalYearschemeListResponse();
        return TeaModel.build(map, self);
    }

    public AgoalFiscalYearschemeListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public AgoalFiscalYearschemeListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public AgoalFiscalYearschemeListResponse setBody(AgoalFiscalYearschemeListResponseBody body) {
        this.body = body;
        return this;
    }
    public AgoalFiscalYearschemeListResponseBody getBody() {
        return this.body;
    }

}
