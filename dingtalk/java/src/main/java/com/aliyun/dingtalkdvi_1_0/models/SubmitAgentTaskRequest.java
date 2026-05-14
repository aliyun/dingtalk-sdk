// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class SubmitAgentTaskRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("agentCode")
    public String agentCode;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("bizIdentify")
    public String bizIdentify;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("input")
    public String input;

    @NameInMap("userId")
    public String userId;

    public static SubmitAgentTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        SubmitAgentTaskRequest self = new SubmitAgentTaskRequest();
        return TeaModel.build(map, self);
    }

    public SubmitAgentTaskRequest setAgentCode(String agentCode) {
        this.agentCode = agentCode;
        return this;
    }
    public String getAgentCode() {
        return this.agentCode;
    }

    public SubmitAgentTaskRequest setBizIdentify(String bizIdentify) {
        this.bizIdentify = bizIdentify;
        return this;
    }
    public String getBizIdentify() {
        return this.bizIdentify;
    }

    public SubmitAgentTaskRequest setInput(String input) {
        this.input = input;
        return this;
    }
    public String getInput() {
        return this.input;
    }

    public SubmitAgentTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
