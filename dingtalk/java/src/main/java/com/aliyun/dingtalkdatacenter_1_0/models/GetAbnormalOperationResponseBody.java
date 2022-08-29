// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetAbnormalOperationResponseBody extends TeaModel {
    // 返回结果
    // DEPARTMENT:列入决定机关
    // IN_REASON 列入原因
    // OUT_DATE:移出日期
    // OUT_DEPARTMENT:移出决定机关
    // OUT_REASON:移出原因
    // IN_DATE:列入日期
    @NameInMap("data")
    public String data;

    // 总条数
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
