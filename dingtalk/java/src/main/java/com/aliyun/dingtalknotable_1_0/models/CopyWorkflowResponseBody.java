// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class CopyWorkflowResponseBody extends TeaModel {
    @NameInMap("flowId")
    public String flowId;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("versionId")
    public String versionId;

    public static CopyWorkflowResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CopyWorkflowResponseBody self = new CopyWorkflowResponseBody();
        return TeaModel.build(map, self);
    }

    public CopyWorkflowResponseBody setFlowId(String flowId) {
        this.flowId = flowId;
        return this;
    }
    public String getFlowId() {
        return this.flowId;
    }

    public CopyWorkflowResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public CopyWorkflowResponseBody setVersionId(String versionId) {
        this.versionId = versionId;
        return this;
    }
    public String getVersionId() {
        return this.versionId;
    }

}
