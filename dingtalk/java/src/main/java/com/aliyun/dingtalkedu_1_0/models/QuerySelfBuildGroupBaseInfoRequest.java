// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class QuerySelfBuildGroupBaseInfoRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    public static QuerySelfBuildGroupBaseInfoRequest build(java.util.Map<String, ?> map) throws Exception {
        QuerySelfBuildGroupBaseInfoRequest self = new QuerySelfBuildGroupBaseInfoRequest();
        return TeaModel.build(map, self);
    }

    public QuerySelfBuildGroupBaseInfoRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

}
