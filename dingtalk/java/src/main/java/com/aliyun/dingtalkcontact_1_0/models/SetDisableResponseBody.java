// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetDisableResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SetDisableResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetDisableResponseBody self = new SetDisableResponseBody();
        return TeaModel.build(map, self);
    }

    public SetDisableResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
