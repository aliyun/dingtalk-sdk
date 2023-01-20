// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class GetBranchInfoResponseBody extends TeaModel {
    /**
     * <p>返回结果</p>
     * <p>EntName:分支机构名称</p>
     * <p>EntStatus:经营状态</p>
     * <p>OperName:负责人</p>
     * <p>EsDate:成立日期</p>
     */
    @NameInMap("data")
    public String data;

    /**
     * <p>总条数</p>
     */
    @NameInMap("total")
    public Long total;

    public static GetBranchInfoResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetBranchInfoResponseBody self = new GetBranchInfoResponseBody();
        return TeaModel.build(map, self);
    }

    public GetBranchInfoResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public GetBranchInfoResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
