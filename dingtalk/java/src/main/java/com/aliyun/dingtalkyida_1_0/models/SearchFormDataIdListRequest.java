// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataIdListRequest extends TeaModel {
    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    // 应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    // 语言
    @NameInMap("language")
    public String language;

    // 根据表单内组件值查询
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    // 钉钉的userId
    @NameInMap("userId")
    public String userId;

    // 根据数据提交人工号查询
    @NameInMap("originatorId")
    public String originatorId;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    @NameInMap("pageNumber")
    public Integer pageNumber;

    @NameInMap("pageSize")
    public Integer pageSize;

    public static SearchFormDataIdListRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataIdListRequest self = new SearchFormDataIdListRequest();
        return TeaModel.build(map, self);
    }

    public SearchFormDataIdListRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public SearchFormDataIdListRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SearchFormDataIdListRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public SearchFormDataIdListRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public SearchFormDataIdListRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public SearchFormDataIdListRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

    public SearchFormDataIdListRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public SearchFormDataIdListRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public SearchFormDataIdListRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public SearchFormDataIdListRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataIdListRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

}
