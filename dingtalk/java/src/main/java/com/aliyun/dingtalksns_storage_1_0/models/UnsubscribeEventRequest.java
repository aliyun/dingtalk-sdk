// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksns_storage_1_0.models;

import com.aliyun.tea.*;

public class UnsubscribeEventRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scope")
    public String scope;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("scopeId")
    public String scopeId;

    /**
     * <p>This parameter is required.</p>
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
