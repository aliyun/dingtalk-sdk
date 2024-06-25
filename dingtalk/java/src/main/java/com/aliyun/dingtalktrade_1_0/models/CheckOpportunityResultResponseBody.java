// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CheckOpportunityResultResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("bizSuccess")
    public Boolean bizSuccess;

    public static CheckOpportunityResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CheckOpportunityResultResponseBody self = new CheckOpportunityResultResponseBody();
        return TeaModel.build(map, self);
    }

    public CheckOpportunityResultResponseBody setBizSuccess(Boolean bizSuccess) {
        this.bizSuccess = bizSuccess;
        return this;
    }
    public Boolean getBizSuccess() {
        return this.bizSuccess;
    }

}
