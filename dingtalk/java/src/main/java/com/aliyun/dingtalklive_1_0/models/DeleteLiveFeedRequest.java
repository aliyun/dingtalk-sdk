// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveFeedRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1206186351746728</p>
     */
    @NameInMap("userId")
    public String userId;

    public static DeleteLiveFeedRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveFeedRequest self = new DeleteLiveFeedRequest();
        return TeaModel.build(map, self);
    }

    public DeleteLiveFeedRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
