// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class UnbindCoolAppToSheetResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static UnbindCoolAppToSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UnbindCoolAppToSheetResponseBody self = new UnbindCoolAppToSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public UnbindCoolAppToSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
