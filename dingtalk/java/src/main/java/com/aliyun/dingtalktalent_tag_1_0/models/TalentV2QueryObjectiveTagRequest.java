// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryObjectiveTagRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentV2QueryObjectiveTagRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryObjectiveTagRequest self = new TalentV2QueryObjectiveTagRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryObjectiveTagRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
