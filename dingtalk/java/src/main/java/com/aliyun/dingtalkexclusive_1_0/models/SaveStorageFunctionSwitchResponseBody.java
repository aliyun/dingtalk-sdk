// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageFunctionSwitchResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SaveStorageFunctionSwitchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageFunctionSwitchResponseBody self = new SaveStorageFunctionSwitchResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveStorageFunctionSwitchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
