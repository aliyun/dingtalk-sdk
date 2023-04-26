// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetEduUserIdentityRequest extends TeaModel {
    @NameInMap("unionId")
    public String unionId;

    public static GetEduUserIdentityRequest build(java.util.Map<String, ?> map) throws Exception {
        GetEduUserIdentityRequest self = new GetEduUserIdentityRequest();
        return TeaModel.build(map, self);
    }

    public GetEduUserIdentityRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
