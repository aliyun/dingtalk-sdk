// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListObjectiveByIdsRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("objectiveIds")
    public java.util.List<String> objectiveIds;

    public static ListObjectiveByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListObjectiveByIdsRequest self = new ListObjectiveByIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListObjectiveByIdsRequest setObjectiveIds(java.util.List<String> objectiveIds) {
        this.objectiveIds = objectiveIds;
        return this;
    }
    public java.util.List<String> getObjectiveIds() {
        return this.objectiveIds;
    }

}
