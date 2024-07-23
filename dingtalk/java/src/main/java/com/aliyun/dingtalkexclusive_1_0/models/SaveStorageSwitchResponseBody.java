// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveStorageSwitchResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static SaveStorageSwitchResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveStorageSwitchResponseBody self = new SaveStorageSwitchResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveStorageSwitchResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
