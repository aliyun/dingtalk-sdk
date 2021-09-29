// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetCorpTasksRequest extends TeaModel {
    // 企业ID
    @NameInMap("corpId")
    public String corpId;

    // 每页记录数
    @NameInMap("pageSize")
    public Integer pageSize;

    // 语言环境
    @NameInMap("language")
    public String language;

    // 当前页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 关键词
    @NameInMap("keyword")
    public String keyword;

    // 应用标识列表
    @NameInMap("appTypes")
    public String appTypes;

    // 流程code列表
    @NameInMap("processCodes")
    public String processCodes;

    // 创建时间开始
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    // 创建时间结束
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 验权token
    @NameInMap("token")
    public String token;

    public static GetCorpTasksRequest build(java.util.Map<String, ?> map) throws Exception {
        GetCorpTasksRequest self = new GetCorpTasksRequest();
        return TeaModel.build(map, self);
    }

    public GetCorpTasksRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public GetCorpTasksRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetCorpTasksRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetCorpTasksRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetCorpTasksRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public GetCorpTasksRequest setAppTypes(String appTypes) {
        this.appTypes = appTypes;
        return this;
    }
    public String getAppTypes() {
        return this.appTypes;
    }

    public GetCorpTasksRequest setProcessCodes(String processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public String getProcessCodes() {
        return this.processCodes;
    }

    public GetCorpTasksRequest setCreateFromTimeGMT(Long createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public Long getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetCorpTasksRequest setCreateToTimeGMT(Long createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public Long getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public GetCorpTasksRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetCorpTasksRequest setToken(String token) {
        this.token = token;
        return this;
    }
    public String getToken() {
        return this.token;
    }

}
