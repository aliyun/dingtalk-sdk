// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpAccomplishmentTasksRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>[&quot;APP_xxx&quot;,&quot;APP_xxx&quot;]</p>
     */
    @NameInMap("appTypes")
    public String appTypes;

    /**
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>[&quot;xx&quot;,&quot;xxx&quot;]</p>
     */
    @NameInMap("processCodes")
    public String processCodes;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>未知</p>
     */
    @NameInMap("token")
    public String token;

    public static GetCorpAccomplishmentTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorpAccomplishmentTasksRequest self = new GetCorpAccomplishmentTasksRequest();
        return TeaModel.build(map, self);
    }

    public GetCorpAccomplishmentTasksRequest setAppTypes(String appTypes) {
        this.appTypes = appTypes;
        return this;
    }
    public String getAppTypes() {
        return this.appTypes;
    }

    public GetCorpAccomplishmentTasksRequest setCreateFromTimeGMT(Long createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public Long getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetCorpAccomplishmentTasksRequest setCreateToTimeGMT(Long createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public Long getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetCorpAccomplishmentTasksRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public GetCorpAccomplishmentTasksRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetCorpAccomplishmentTasksRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetCorpAccomplishmentTasksRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetCorpAccomplishmentTasksRequest setProcessCodes(String processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public String getProcessCodes() {
        return this.processCodes;
    }

    public GetCorpAccomplishmentTasksRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
