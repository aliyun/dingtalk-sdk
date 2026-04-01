// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeListResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public TalentQueryTagLikeListResponseBody body;

    public static TalentQueryTagLikeListResponse build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeListResponse self = new TalentQueryTagLikeListResponse();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeListResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public TalentQueryTagLikeListResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public TalentQueryTagLikeListResponse setBody(TalentQueryTagLikeListResponseBody body) {
        this.body = body;
        return this;
    }
    public TalentQueryTagLikeListResponseBody getBody() {
        return this.body;
    }

}
