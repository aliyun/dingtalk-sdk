// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkjzcrm_1_0.models;

import com.aliyun.tea.*;

public class GetDataListRequest extends TeaModel {
    /**
     * <p>数据类型，参考数据类型ID对照表</p>
     */
    @NameInMap("datatype")
    public String datatype;

    /**
     * <p>页码</p>
     */
    @NameInMap("page")
    public Long page;

    /**
     * <p>分页条数</p>
     */
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
