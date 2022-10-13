// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListTodoWorkRecordsRequest extends TeaModel {
    // 分页大小，最大值50。
    @NameInMap("maxResults")
    public Integer maxResults;

    // 分页游标。
    // 
    // 如果是首次调用，该参数传0。
    // 如果是非首次调用，该参数传上次调用时返回的nextToken。
    // 
    @NameInMap("nextToken")
    public Integer nextToken;

    // 待办事项的状态：
    // 
    // 0：待处理
    // 
    // -1：已经移除
    // 
    @NameInMap("status")
    public Integer status;

    // 要查询的执行人userid。
    @NameInMap("userId")
    public String userId;

    public static ListTodoWorkRecordsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListTodoWorkRecordsRequest self = new ListTodoWorkRecordsRequest();
        return TeaModel.build(map, self);
    }

    public ListTodoWorkRecordsRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public ListTodoWorkRecordsRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

    public ListTodoWorkRecordsRequest setStatus(Integer status) {
        this.status = status;
        return this;
    }
    public Integer getStatus() {
        return this.status;
    }

    public ListTodoWorkRecordsRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
