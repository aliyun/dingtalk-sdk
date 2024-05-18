// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class DeleteDirResponseBody extends TeaModel {
    @NameInMap("success")
    public Boolean success;

    public static DeleteDirResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteDirResponseBody self = new DeleteDirResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteDirResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
