// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktodo_e_e_1_0.models;

import com.aliyun.tea.*;

public class DeleteCategorySourceConfigResponseBody extends TeaModel {
    @NameInMap("success")
    public String success;

    public static DeleteCategorySourceConfigResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteCategorySourceConfigResponseBody self = new DeleteCategorySourceConfigResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteCategorySourceConfigResponseBody setSuccess(String success) {
        this.success = success;
        return this;
    }
    public String getSuccess() {
        return this.success;
    }

}
