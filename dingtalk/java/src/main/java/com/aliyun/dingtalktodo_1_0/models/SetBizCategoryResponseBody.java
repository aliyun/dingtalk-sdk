// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_1_0.models;

import com.aliyun.tea.*;

public class SetBizCategoryResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static SetBizCategoryResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SetBizCategoryResponseBody self = new SetBizCategoryResponseBody();
        return TeaModel.build(map, self);
    }

    public SetBizCategoryResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
