// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteFloatImageResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteFloatImageResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFloatImageResponseBody self = new DeleteFloatImageResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFloatImageResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
