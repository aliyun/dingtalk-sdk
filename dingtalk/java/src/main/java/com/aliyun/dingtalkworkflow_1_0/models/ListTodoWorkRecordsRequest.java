// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListTodoWorkRecordsRequest extends TeaModel {
    /**
     * <p>分页大小，最大值50。</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>分页游标。</p>
     * <br>
     * <p>如果是首次调用，该参数传0。</p>
     * <p>如果是非首次调用，该参数传上次调用时返回的nextToken。</p>
     * <br>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    /**
     * <p>待办事项的状态：</p>
     * <br>
     * <p>0：待处理</p>
     * <br>
     * <p>-1：已经移除</p>
     * <br>
     */
    @NameInMap("status")
    public Integer status;

    /**
     * <p>要查询的执行人userid。</p>
     */
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
