// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class PageListObjectiveProgressRequest extends TeaModel {
    /**
     * <p>目标id</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    /**
     * <p>页数</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    public static PageListObjectiveProgressRequest build(java.util.Map<String, ?> map) throws Exception {
        PageListObjectiveProgressRequest self = new PageListObjectiveProgressRequest();
        return TeaModel.build(map, self);
    }

    public PageListObjectiveProgressRequest setObjectiveId(String objectiveId) {
        this.objectiveId = objectiveId;
        return this;
    }
    public String getObjectiveId() {
        return this.objectiveId;
    }

    public PageListObjectiveProgressRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PageListObjectiveProgressRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
