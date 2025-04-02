// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketIsvServiceResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    public static DataMarketIsvServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DataMarketIsvServiceResponseBody self = new DataMarketIsvServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public DataMarketIsvServiceResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
