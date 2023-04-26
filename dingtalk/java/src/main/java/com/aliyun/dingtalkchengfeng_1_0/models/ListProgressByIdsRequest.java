// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class ListProgressByIdsRequest extends TeaModel {
    @NameInMap("progressIds")
    public java.util.List<String> progressIds;

    public static ListProgressByIdsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListProgressByIdsRequest self = new ListProgressByIdsRequest();
        return TeaModel.build(map, self);
    }

    public ListProgressByIdsRequest setProgressIds(java.util.List<String> progressIds) {
        this.progressIds = progressIds;
        return this;
    }
    public java.util.List<String> getProgressIds() {
        return this.progressIds;
    }

}
