// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpLevelByAccountIdRequest extends TeaModel {
    @NameInMap("accountId")
    public String accountId;

    public static GetCorpLevelByAccountIdRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorpLevelByAccountIdRequest self = new GetCorpLevelByAccountIdRequest();
        return TeaModel.build(map, self);
    }

    public GetCorpLevelByAccountIdRequest setAccountId(String accountId) {
        this.accountId = accountId;
        return this;
    }
    public String getAccountId() {
        return this.accountId;
    }

}
