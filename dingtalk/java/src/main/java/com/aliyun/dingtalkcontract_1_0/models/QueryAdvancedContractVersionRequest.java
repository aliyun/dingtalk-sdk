// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontract_1_0.models;

import com.aliyun.tea.*;

public class QueryAdvancedContractVersionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>dingff048f704a8b6d8e4ac5d6980864d335</p>
     */
    @NameInMap("corpId")
    public String corpId;

    @NameInMap("extension")
    public java.util.Map<String, String> extension;

    public static QueryAdvancedContractVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryAdvancedContractVersionRequest self = new QueryAdvancedContractVersionRequest();
        return TeaModel.build(map, self);
    }

    public QueryAdvancedContractVersionRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public QueryAdvancedContractVersionRequest setExtension(java.util.Map<String, String> extension) {
        this.extension = extension;
        return this;
    }
    public java.util.Map<String, String> getExtension() {
        return this.extension;
    }

}
