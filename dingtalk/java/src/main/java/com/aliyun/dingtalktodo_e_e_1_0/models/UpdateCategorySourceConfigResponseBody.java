// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class UpdateCategorySourceConfigResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static UpdateCategorySourceConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateCategorySourceConfigResponseBody self = new UpdateCategorySourceConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateCategorySourceConfigResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
