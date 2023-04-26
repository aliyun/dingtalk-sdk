// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class ListAppRoleScopesRequest extends TeaModel {
    @NameInMap("nextToken")
    public Long nextToken;

    @NameInMap("size")
    public Long size;

    public static ListAppRoleScopesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListAppRoleScopesRequest self = new ListAppRoleScopesRequest();
        return TeaModel.build(map, self);
    }

    public ListAppRoleScopesRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListAppRoleScopesRequest setSize(Long size) {
        this.size = size;
        return this;
    }
    public Long getSize() {
        return this.size;
    }

}
