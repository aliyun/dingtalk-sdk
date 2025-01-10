// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalPeriodListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenAgoalPeriodDTO> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalPeriodListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalPeriodListResponseBody self = new AgoalPeriodListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalPeriodListResponseBody setContent(java.util.List<OpenAgoalPeriodDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenAgoalPeriodDTO> getContent() {
        return this.content;
    }

    public AgoalPeriodListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalPeriodListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
