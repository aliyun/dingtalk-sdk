// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class ValidateApplicationAuthorizationServiceOrderRequest extends TeaModel {
    @NameInMap("accessKey")
    public String accessKey;

    public static ValidateApplicationAuthorizationServiceOrderRequest build(java.util.Map<String, ?> map) throws Exception {
        ValidateApplicationAuthorizationServiceOrderRequest self = new ValidateApplicationAuthorizationServiceOrderRequest();
        return TeaModel.build(map, self);
    }

    public ValidateApplicationAuthorizationServiceOrderRequest setAccessKey(String accessKey) {
        this.accessKey = accessKey;
        return this;
    }
    public String getAccessKey() {
        return this.accessKey;
    }

}
