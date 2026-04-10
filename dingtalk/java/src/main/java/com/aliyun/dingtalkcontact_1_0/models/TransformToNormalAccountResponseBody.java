// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TransformToNormalAccountResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static TransformToNormalAccountResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TransformToNormalAccountResponseBody self = new TransformToNormalAccountResponseBody();
        return TeaModel.build(map, self);
    }

    public TransformToNormalAccountResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
