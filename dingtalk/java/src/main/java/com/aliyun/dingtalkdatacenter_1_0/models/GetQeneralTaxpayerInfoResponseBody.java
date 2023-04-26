// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetQeneralTaxpayerInfoResponseBody extends TeaModel {
    @NameInMap("data")
    public String data;

    @NameInMap("total")
    public Long total;

    public static GetQeneralTaxpayerInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetQeneralTaxpayerInfoResponseBody self = new GetQeneralTaxpayerInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetQeneralTaxpayerInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetQeneralTaxpayerInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
