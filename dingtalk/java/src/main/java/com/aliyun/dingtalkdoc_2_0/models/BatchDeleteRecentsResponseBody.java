// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class BatchDeleteRecentsResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static BatchDeleteRecentsResponseBody build(java.util.Map<String, ?> map) throws Exception {
        BatchDeleteRecentsResponseBody self = new BatchDeleteRecentsResponseBody();
        return TeaModel.build(map, self);
    }

    public BatchDeleteRecentsResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
