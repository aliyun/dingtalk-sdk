// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkbizfinance_2_0.models;

import com.aliyun.tea.*;

public class BatchQueryPaymentRecallFileShrinkRequest extends TeaModel {
    @NameInMap("detailIdList")
    public String detailIdListShrink;

    @NameInMap("opeator")
    public String opeator;

    public static BatchQueryPaymentRecallFileShrinkRequest build(java.util.Map<String, ?> map) throws Exception {
        BatchQueryPaymentRecallFileShrinkRequest self = new BatchQueryPaymentRecallFileShrinkRequest();
        return TeaModel.build(map, self);
    }

    public BatchQueryPaymentRecallFileShrinkRequest setDetailIdListShrink(String detailIdListShrink) {
        this.detailIdListShrink = detailIdListShrink;
        return this;
    }
    public String getDetailIdListShrink() {
        return this.detailIdListShrink;
    }

    public BatchQueryPaymentRecallFileShrinkRequest setOpeator(String opeator) {
        this.opeator = opeator;
        return this;
    }
    public String getOpeator() {
        return this.opeator;
    }

}
