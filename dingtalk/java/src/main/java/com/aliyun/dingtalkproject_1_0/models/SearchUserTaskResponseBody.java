// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchUserTaskResponseBody extends TeaModel {
    /**
     * <p>分页标，供分页使用，下一页token。</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>请求 ID，请求异常时可提供此 ID，进行问题排查。</p>
     */
    @NameInMap("requestId")
    public String requestId;

    /**
     * <p>任务ID列表。</p>
     */
    @NameInMap("result")
    public java.util.List<String> result;

    /**
     * <p>任务总数。</p>
     */
    @NameInMap("totalSize")
    public Integer totalSize;

    public static SearchUserTaskResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchUserTaskResponseBody self = new SearchUserTaskResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchUserTaskResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchUserTaskResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SearchUserTaskResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

    public SearchUserTaskResponseBody setTotalSize(Integer totalSize) {
        this.totalSize = totalSize;
        return this;
    }
    public Integer getTotalSize() {
        return this.totalSize;
    }

}
