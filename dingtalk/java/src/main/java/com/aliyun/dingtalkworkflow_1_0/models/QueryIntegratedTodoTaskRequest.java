// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class QueryIntegratedTodoTaskRequest extends TeaModel {
    // 在此时间戳之前创建的
    @NameInMap("createBefore")
    public Long createBefore;

    // 第几页，取值范围为 1 ≤ page ≤ 1000
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小，取值范围为 1 ≤ pageSize ≤ 40
    @NameInMap("pageSize")
    public Integer pageSize;

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
