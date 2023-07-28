// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkedu_1_0.models;

import com.aliyun.tea.*;

public class GetTaskListRequest extends TeaModel {
    @NameInMap("operator")
    public String operator;

    @NameInMap("pageNumber")
    public Long pageNumber;

    @NameInMap("pageSize")
    public Long pageSize;

    @NameInMap("taskYear")
    public Long taskYear;

    public static GetTaskListRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskListRequest self = new GetTaskListRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskListRequest setOperator(String operator) {
        this.operator = operator;
        return this;
    }
    public String getOperator() {
        return this.operator;
    }

    public GetTaskListRequest setPageNumber(Long pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Long getPageNumber() {
        return this.pageNumber;
    }

    public GetTaskListRequest setPageSize(Long pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Long getPageSize() {
        return this.pageSize;
    }

    public GetTaskListRequest setTaskYear(Long taskYear) {
        this.taskYear = taskYear;
        return this;
    }
    public Long getTaskYear() {
        return this.taskYear;
    }

}
