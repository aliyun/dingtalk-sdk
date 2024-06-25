// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleBinRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>SPACE</p>
     */
    @NameInMap("recycleBinScope")
    public String recycleBinScope;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>scope_id</p>
     */
    @NameInMap("scopeId")
    public String scopeId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>union_id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static GetRecycleBinRequest build(java.util.Map<String, ?> map) throws Exception {
        GetRecycleBinRequest self = new GetRecycleBinRequest();
        return TeaModel.build(map, self);
    }

    public GetRecycleBinRequest setRecycleBinScope(String recycleBinScope) {
        this.recycleBinScope = recycleBinScope;
        return this;
    }
    public String getRecycleBinScope() {
        return this.recycleBinScope;
    }

    public GetRecycleBinRequest setScopeId(String scopeId) {
        this.scopeId = scopeId;
        return this;
    }
    public String getScopeId() {
        return this.scopeId;
    }

    public GetRecycleBinRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
