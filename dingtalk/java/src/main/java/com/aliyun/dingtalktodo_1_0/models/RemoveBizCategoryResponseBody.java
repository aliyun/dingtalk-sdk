// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class RemoveBizCategoryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static RemoveBizCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        RemoveBizCategoryResponseBody self = new RemoveBizCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public RemoveBizCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
