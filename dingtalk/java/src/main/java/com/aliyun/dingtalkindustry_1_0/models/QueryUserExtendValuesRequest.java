// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryUserExtendValuesRequest extends TeaModel {
    // 组织id
    @NameInMap("dingOrgId")
    public Long dingOrgId;

    // userId列表
    @NameInMap("userIds")
    public java.util.List<String> userIds;

    // 用户拓展key
    @NameInMap("userExtendKey")
    public String userExtendKey;

    public static QueryUserExtendValuesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryUserExtendValuesRequest self = new QueryUserExtendValuesRequest();
        return TeaModel.build(map, self);
    }

    public QueryUserExtendValuesRequest setDingOrgId(Long dingOrgId) {
        this.dingOrgId = dingOrgId;
        return this;
    }
    public Long getDingOrgId() {
        return this.dingOrgId;
    }

    public QueryUserExtendValuesRequest setUserIds(java.util.List<String> userIds) {
        this.userIds = userIds;
        return this;
    }
    public java.util.List<String> getUserIds() {
        return this.userIds;
    }

    public QueryUserExtendValuesRequest setUserExtendKey(String userExtendKey) {
        this.userExtendKey = userExtendKey;
        return this;
    }
    public String getUserExtendKey() {
        return this.userExtendKey;
    }

}
