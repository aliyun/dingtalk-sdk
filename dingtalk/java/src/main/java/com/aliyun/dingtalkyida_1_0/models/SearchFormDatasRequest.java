// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasRequest extends TeaModel {
    // 应用编码
    @NameInMap("appType")
    public String appType;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表, 字符串格式，且为yyyy-MM-DD格式
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    // createFrom和createTo两个时间构造一个时间段。查询在该时间段创建的数据列表。字符串格式，且为yyyy-MM-DD格式。 和createFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)创建的数据。
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    // 当前页
    @NameInMap("currentPage")
    public Integer currentPage;

    // 指定排序字段
    @NameInMap("dynamicOrder")
    public String dynamicOrder;

    // 表单ID
    @NameInMap("formUuid")
    public String formUuid;

    // 语言。可选值：zh_CN/en_US 默认：zh_CN
    @NameInMap("language")
    public String language;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    // modifiedFrom和modifiedTo构成一个时间段，查询在该时间段有修改的数据列表。字符串格式，且为yyyy-MM-DD格式。 和modifiedFrom一起，相当于查询在 2018-01-01到2018-01-31之间(包含01和31号)被修改的数据。
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    // 根据数据提交人工号查询
    @NameInMap("originatorId")
    public String originatorId;

    // 每页记录数
    @NameInMap("pageSize")
    public Integer pageSize;

    // 根据表单内组件值查询
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    // 应用秘钥。在应用数据中获取。
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    public static SearchFormDatasRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDatasRequest self = new SearchFormDatasRequest();
        return TeaModel.build(map, self);
    }

    public SearchFormDatasRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SearchFormDatasRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public SearchFormDatasRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public SearchFormDatasRequest setCurrentPage(Integer currentPage) {
        this.currentPage = currentPage;
        return this;
    }
    public Integer getCurrentPage() {
        return this.currentPage;
    }

    public SearchFormDatasRequest setDynamicOrder(String dynamicOrder) {
        this.dynamicOrder = dynamicOrder;
        return this;
    }
    public String getDynamicOrder() {
        return this.dynamicOrder;
    }

    public SearchFormDatasRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SearchFormDatasRequest setLanguage(String language) {
        this.language = language;
        return this;
    }
    public String getLanguage() {
        return this.language;
    }

    public SearchFormDatasRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public SearchFormDatasRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public SearchFormDatasRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public SearchFormDatasRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public SearchFormDatasRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public SearchFormDatasRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SearchFormDatasRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
