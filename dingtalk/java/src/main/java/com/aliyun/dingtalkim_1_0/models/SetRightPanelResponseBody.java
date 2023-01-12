// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class SetRightPanelResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetRightPanelResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetRightPanelResponseBody self = new SetRightPanelResponseBody();
        return TeaModel.build(map, self);
    }

    public SetRightPanelResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
