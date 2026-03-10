// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class SetInProgressCustomTabsResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetInProgressCustomTabsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetInProgressCustomTabsResponseBody self = new SetInProgressCustomTabsResponseBody();
        return TeaModel.build(map, self);
    }

    public SetInProgressCustomTabsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
