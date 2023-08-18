// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkbench_1_0.models;

import com.aliyun.tea.*;

public class ModifyWorkbenchBadgeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static ModifyWorkbenchBadgeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ModifyWorkbenchBadgeResponseBody self = new ModifyWorkbenchBadgeResponseBody();
        return TeaModel.build(map, self);
    }

    public ModifyWorkbenchBadgeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
