// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationOrderRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    @NameInMap("callerUnionId")
    public String callerUnionId;

    public static ValidateApplicationAuthorizationOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationOrderRequest self = new ValidateApplicationAuthorizationOrderRequest();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

    public ValidateApplicationAuthorizationOrderRequest setCallerUnionId(String callerUnionId) {
        this.callerUnionId = callerUnionId;
        return this;
    }
    public String getCallerUnionId() {
        return this.callerUnionId;
    }

}
