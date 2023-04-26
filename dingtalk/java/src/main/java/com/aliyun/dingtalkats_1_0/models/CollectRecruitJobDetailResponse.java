// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkats_1_0.models;

import com.aliyun.tea.*;

public class CollectRecruitJobDetailResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    @Validation(required = true)
    public Integer statusCode;

    @NameInMap("body")
    @Validation(required = true)
    public CollectRecruitJobDetailResponseBody body;

    public static CollectRecruitJobDetailResponse build(java.util.Map<String, ?> map) throws Exception {
        CollectRecruitJobDetailResponse self = new CollectRecruitJobDetailResponse();
        return TeaModel.build(map, self);
    }

    public CollectRecruitJobDetailResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public CollectRecruitJobDetailResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public CollectRecruitJobDetailResponse setBody(CollectRecruitJobDetailResponseBody body) {
        this.body = body;
        return this;
    }
    public CollectRecruitJobDetailResponseBody getBody() {
        return this.body;
    }

}
