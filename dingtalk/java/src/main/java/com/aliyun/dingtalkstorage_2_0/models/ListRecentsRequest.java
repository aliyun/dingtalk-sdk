// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class ListRecentsRequest extends TeaModel {
    @NameInMap("fileTypes")
    public java.util.List<Long> fileTypes;

    @NameInMap("maxResults")
    public Long maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    @NameInMap("operateTypes")
    public java.util.List<Long> operateTypes;

    @NameInMap("operatorId")
    public String operatorId;

    public static ListRecentsRequest build(java.util.Map<String, ?> map) throws Exception {
        ListRecentsRequest self = new ListRecentsRequest();
        return TeaModel.build(map, self);
    }

    public ListRecentsRequest setFileTypes(java.util.List<Long> fileTypes) {
        this.fileTypes = fileTypes;
        return this;
    }
    public java.util.List<Long> getFileTypes() {
        return this.fileTypes;
    }

    public ListRecentsRequest setMaxResults(Long maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Long getMaxResults() {
        return this.maxResults;
    }

    public ListRecentsRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public ListRecentsRequest setOperateTypes(java.util.List<Long> operateTypes) {
        this.operateTypes = operateTypes;
        return this;
    }
    public java.util.List<Long> getOperateTypes() {
        return this.operateTypes;
    }

    public ListRecentsRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

}
