// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgTextEmotionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>-1</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("emotionIds")
    public java.util.List<String> emotionIds;

    public static DeleteOrgTextEmotionRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteOrgTextEmotionRequest self = new DeleteOrgTextEmotionRequest();
        return TeaModel.build(map, self);
    }

    public DeleteOrgTextEmotionRequest setDeptId(Long deptId) {
        this.deptId = deptId;
        return this;
    }
    public Long getDeptId() {
        return this.deptId;
    }

    public DeleteOrgTextEmotionRequest setEmotionIds(java.util.List<String> emotionIds) {
        this.emotionIds = emotionIds;
        return this;
    }
    public java.util.List<String> getEmotionIds() {
        return this.emotionIds;
    }

}
