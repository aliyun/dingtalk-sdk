// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateServiceRecordRestrictShrinkRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordIds")
    public String recordIdsShrink;

    public static UpdateServiceRecordRestrictShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateServiceRecordRestrictShrinkRequest self = new UpdateServiceRecordRestrictShrinkRequest();
        return TeaModel.build(map, self);
    }

    public UpdateServiceRecordRestrictShrinkRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public UpdateServiceRecordRestrictShrinkRequest setRecordIdsShrink(String recordIdsShrink) {
        this.recordIdsShrink = recordIdsShrink;
        return this;
    }
    public String getRecordIdsShrink() {
        return this.recordIdsShrink;
    }

}
