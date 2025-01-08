// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class DataMarketServiceResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    public static DataMarketServiceResponseBody build(java.util.Map<String, ?> map) throws Exception {
        DataMarketServiceResponseBody self = new DataMarketServiceResponseBody();
        return TeaModel.build(map, self);
    }

    public DataMarketServiceResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

}
