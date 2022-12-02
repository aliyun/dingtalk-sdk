// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class SubscribeEventRequest extends TeaModel {
    // 订阅范围
    // 枚举值:
    // 	SPACE: 空间
    @NameInMap("scope")
    public String scope;

    // 订阅范围对应的id
    // ORG时，对应的是企业id
    // APP时，对应的是应用id
    // SPACE时，对应的是空间id
    // 枚举值:
    // 	SPACE: 空间
    @NameInMap("scopeId")
    public String scopeId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static SubscribeEventRequest build(java.util.Map<String, ?> map) throws Exception {
        SubscribeEventRequest self = new SubscribeEventRequest();
        return TeaModel.build(map, self);
    }

    public SubscribeEventRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public SubscribeEventRequest setScopeId(String scopeId) {
        this.scopeId = scopeId;
        return this;
    }
    public String getScopeId() {
        return this.scopeId;
    }

    public SubscribeEventRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
