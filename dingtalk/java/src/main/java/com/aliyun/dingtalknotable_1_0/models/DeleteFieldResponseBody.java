// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteFieldResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteFieldResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteFieldResponseBody self = new DeleteFieldResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteFieldResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
