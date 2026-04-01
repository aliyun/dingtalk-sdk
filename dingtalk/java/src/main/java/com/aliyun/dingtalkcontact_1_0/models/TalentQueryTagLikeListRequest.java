// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TalentQueryTagLikeListRequest extends TeaModel {
    @NameInMap("operatorUserId")
    public String operatorUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("userId")
    public String userId;

    public static TalentQueryTagLikeListRequest build(java.util.Map<String, ?> map) throws Exception {
        TalentQueryTagLikeListRequest self = new TalentQueryTagLikeListRequest();
        return TeaModel.build(map, self);
    }

    public TalentQueryTagLikeListRequest setOperatorUserId(String operatorUserId) {
        this.operatorUserId = operatorUserId;
        return this;
    }
    public String getOperatorUserId() {
        return this.operatorUserId;
    }

    public TalentQueryTagLikeListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
