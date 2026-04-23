// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktalent_tag_1_0.models;

import com.aliyun.tea.*;

public class TalentV2QueryTagLikeListRequest extends TeaModel {
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentV2QueryTagLikeListRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentV2QueryTagLikeListRequest self = new TalentV2QueryTagLikeListRequest();
        return TeaModel.build(map, self);
    }

    public TalentV2QueryTagLikeListRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public TalentV2QueryTagLikeListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
