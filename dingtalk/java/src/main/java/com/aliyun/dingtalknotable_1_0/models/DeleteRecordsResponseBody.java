// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalknotable_1_0.models;

import com.aliyun.tea.*;

public class DeleteRecordsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static DeleteRecordsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteRecordsResponseBody self = new DeleteRecordsResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteRecordsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
