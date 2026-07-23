// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdvi_1_0.models;

import com.aliyun.tea.*;

public class UpdateServiceRecordRestrictRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("action")
    public String action;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("recordIds")
    public java.util.List<String> recordIds;

    public static UpdateServiceRecordRestrictRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateServiceRecordRestrictRequest self = new UpdateServiceRecordRestrictRequest();
        return TeaModel.build(map, self);
    }

    public UpdateServiceRecordRestrictRequest setAction(String action) {
        this.action = action;
        return this;
    }
    public String getAction() {
        return this.action;
    }

    public UpdateServiceRecordRestrictRequest setRecordIds(java.util.List<String> recordIds) {
        this.recordIds = recordIds;
        return this;
    }
    public java.util.List<String> getRecordIds() {
        return this.recordIds;
    }

}
