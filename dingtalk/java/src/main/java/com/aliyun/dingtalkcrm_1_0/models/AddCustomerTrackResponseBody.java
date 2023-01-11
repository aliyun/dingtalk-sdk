// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class AddCustomerTrackResponseBody extends TeaModel {
    /**
     * <p>是否成功</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static AddCustomerTrackResponseBody build(java.util.Map<String, ?> map) throws Exception {
        AddCustomerTrackResponseBody self = new AddCustomerTrackResponseBody();
        return TeaModel.build(map, self);
    }

    public AddCustomerTrackResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
