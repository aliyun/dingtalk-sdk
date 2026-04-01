// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryObjectiveTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentQueryObjectiveTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryObjectiveTagRequest self = new TalentQueryObjectiveTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentQueryObjectiveTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
