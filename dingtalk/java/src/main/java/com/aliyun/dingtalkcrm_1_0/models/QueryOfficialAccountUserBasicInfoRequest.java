// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcrm_1_0.models;

import com.aliyun.tea.*;

public class QueryOfficialAccountUserBasicInfoRequest extends TeaModel {
    @NameInMap("bindingToken")
    public String bindingToken;

    @NameInMap("unionId")
    public String unionId;

    public static QueryOfficialAccountUserBasicInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryOfficialAccountUserBasicInfoRequest self = new QueryOfficialAccountUserBasicInfoRequest();
        return TeaModel.build(map, self);
    }

    public QueryOfficialAccountUserBasicInfoRequest setBindingToken(String bindingToken) {
        this.bindingToken = bindingToken;
        return this;
    }
    public String getBindingToken() {
        return this.bindingToken;
    }

    public QueryOfficialAccountUserBasicInfoRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
