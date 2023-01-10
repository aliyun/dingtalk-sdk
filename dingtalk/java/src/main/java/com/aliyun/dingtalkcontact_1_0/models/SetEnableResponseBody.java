// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class SetEnableResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SetEnableResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetEnableResponseBody self = new SetEnableResponseBody();
        return TeaModel.build(map, self);
    }

    public SetEnableResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
