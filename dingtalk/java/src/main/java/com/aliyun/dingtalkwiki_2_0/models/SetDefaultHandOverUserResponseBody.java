// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkwiki_2_0.models;

import com.aliyun.tea.*;

public class SetDefaultHandOverUserResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetDefaultHandOverUserResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetDefaultHandOverUserResponseBody self = new SetDefaultHandOverUserResponseBody();
        return TeaModel.build(map, self);
    }

    public SetDefaultHandOverUserResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
