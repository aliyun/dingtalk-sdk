// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeEventRequest extends TeaModel {
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

    public static UnsubscribeEventRequest build(java.util.Map<String, ?> map) throws Exception {
        UnsubscribeEventRequest self = new UnsubscribeEventRequest();
        return TeaModel.build(map, self);
    }

    public UnsubscribeEventRequest setScope(String scope) {
        this.scope = scope;
        return this;
    }
    public String getScope() {
        return this.scope;
    }

    public UnsubscribeEventRequest setScopeId(String scopeId) {
        this.scopeId = scopeId;
        return this;
    }
    public String getScopeId() {
        return this.scopeId;
    }

    public UnsubscribeEventRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
