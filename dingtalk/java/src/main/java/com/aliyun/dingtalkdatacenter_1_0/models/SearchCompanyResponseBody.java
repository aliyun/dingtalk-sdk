// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdatacenter_1_0.models;

import com.aliyun.tea.*;

public class SearchCompanyResponseBody extends TeaModel {
    // 返回数据结果
    @NameInMap("data")
    public String data;

    // 总条数
    @NameInMap("total")
    public Long total;

    public static SearchCompanyResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchCompanyResponseBody self = new SearchCompanyResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchCompanyResponseBody setData(String data) {
        this.data = data;
        return this;
    }
    public String getData() {
        return this.data;
    }

    public SearchCompanyResponseBody setTotal(Long total) {
        this.total = total;
        return this;
    }
    public Long getTotal() {
        return this.total;
    }

}
