// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkesign_2_0.models;

import com.aliyun.tea.*;

public class GetCorpInfoResponseBody extends TeaModel {
    @NameInMap("isRealName")
    public String isRealName;

    @NameInMap("orgRealName")
    public String orgRealName;

    public static GetCorpInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetCorpInfoResponseBody self = new GetCorpInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetCorpInfoResponseBody setIsRealName(String isRealName) {
        this.isRealName = isRealName;
        return this;
    }
    public String getIsRealName() {
        return this.isRealName;
    }

    public GetCorpInfoResponseBody setOrgRealName(String orgRealName) {
        this.orgRealName = orgRealName;
        return this;
    }
    public String getOrgRealName() {
        return this.orgRealName;
    }

}
