// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class TodoTasksRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("actionerUserId")
    public String actionerUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("managerUserId")
    public String managerUserId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("maxResults")
    public Integer maxResults;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("nextToken")
    public Integer nextToken;

    public static TodoTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        TodoTasksRequest self = new TodoTasksRequest();
        return TeaModel.build(map, self);
    }

    public TodoTasksRequest setActionerUserId(String actionerUserId) {
        this.actionerUserId = actionerUserId;
        return this;
    }
    public String getActionerUserId() {
        return this.actionerUserId;
    }

    public TodoTasksRequest setManagerUserId(String managerUserId) {
        this.managerUserId = managerUserId;
        return this;
    }
    public String getManagerUserId() {
        return this.managerUserId;
    }

    public TodoTasksRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public TodoTasksRequest setNextToken(Integer nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Integer getNextToken() {
        return this.nextToken;
    }

}
