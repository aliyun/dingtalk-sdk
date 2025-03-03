// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumDelDirRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>oaDirIdxxx</p>
     */
    @NameInMap("dirId")
    public String dirId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>user001</p>
     */
    @NameInMap("operateUserId")
    public String operateUserId;

    public static PremiumDelDirRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumDelDirRequest self = new PremiumDelDirRequest();
        return TeaModel.build(map, self);
    }

    public PremiumDelDirRequest setDirId(String dirId) {
        this.dirId = dirId;
        return this;
    }
    public String getDirId() {
        return this.dirId;
    }

    public PremiumDelDirRequest setOperateUserId(String operateUserId) {
        this.operateUserId = operateUserId;
        return this;
    }
    public String getOperateUserId() {
        return this.operateUserId;
    }

}
