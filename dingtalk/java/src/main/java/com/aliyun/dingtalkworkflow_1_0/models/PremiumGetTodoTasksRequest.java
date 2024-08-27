// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class PremiumGetTodoTasksRequest extends TeaModel {
    /**
     * <p>Use the UTC time format: yyyy-MM-ddTHH:mmZ</p>
     */
    @NameInMap("createBefore")
    public String createBefore;

    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>20</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>manager001</p>
     */
    @NameInMap("userId")
    public String userId;

    public static PremiumGetTodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        PremiumGetTodoTasksRequest self = new PremiumGetTodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public PremiumGetTodoTasksRequest setCreateBefore(String createBefore) {
        this.createBefore = createBefore;
        return this;
    }
    public String getCreateBefore() {
        return this.createBefore;
    }

    public PremiumGetTodoTasksRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public PremiumGetTodoTasksRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public PremiumGetTodoTasksRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public PremiumGetTodoTasksRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
