// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeEventRequest extends TeaModel {
    /**
     * <p>订阅范围</p>
     * <p>枚举值:</p>
     * <p>	SPACE: 空间</p>
     */
    @NameInMap("scope")
    public String scope;

    /**
     * <p>订阅范围对应的id</p>
     * <p>ORG时，对应的是企业id</p>
     * <p>APP时，对应的是应用id</p>
     * <p>SPACE时，对应的是空间id</p>
     */
    @NameInMap("scopeId")
    public String scopeId;

    /**
     * <p>用户id</p>
     */
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
