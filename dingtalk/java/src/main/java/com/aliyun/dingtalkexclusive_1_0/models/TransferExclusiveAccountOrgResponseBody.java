// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class TransferExclusiveAccountOrgResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("success")
    public Boolean success;

    public static TransferExclusiveAccountOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        TransferExclusiveAccountOrgResponseBody self = new TransferExclusiveAccountOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public TransferExclusiveAccountOrgResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

}
