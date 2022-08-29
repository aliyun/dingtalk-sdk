// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSeriousViolationResponseBody extends TeaModel {
    // 返回结果
    // IN_DATE:列入日期
    // IN_DEPARTMENT:列入决定机关
    // IN_REASON:列入严重违法失信企业名单原因
    @NameInMap("data")
    public String data;

    // 总条数
    @NameInMap("total")
    public Long total;

    public static GetSeriousViolationResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetSeriousViolationResponseBody self = new GetSeriousViolationResponseBody();
        return TeaModel.build(map, self);
    }

    public GetSeriousViolationResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetSeriousViolationResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
