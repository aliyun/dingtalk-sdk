// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class FindTargetRelatedFollowRecordsResponse extends TeaModel {
    @NameInMap("headers")
    public java.util.Map<String, String> headers;

    @NameInMap("statusCode")
    public Integer statusCode;

    @NameInMap("body")
    public FindTargetRelatedFollowRecordsResponseBody body;

    public static FindTargetRelatedFollowRecordsResponse build(java.util.Map<String, ?> map) throws Exception {
        FindTargetRelatedFollowRecordsResponse self = new FindTargetRelatedFollowRecordsResponse();
        return TeaModel.build(map, self);
    }

    public FindTargetRelatedFollowRecordsResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public FindTargetRelatedFollowRecordsResponse setStatusCode(Integer statusCode) {
        this.statusCode = statusCode;
        return this;
    }
    public Integer getStatusCode() {
        return this.statusCode;
    }

    public FindTargetRelatedFollowRecordsResponse setBody(FindTargetRelatedFollowRecordsResponseBody body) {
        this.body = body;
        return this;
    }
    public FindTargetRelatedFollowRecordsResponseBody getBody() {
        return this.body;
    }

}
