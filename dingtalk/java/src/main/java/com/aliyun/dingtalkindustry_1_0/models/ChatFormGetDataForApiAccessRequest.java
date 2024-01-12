// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ChatFormGetDataForApiAccessRequest extends TeaModel {
    @NameInMap("dingTalkTraceId")
    public String dingTalkTraceId;

    public static ChatFormGetDataForApiAccessRequest build(java.util.Map<String, ?> map) throws Exception {
        ChatFormGetDataForApiAccessRequest self = new ChatFormGetDataForApiAccessRequest();
        return TeaModel.build(map, self);
    }

    public ChatFormGetDataForApiAccessRequest setDingTalkTraceId(String dingTalkTraceId) {
        this.dingTalkTraceId = dingTalkTraceId;
        return this;
    }
    public String getDingTalkTraceId() {
        return this.dingTalkTraceId;
    }

}
