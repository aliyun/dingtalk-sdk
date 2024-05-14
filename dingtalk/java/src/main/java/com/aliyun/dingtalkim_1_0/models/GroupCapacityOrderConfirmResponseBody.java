// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class GroupCapacityOrderConfirmResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static GroupCapacityOrderConfirmResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GroupCapacityOrderConfirmResponseBody self = new GroupCapacityOrderConfirmResponseBody();
        return TeaModel.build(map, self);
    }

    public GroupCapacityOrderConfirmResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
