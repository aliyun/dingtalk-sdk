// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetHolderInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>STOCK_TYPE:股东类型</p>
     * <p>STOCK_NAME:股东名称</p>
     * <p>STOCK_PERCENT:持股比例</p>
     * <p>SHOULD_CAPI:认缴出资额</p>
     * <p>SHOULD_CAPI_TIME:认缴出资日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
