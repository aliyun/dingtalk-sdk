// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class GetTbOrgIdByDingOrgIdRequest extends TeaModel {
    // 操作者userId
    @NameInMap("optUserId")
    public String optUserId;

    public static GetTbOrgIdByDingOrgIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTbOrgIdByDingOrgIdRequest self = new GetTbOrgIdByDingOrgIdRequest();
        return TeaModel.build(map, self);
    }

    public GetTbOrgIdByDingOrgIdRequest setOptUserId(String optUserId) {
        this.optUserId = optUserId;
        return this;
    }
    public String getOptUserId() {
        return this.optUserId;
    }

}
