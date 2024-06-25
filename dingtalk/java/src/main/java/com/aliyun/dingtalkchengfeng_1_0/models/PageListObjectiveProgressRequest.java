// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkchengfeng_1_0.models;

import com.aliyun.tea.*;

public class PageListObjectiveProgressRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("objectiveId")
    public String objectiveId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
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
