// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkexclusive_1_0.models;

import com.aliyun.tea.*;

public class GetPrivateStoreFileInfosByPageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>1680493837426</p>
     */
    @NameInMap("fileCreateTime")
    public Long fileCreateTime;

    @NameInMap("fileStatus")
    public String fileStatus;

    @NameInMap("maxResults")
    public Integer maxResults;

    @NameInMap("nextToken")
    public String nextToken;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("order")
    public String order;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("targetCorpId")
    public String targetCorpId;

    public static GetPrivateStoreFileInfosByPageRequest build(java.util.Map<String, ?> map) throws Exception {
        GetPrivateStoreFileInfosByPageRequest self = new GetPrivateStoreFileInfosByPageRequest();
        return TeaModel.build(map, self);
    }

    public GetPrivateStoreFileInfosByPageRequest setFileCreateTime(Long fileCreateTime) {
        this.fileCreateTime = fileCreateTime;
        return this;
    }
    public Long getFileCreateTime() {
        return this.fileCreateTime;
    }

    public GetPrivateStoreFileInfosByPageRequest setFileStatus(String fileStatus) {
        this.fileStatus = fileStatus;
        return this;
    }
    public String getFileStatus() {
        return this.fileStatus;
    }

    public GetPrivateStoreFileInfosByPageRequest setMaxResults(Integer maxResults) {
        this.maxResults = maxResults;
        return this;
    }
    public Integer getMaxResults() {
        return this.maxResults;
    }

    public GetPrivateStoreFileInfosByPageRequest setNextToken(String nextToken) {
        this.nextToken = nextToken;
        return this;
    }
    public String getNextToken() {
        return this.nextToken;
    }

    public GetPrivateStoreFileInfosByPageRequest setOrder(String order) {
        this.order = order;
        return this;
    }
    public String getOrder() {
        return this.order;
    }

    public GetPrivateStoreFileInfosByPageRequest setTargetCorpId(String targetCorpId) {
        this.targetCorpId = targetCorpId;
        return this;
    }
    public String getTargetCorpId() {
        return this.targetCorpId;
    }

}
