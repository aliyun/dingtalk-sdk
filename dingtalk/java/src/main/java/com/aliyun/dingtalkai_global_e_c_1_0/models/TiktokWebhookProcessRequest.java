// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkai_global_e_c_1_0.models;

import com.aliyun.tea.*;

public class TiktokWebhookProcessRequest extends TeaModel {
    @NameInMap("tiktokContentJsonString")
    public String tiktokContentJsonString;

    public static TiktokWebhookProcessRequest build(java.util.Map<String, ?> map) throws Exception {
        TiktokWebhookProcessRequest self = new TiktokWebhookProcessRequest();
        return TeaModel.build(map, self);
    }

    public TiktokWebhookProcessRequest setTiktokContentJsonString(String tiktokContentJsonString) {
        this.tiktokContentJsonString = tiktokContentJsonString;
        return this;
    }
    public String getTiktokContentJsonString() {
        return this.tiktokContentJsonString;
    }

}
