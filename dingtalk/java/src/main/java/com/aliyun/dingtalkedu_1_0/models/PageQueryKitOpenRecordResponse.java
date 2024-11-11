// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class PageQueryKitOpenRecordResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public PageQueryKitOpenRecordResponseBody body;

    public static PageQueryKitOpenRecordResponse build(java.util.Map<String, ?> map) throws Exception {
        PageQueryKitOpenRecordResponse self = new PageQueryKitOpenRecordResponse();
        return TeaModel.build(map, self);
    }

    public PageQueryKitOpenRecordResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public PageQueryKitOpenRecordResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public PageQueryKitOpenRecordResponse setBody(PageQueryKitOpenRecordResponseBody body) {
        this.body = body;
        return this;
    }
    public PageQueryKitOpenRecordResponseBody getBody() {
        return this.body;
    }

}
