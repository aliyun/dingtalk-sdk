// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkflashmeeting_1_0.models;

import com.aliyun.tea.*;

public class GetShanhuiAttachmentsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public GetShanhuiAttachmentsResponseBody body;

    public static GetShanhuiAttachmentsResponse build(java.util.Map<String, ?> map) throws Exception {
        GetShanhuiAttachmentsResponse self = new GetShanhuiAttachmentsResponse();
        return TeaModel.build(map, self);
    }

    public GetShanhuiAttachmentsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetShanhuiAttachmentsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public GetShanhuiAttachmentsResponse setBody(GetShanhuiAttachmentsResponseBody body) {
        this.body = body;
        return this;
    }
    public GetShanhuiAttachmentsResponseBody getBody() {
        return this.body;
    }

}
