// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetHolderInfoResponseBody extends TeaModel {
    // 返回结果
    // STOCK_TYPE:股东类型
    // STOCK_NAME:股东名称
    // STOCK_PERCENT:持股比例
    // SHOULD_CAPI:认缴出资额
    // SHOULD_CAPI_TIME:认缴出资日期
    @NameInMap("data")
    public String data;

    // 总条数
    @NameInMap("total")
    public Long total;

    public static GetHolderInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetHolderInfoResponseBody self = new GetHolderInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetHolderInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetHolderInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
