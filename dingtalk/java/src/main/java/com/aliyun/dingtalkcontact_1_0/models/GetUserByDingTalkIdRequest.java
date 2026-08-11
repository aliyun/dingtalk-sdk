// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class GetUserByDingTalkIdRequest extends TeaModel {
    @NameInMap("dingtalkId")
    public String dingtalkId;

    public static GetUserByDingTalkIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetUserByDingTalkIdRequest self = new GetUserByDingTalkIdRequest();
        return TeaModel.build(map, self);
    }

    public GetUserByDingTalkIdRequest setDingtalkId(String dingtalkId) {
        this.dingtalkId = dingtalkId;
        return this;
    }
    public String getDingtalkId() {
        return this.dingtalkId;
    }

}
