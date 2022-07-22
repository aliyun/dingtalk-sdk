// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class ExternalQueryExternalBelongMainOrgResponseBody extends TeaModel {
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("corpName")
    public String corpName;

    public static ExternalQueryExternalBelongMainOrgResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExternalQueryExternalBelongMainOrgResponseBody self = new ExternalQueryExternalBelongMainOrgResponseBody();
        return TeaModel.build(map, self);
    }

    public ExternalQueryExternalBelongMainOrgResponseBody setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public ExternalQueryExternalBelongMainOrgResponseBody setCorpName(String corpName) {
        this.corpName = corpName;
        return this;
    }
    public String getCorpName() {
        return this.corpName;
    }

}
