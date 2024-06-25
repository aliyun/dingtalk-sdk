// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryIntegratedTodoTaskRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>1660036833411</p>
     */
    @NameInMap("createBefore")
    public Long createBefore;

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

    public static QueryIntegratedTodoTaskRequest build(java.util.Map<String, ?> map) throws Exception {
        QueryIntegratedTodoTaskRequest self = new QueryIntegratedTodoTaskRequest();
        return TeaModel.build(map, self);
    }

    public QueryIntegratedTodoTaskRequest setCreateBefore(Long createBefore) {
        this.createBefore = createBefore;
        return this;
    }
    public Long getCreateBefore() {
        return this.createBefore;
    }

    public QueryIntegratedTodoTaskRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public QueryIntegratedTodoTaskRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public QueryIntegratedTodoTaskRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
