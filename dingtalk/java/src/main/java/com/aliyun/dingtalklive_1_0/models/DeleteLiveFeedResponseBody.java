// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveFeedResponseBody extends TeaModel {
    // 是否删除成功
    @NameInMap("hasDelete")
    public Boolean hasDelete;

    public static DeleteLiveFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveFeedResponseBody self = new DeleteLiveFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public DeleteLiveFeedResponseBody setHasDelete(Boolean hasDelete) {
        this.hasDelete = hasDelete;
        return this;
    }
    public Boolean getHasDelete() {
        return this.hasDelete;
    }

}
