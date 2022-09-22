// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklink_1_0.models;

import com.aliyun.tea.*;

public class UpdateShortcutsResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static UpdateShortcutsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateShortcutsResponseBody self = new UpdateShortcutsResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateShortcutsResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
