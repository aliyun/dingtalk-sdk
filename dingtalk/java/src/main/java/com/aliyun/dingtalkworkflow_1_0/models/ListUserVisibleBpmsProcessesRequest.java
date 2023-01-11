// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkworkflow_1_0.models;

import com.aliyun.tea.*;

public class ListUserVisibleBpmsProcessesRequest extends TeaModel {
    /**
     * <p>分页大小，最大可设置成100。</p>
     */
    @NameInMap("maxResults")
    public Long maxResults;

    /**
     * <p>分页游标，从0开始。根据返回结果里的nextToken是否为空来判断是否还有下一页，且再次调用时设置成nextToken的最新值。</p>
     */
    @NameInMap("nextToken")
    public Long nextToken;

    /**
     * <p>要查询的员工的userid。不传表示查询企业下所有审批表单。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static ListUserVisibleBpmsProcessesRequest build(java.util.Map<String, ?> map) throws Exception {
        ListUserVisibleBpmsProcessesRequest self = new ListUserVisibleBpmsProcessesRequest();
        return TeaModel.build(map, self);
    }

    public ListUserVisibleBpmsProcessesRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListUserVisibleBpmsProcessesRequest setNextToken(Long nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public Long getNextToken() {
        return this.nextToken;
    }

    public ListUserVisibleBpmsProcessesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
