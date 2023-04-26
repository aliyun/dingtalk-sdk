// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveWhiteAppRequest extends TeaModel {
    @NameInMap("agentIdList")
    public java.util.List<Long> agentIdList;

    @NameInMap("operation")
    public String operation;

    public static SaveWhiteAppRequest build(java.util.Map<String, ?> map) throws Exception {
        SaveWhiteAppRequest self = new SaveWhiteAppRequest();
        return TeaModel.build(map, self);
    }

    public SaveWhiteAppRequest setAgentIdList(java.util.List<Long> agentIdList) {
        this.agentIdList = agentIdList;
        return this;
    }
    public java.util.List<Long> getAgentIdList() {
        return this.agentIdList;
    }

    public SaveWhiteAppRequest setOperation(String operation) {
        this.operation = operation;
        return this;
    }
    public String getOperation() {
        return this.operation;
    }

}
