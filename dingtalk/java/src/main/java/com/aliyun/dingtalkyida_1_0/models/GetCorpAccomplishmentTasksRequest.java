// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpAccomplishmentTasksRequest extends TeaModel {
    /**
     * <p>应用标识列表</p>
     */
    @NameInMap("appTypes")
    public String appTypes;

    /**
     * <p>创建时间开始</p>
     */
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    /**
     * <p>创建时间结束</p>
     */
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    /**
     * <p>关键词</p>
     */
    @NameInMap("keyword")
    public String keyword;

    /**
     * <p>语言环境</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <p>当前页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>每页记录数</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>流程code列表</p>
     */
    @NameInMap("processCodes")
    public String processCodes;

    /**
     * <p>验权token</p>
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
