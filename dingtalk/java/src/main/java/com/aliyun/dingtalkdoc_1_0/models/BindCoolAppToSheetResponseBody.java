// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class BindCoolAppToSheetResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static BindCoolAppToSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BindCoolAppToSheetResponseBody self = new BindCoolAppToSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public BindCoolAppToSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
