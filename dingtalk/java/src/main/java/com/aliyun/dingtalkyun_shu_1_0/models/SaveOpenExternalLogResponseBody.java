// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyun_shu_1_0.models;

import com.aliyun.tea.*;

public class SaveOpenExternalLogResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SaveOpenExternalLogResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveOpenExternalLogResponseBody self = new SaveOpenExternalLogResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveOpenExternalLogResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
