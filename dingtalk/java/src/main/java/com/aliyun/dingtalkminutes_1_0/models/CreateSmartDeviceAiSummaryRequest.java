// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class CreateSmartDeviceAiSummaryRequest extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("instanceId")
    public String instanceId;

    @NameInMap("isvContext")
    public String isvContext;

    @NameInMap("openFileId")
    public String openFileId;

    public static CreateSmartDeviceAiSummaryRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateSmartDeviceAiSummaryRequest self = new CreateSmartDeviceAiSummaryRequest();
        return TeaModel.build(map, self);
    }

    public CreateSmartDeviceAiSummaryRequest setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public CreateSmartDeviceAiSummaryRequest setInstanceId(String instanceId) {
        this.instanceId = instanceId;
        return this;
    }
    public String getInstanceId() {
        return this.instanceId;
    }

    public CreateSmartDeviceAiSummaryRequest setIsvContext(String isvContext) {
        this.isvContext = isvContext;
        return this;
    }
    public String getIsvContext() {
        return this.isvContext;
    }

    public CreateSmartDeviceAiSummaryRequest setOpenFileId(String openFileId) {
        this.openFileId = openFileId;
        return this;
    }
    public String getOpenFileId() {
        return this.openFileId;
    }

}
