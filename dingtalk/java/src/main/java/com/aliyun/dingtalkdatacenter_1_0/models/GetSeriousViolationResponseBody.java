// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetSeriousViolationResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>IN_DATE:列入日期</p>
     * <p>IN_DEPARTMENT:列入决定机关</p>
     * <p>IN_REASON:列入严重违法失信企业名单原因</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
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
