// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class SaveUserExtendValuesResponseBody extends TeaModel {
    // 是否成功
    @NameInMap("success")
    public Boolean success;

    public static SaveUserExtendValuesResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveUserExtendValuesResponseBody self = new SaveUserExtendValuesResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveUserExtendValuesResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
