// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkagoal_1_0.models;

import com.aliyun.tea.*;

public class AgoalOrgObjectiveRuleListResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("content")
    public java.util.List<OpenOrgObjectiveRuleDTO> content;

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

    public static AgoalOrgObjectiveRuleListResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AgoalOrgObjectiveRuleListResponseBody self = new AgoalOrgObjectiveRuleListResponseBody();
        return TeaModel.build(map, self);
    }

    public AgoalOrgObjectiveRuleListResponseBody setContent(java.util.List<OpenOrgObjectiveRuleDTO> content) {
        this.content = content;
        return this;
    }
    public java.util.List<OpenOrgObjectiveRuleDTO> getContent() {
        return this.content;
    }

    public AgoalOrgObjectiveRuleListResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public AgoalOrgObjectiveRuleListResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
