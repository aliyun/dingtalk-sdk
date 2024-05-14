// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RollbackInnerAppVersionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appVersionId")
    public Long appVersionId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    public static RollbackInnerAppVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        RollbackInnerAppVersionRequest self = new RollbackInnerAppVersionRequest();
        return TeaModel.build(map, self);
    }

    public RollbackInnerAppVersionRequest setAppVersionId(Long appVersionId) {
        this.appVersionId = appVersionId;
        return this;
    }
    public Long getAppVersionId() {
        return this.appVersionId;
    }

    public RollbackInnerAppVersionRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

}
