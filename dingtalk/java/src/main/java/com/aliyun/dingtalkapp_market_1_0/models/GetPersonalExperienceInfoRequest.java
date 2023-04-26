// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkapp_market_1_0.models;

import com.aliyun.tea.*;

public class GetPersonalExperienceInfoRequest extends TeaModel {
    @NameInMap("userId")
    public String userId;

    public static GetPersonalExperienceInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPersonalExperienceInfoRequest self = new GetPersonalExperienceInfoRequest();
        return TeaModel.build(map, self);
    }

    public GetPersonalExperienceInfoRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
