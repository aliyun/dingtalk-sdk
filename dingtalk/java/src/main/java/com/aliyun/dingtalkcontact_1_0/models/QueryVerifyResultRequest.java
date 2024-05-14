// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class QueryVerifyResultRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("verifyId")
    public String verifyId;

    public static QueryVerifyResultRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryVerifyResultRequest self = new QueryVerifyResultRequest();
        return TeaModel.build(map, self);
    }

    public QueryVerifyResultRequest setVerifyId(String verifyId) {
        this.verifyId = verifyId;
        return this;
    }
    public String getVerifyId() {
        return this.verifyId;
    }

}
