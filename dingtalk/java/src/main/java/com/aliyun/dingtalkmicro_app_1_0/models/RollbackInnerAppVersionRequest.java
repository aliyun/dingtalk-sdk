// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class RollbackInnerAppVersionRequest extends TeaModel {
    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    /**
     * <p>小程序版本id</p>
     */
    @NameInMap("versionId")
    public Long versionId;

    public static RollbackInnerAppVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        RollbackInnerAppVersionRequest self = new RollbackInnerAppVersionRequest();
        return TeaModel.build(map, self);
    }

    public RollbackInnerAppVersionRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public RollbackInnerAppVersionRequest setVersionId(Long versionId) {
        this.versionId = versionId;
        return this;
    }
    public Long getVersionId() {
        return this.versionId;
    }

}
