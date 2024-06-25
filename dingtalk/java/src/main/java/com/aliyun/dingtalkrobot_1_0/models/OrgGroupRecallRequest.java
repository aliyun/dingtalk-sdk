// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class OrgGroupRecallRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidfCSpXXXXXXXXXXXchatbotId</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("processQueryKeys")
    public java.util.List<String> processQueryKeys;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>dingXXXXXXXXXX</p>
     */
    @NameInMap("robotCode")
    public String robotCode;

    public static OrgGroupRecallRequest build(java.util.Map<String, ?> map) throws Exception {
        OrgGroupRecallRequest self = new OrgGroupRecallRequest();
        return TeaModel.build(map, self);
    }

    public OrgGroupRecallRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public OrgGroupRecallRequest setProcessQueryKeys(java.util.List<String> processQueryKeys) {
        this.processQueryKeys = processQueryKeys;
        return this;
    }
    public java.util.List<String> getProcessQueryKeys() {
        return this.processQueryKeys;
    }

    public OrgGroupRecallRequest setRobotCode(String robotCode) {
        this.robotCode = robotCode;
        return this;
    }
    public String getRobotCode() {
        return this.robotCode;
    }

}
