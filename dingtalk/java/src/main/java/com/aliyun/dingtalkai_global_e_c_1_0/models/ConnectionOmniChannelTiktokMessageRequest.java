// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class ConnectionOmniChannelTiktokMessageRequest extends TeaModel {
    @NameInMap("tiktokContentJsonString")
    public String tiktokContentJsonString;

    public static ConnectionOmniChannelTiktokMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        ConnectionOmniChannelTiktokMessageRequest self = new ConnectionOmniChannelTiktokMessageRequest();
        return TeaModel.build(map, self);
    }

    public ConnectionOmniChannelTiktokMessageRequest setTiktokContentJsonString(String tiktokContentJsonString) {
        this.tiktokContentJsonString = tiktokContentJsonString;
        return this;
    }
    public String getTiktokContentJsonString() {
        return this.tiktokContentJsonString;
    }

}
