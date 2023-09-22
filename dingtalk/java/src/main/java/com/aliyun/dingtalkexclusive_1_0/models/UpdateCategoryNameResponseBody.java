// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class UpdateCategoryNameResponseBody extends TeaModel {
    @NameInMap("status")
    public Long status;

    public static UpdateCategoryNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCategoryNameResponseBody self = new UpdateCategoryNameResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCategoryNameResponseBody setStatus(Long status) {
        this.status = status;
        return this;
    }
    public Long getStatus() {
        return this.status;
    }

}
