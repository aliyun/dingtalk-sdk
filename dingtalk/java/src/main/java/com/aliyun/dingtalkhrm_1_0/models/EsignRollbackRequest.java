// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkhrm_1_0.models;

import com.aliyun.tea.*;

public class EsignRollbackRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("optUserId")
    public String optUserId;

    public static EsignRollbackRequest build(java.util.Map<String, ?> map) throws Exception {
        EsignRollbackRequest self = new EsignRollbackRequest();
        return TeaModel.build(map, self);
    }

    public EsignRollbackRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
