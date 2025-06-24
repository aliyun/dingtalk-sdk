// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class SetUserVersionToFreeResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static SetUserVersionToFreeResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetUserVersionToFreeResponseBody self = new SetUserVersionToFreeResponseBody();
        return TeaModel.build(map, self);
    }

    public SetUserVersionToFreeResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
