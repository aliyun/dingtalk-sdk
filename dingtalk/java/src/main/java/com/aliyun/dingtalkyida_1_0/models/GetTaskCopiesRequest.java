// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetTaskCopiesRequest extends TeaModel {
    // 应用ID
    @NameInMap("appType")
    public String appType;

    // 验权token
    @NameInMap("systemToken")
    public String systemToken;

    // 每页记录数; 必须大于0 默认10 最大值：100
    @NameInMap("pageSize")
    public Integer pageSize;

    // 语言环境; 可选值：zh_CN/en_US
    @NameInMap("language")
    public String language;

    // 当前页; 必须大于0 默认1
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 关键词
    @NameInMap("keyword")
    public String keyword;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 流程code列表
    @NameInMap("processCodes")
    public String processCodes;

    // 创建时间开始; 时间戳
    @NameInMap("createFromTimeGMT")
    public Long createFromTimeGMT;

    // 创建时间结束; 时间戳
    @NameInMap("createToTimeGMT")
    public Long createToTimeGMT;

    public static GetTaskCopiesRequest build(java.util.Map<String, ?> map) throws Exception {
        GetTaskCopiesRequest self = new GetTaskCopiesRequest();
        return TeaModel.build(map, self);
    }

    public GetTaskCopiesRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetTaskCopiesRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetTaskCopiesRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetTaskCopiesRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public GetTaskCopiesRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetTaskCopiesRequest setKeyword(String keyword) {
        this.keyword = keyword;
        return this;
    }
    public String getKeyword() {
        return this.keyword;
    }

    public GetTaskCopiesRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public GetTaskCopiesRequest setProcessCodes(String processCodes) {
        this.processCodes = processCodes;
        return this;
    }
    public String getProcessCodes() {
        return this.processCodes;
    }

    public GetTaskCopiesRequest setCreateFromTimeGMT(Long createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public Long getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public GetTaskCopiesRequest setCreateToTimeGMT(Long createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public Long getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

}
