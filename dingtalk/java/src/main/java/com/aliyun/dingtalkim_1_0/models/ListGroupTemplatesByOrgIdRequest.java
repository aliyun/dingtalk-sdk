// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListGroupTemplatesByOrgIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static ListGroupTemplatesByOrgIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ListGroupTemplatesByOrgIdRequest self = new ListGroupTemplatesByOrgIdRequest();
        return TeaModel.build(map, self);
    }

    public ListGroupTemplatesByOrgIdRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListGroupTemplatesByOrgIdRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
