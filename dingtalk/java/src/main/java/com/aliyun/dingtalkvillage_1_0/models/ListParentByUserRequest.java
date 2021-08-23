// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkvillage_1_0.models;

import com.aliyun.tea.*;

public class ListParentByUserRequest extends TeaModel {
    // 真实请求的组织corpId
    @NameInMap("subCorpId")
    public String subCorpId;

    // 用户userId
    @NameInMap("userId")
    public String userId;

    public static ListParentByUserRequest build(java.util.Map<String, ?> map) throws Exception {
        ListParentByUserRequest self = new ListParentByUserRequest();
        return TeaModel.build(map, self);
    }

    public ListParentByUserRequest setSubCorpId(String subCorpId) {
        this.subCorpId = subCorpId;
        return this;
    }
    public String getSubCorpId() {
        return this.subCorpId;
    }

    public ListParentByUserRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
