// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalObjectiveRulePeriodListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<OpenObjectiveRulePeriodDTO> content;

    /**
     * <strong>example:</strong>
     * <p>7478B23C-80E8-1AD6-BE8C-09D480E0xxxx</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>This parameter is required.</p>
     */
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
