// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkindustry_1_0.models;

import com.aliyun.tea.*;

public class QueryConvertRulesRequest extends TeaModel {
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNo")
    public Long pageNo;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageSize")
    public Long pageSize;

    public static QueryConvertRulesRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryConvertRulesRequest self = new QueryConvertRulesRequest();
        return TeaModel.build(map, self);
    }

    public QueryConvertRulesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public QueryConvertRulesRequest setPageNo(Long pageNo) {
        this.pageNo = pageNo;
        return this;
    }
    public Long getPageNo() {
        return this.pageNo;
    }

    public QueryConvertRulesRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

}
