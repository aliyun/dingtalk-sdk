// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkding_one_1_0.models;

import com.aliyun.tea.*;

public class DeliverOneFeedResponseBody extends TeaModel {
    @NameInMap("result")
    public String result;

    public static DeliverOneFeedResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DeliverOneFeedResponseBody self = new DeliverOneFeedResponseBody();
        return TeaModel.build(map, self);
    }

    public DeliverOneFeedResponseBody setResult(String result) {
        this.result = result;
        return this;
    }
    public String getResult() {
        return this.result;
    }

}
