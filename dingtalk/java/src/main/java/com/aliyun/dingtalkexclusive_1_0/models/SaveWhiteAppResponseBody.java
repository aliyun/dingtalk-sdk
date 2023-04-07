// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class SaveWhiteAppResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SaveWhiteAppResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SaveWhiteAppResponseBody self = new SaveWhiteAppResponseBody();
        return TeaModel.build(map, self);
    }

    public SaveWhiteAppResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
