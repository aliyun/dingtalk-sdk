// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class UpdateLiveFeedResponseBody extends TeaModel {
    // 是否修改成功
    @NameInMap("hasUpdate")
    public Boolean hasUpdate;

    public static UpdateLiveFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateLiveFeedResponseBody self = new UpdateLiveFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateLiveFeedResponseBody setHasUpdate(Boolean hasUpdate) {
        this.hasUpdate = hasUpdate;
        return this;
    }
    public Boolean getHasUpdate() {
        return this.hasUpdate;
    }

}
