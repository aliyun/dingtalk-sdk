// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class SearchAllTasksByTqlResponseBody extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>f279e812-e431-428d-846d-cxxxxxx</p>
     */
    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <strong>example:</strong>
     * <p>60BEE277-347B-1D5E-B6A4-E90788531911</p>
     */
    @NameInMap("requestId")
    public String requestId;

    @NameInMap("result")
    public java.util.List<String> result;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("totalSize")
    public Integer totalSize;

    public static SearchAllTasksByTqlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SearchAllTasksByTqlResponseBody self = new SearchAllTasksByTqlResponseBody();
        return TeaModel.build(map, self);
    }

    public SearchAllTasksByTqlResponseBody setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public SearchAllTasksByTqlResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public SearchAllTasksByTqlResponseBody setResult(java.util.List<String> result) {
        this.result = result;
        return this;
    }
    public java.util.List<String> getResult() {
        return this.result;
    }

    public SearchAllTasksByTqlResponseBody setTotalSize(Integer totalSize) {
        this.totalSize = totalSize;
        return this;
    }
    public Integer getTotalSize() {
        return this.totalSize;
    }

}
