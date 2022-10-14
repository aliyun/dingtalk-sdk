// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class RosterMetaFieldOptionsUpdateShrinkRequest extends TeaModel {
    @NameInMap("appAgentId")
    public Long appAgentId;

    @NameInMap("body")
    public String bodyShrink;

    public static RosterMetaFieldOptionsUpdateShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        RosterMetaFieldOptionsUpdateShrinkRequest self = new RosterMetaFieldOptionsUpdateShrinkRequest();
        return TeaModel.build(map, self);
    }

    public RosterMetaFieldOptionsUpdateShrinkRequest setAppAgentId(Long appAgentId) {
        this.appAgentId = appAgentId;
        return this;
    }
    public Long getAppAgentId() {
        return this.appAgentId;
    }

    public RosterMetaFieldOptionsUpdateShrinkRequest setBodyShrink(String bodyShrink) {
        this.bodyShrink = bodyShrink;
        return this;
    }
    public String getBodyShrink() {
        return this.bodyShrink;
    }

}
