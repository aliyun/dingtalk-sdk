// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetRecycleBinRequest extends TeaModel {
    // 回收站范围类型
    // 枚举值:
    // 	ORG: 企业
    // 	APP: 应用
    // 	SPACE: 空间
    @NameInMap("recycleBinScope")
    public String recycleBinScope;

    // 回收站范围id
    // 根据recycleBinScope传入对应的企业、应用、空间ID
    @NameInMap("scopeId")
    public String scopeId;

    // 用户id
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
