// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ListSceneGroupsByTemplateIdRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static ListSceneGroupsByTemplateIdRequest build(java.util.Map<String, ?> map) throws Exception {
        ListSceneGroupsByTemplateIdRequest self = new ListSceneGroupsByTemplateIdRequest();
        return TeaModel.build(map, self);
    }

    public ListSceneGroupsByTemplateIdRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public ListSceneGroupsByTemplateIdRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
