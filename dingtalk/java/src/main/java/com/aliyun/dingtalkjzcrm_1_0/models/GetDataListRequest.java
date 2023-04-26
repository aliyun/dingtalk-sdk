// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataListRequest extends TeaModel {
    @NameInMap("datatype")
    public String datatype;

    @NameInMap("page")
    public Long page;

    @NameInMap("pagesize")
    public Long pagesize;

    public static GetDataListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDataListRequest self = new GetDataListRequest();
        return TeaModel.build(map, self);
    }

    public GetDataListRequest setDatatype(String datatype) {
        this.datatype = datatype;
        return this;
    }
    public String getDatatype() {
        return this.datatype;
    }

    public GetDataListRequest setPage(Long page) {
        this.page = page;
        return this;
    }
    public Long getPage() {
        return this.page;
    }

    public GetDataListRequest setPagesize(Long pagesize) {
        this.pagesize = pagesize;
        return this;
    }
    public Long getPagesize() {
        return this.pagesize;
    }

}
