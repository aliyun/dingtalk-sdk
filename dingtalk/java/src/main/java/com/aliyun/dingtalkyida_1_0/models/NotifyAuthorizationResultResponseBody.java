// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class NotifyAuthorizationResultResponseBody extends TeaModel {
    @NameInMap("result")
    public Boolean result;

    public static NotifyAuthorizationResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        NotifyAuthorizationResultResponseBody self = new NotifyAuthorizationResultResponseBody();
        return TeaModel.build(map, self);
    }

    public NotifyAuthorizationResultResponseBody setResult(Boolean result) {
        this.result = result;
        return this;
    }
    public Boolean getResult() {
        return this.result;
    }

}
