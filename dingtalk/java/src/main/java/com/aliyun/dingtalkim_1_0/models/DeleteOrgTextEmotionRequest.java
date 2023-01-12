// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class DeleteOrgTextEmotionRequest extends TeaModel {
    /**
     * <p>表情所属部门Id：</p>
     * <p>-1：当文字表情属于企业层面时使用-1</p>
     * <p>一级部门Id：当文字表情属于一级部门层面时使用一级部门Id</p>
     */
    @NameInMap("deptId")
    public Long deptId;

    /**
     * <p>要删除的表情Id列表。请注意，该列表中的所有表情Id一定要同属于deptId</p>
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
