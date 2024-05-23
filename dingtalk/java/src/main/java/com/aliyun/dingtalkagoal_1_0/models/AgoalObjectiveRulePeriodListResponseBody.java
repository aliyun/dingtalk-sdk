// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRulePeriodListResponseBody extends TeaModel {
    @NameInMap("content")
    public java.util.List<OpenObjectiveRulePeriodDTO> content;

    @NameInMap("requestId")
    public String requestId;

    @NameInMap("success")
    public Boolean success;

    public static AgoalObjectiveRulePeriodListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalObjectiveRulePeriodListResponseBody self = new AgoalObjectiveRulePeriodListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalObjectiveRulePeriodListResponseBody setContent(java.util.List<OpenObjectiveRulePeriodDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenObjectiveRulePeriodDTO> getContent() {
        return this.content;
    }

    public AgoalObjectiveRulePeriodListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalObjectiveRulePeriodListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
