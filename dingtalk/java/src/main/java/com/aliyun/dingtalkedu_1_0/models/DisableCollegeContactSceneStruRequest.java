// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DisableCollegeContactSceneStruRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("struId")
    public Long struId;

    public static DisableCollegeContactSceneStruRequest build(java.util.Map<String, ?> map) throws Exception {
        DisableCollegeContactSceneStruRequest self = new DisableCollegeContactSceneStruRequest();
        return TeaModel.build(map, self);
    }

    public DisableCollegeContactSceneStruRequest setStruId(Long struId) {
        this.struId = struId;
        return this;
    }
    public Long getStruId() {
        return this.struId;
    }

}
