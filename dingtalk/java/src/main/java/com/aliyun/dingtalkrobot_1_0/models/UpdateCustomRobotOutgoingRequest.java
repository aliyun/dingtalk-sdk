// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkrobot_1_0.models;

import com.aliyun.tea.*;

public class UpdateCustomRobotOutgoingRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("outgoingUrl")
    public String outgoingUrl;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("token")
    public String token;

    public static UpdateCustomRobotOutgoingRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateCustomRobotOutgoingRequest self = new UpdateCustomRobotOutgoingRequest();
        return TeaModel.build(map, self);
    }

    public UpdateCustomRobotOutgoingRequest setOutgoingUrl(String outgoingUrl) {
        this.outgoingUrl = outgoingUrl;
        return this;
    }
    public String getOutgoingUrl() {
        return this.outgoingUrl;
    }

    public UpdateCustomRobotOutgoingRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
