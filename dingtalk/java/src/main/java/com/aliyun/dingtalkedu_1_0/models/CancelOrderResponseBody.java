// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class CancelOrderResponseBody extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("needRetry")
    public Boolean needRetry;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("tradeAction")
    public String tradeAction;

    public static CancelOrderResponseBody build(java.util.Map<String, ?> map) throws Exception {
        CancelOrderResponseBody self = new CancelOrderResponseBody();
        return TeaModel.build(map, self);
    }

    public CancelOrderResponseBody setNeedRetry(Boolean needRetry) {
        this.needRetry = needRetry;
        return this;
    }
    public Boolean getNeedRetry() {
        return this.needRetry;
    }

    public CancelOrderResponseBody setTradeAction(String tradeAction) {
        this.tradeAction = tradeAction;
        return this;
    }
    public String getTradeAction() {
        return this.tradeAction;
    }

}
