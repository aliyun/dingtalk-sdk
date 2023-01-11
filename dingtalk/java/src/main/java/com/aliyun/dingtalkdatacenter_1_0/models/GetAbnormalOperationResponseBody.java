// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAbnormalOperationResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>DEPARTMENT:列入决定机关</p>
     * <p>IN_REASON 列入原因</p>
     * <p>OUT_DATE:移出日期</p>
     * <p>OUT_DEPARTMENT:移出决定机关</p>
     * <p>OUT_REASON:移出原因</p>
     * <p>IN_DATE:列入日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetAbnormalOperationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAbnormalOperationResponseBody self = new GetAbnormalOperationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAbnormalOperationResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetAbnormalOperationResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
