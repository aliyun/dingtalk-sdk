// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class QueryPayAccountListRequest extends TeaModel {
    // Isv coprId
    @NameInMap("isvCorpId")
    public String isvCorpId;

    // 应用suiteId
    @NameInMap("suiteId")
    public String suiteId;

    // 组织corpId
    @NameInMap("corpId")
    public String corpId;

    public static QueryPayAccountListRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryPayAccountListRequest self = new QueryPayAccountListRequest();
        return TeaModel.build(map, self);
    }

    public QueryPayAccountListRequest setIsvCorpId(String isvCorpId) {
        this.isvCorpId = isvCorpId;
        return this;
    }
    public String getIsvCorpId() {
        return this.isvCorpId;
    }

    public QueryPayAccountListRequest setSuiteId(String suiteId) {
        this.suiteId = suiteId;
        return this;
    }
    public String getSuiteId() {
        return this.suiteId;
    }

    public QueryPayAccountListRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
