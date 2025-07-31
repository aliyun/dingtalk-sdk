// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkassistant_1_0.models;

import com.aliyun.tea.*;

public class DeployAssistantResponseBody extends TeaModel {
    @NameInMap("assistantId")
    public String assistantId;

    public static DeployAssistantResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeployAssistantResponseBody self = new DeployAssistantResponseBody();
        return TeaModel.build(map, self);
    }

    public DeployAssistantResponseBody setAssistantId(String assistantId) {
        this.assistantId = assistantId;
        return this;
    }
    public String getAssistantId() {
        return this.assistantId;
    }

}
