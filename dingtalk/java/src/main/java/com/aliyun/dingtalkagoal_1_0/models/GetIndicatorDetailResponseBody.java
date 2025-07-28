// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class GetIndicatorDetailResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<String> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static GetIndicatorDetailResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetIndicatorDetailResponseBody self = new GetIndicatorDetailResponseBody();
        return TeaModel.build(map, self);
    }

    public GetIndicatorDetailResponseBody setContent(java.util.List<String> content) {
        this.content = content;
        return this;
    }
    public java.util.List<String> getContent() {
        return this.content;
    }

    public GetIndicatorDetailResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetIndicatorDetailResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
