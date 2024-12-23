// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class DeleteCollegeContactSceneStruRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("struId")
    public Long struId;

    public static DeleteCollegeContactSceneStruRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteCollegeContactSceneStruRequest self = new DeleteCollegeContactSceneStruRequest();
        return TeaModel.build(map, self);
    }

    public DeleteCollegeContactSceneStruRequest setStruId(Long struId) {
        this.struId = struId;
        return this;
    }
    public Long getStruId() {
        return this.struId;
    }

}
