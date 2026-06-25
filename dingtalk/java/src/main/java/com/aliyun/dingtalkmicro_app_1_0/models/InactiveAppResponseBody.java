// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class InactiveAppResponseBody extends TeaModel {
    @NameInMap("agentId")
    public String agentId;

    @NameInMap("message")
    public String message;

    @NameInMap("success")
    public Boolean success;

    @NameInMap("unifiedAppId")
    public String unifiedAppId;

    public static InactiveAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        InactiveAppResponseBody self = new InactiveAppResponseBody();
        return TeaModel.build(map, self);
    }

    public InactiveAppResponseBody setAgentId(String agentId) {
        this.agentId = agentId;
        return this;
    }
    public String getAgentId() {
        return this.agentId;
    }

    public InactiveAppResponseBody setMessage(String message) {
        this.message = message;
        return this;
    }
    public String getMessage() {
        return this.message;
    }

    public InactiveAppResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public InactiveAppResponseBody setUnifiedAppId(String unifiedAppId) {
        this.unifiedAppId = unifiedAppId;
        return this;
    }
    public String getUnifiedAppId() {
        return this.unifiedAppId;
    }

}
