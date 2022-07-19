// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_1_0.models;

import com.aliyun.tea.*;

public class GetCurrentAppRequest extends TeaModel {
    // 应用归属企业的Id
    @NameInMap("corpId")
    public String corpId;

    // 用户id
    @NameInMap("unionId")
    public String unionId;

    public static GetCurrentAppRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCurrentAppRequest self = new GetCurrentAppRequest();
        return TeaModel.build(map, self);
    }

    public GetCurrentAppRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetCurrentAppRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
