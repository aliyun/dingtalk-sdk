// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DeleteSheetResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteSheetResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteSheetResponseBody self = new DeleteSheetResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteSheetResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
