// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationNoTableFieldRequest extends TeaModel {
    // 宜搭应用编码
    @NameInMap("appType")
    public String appType;

    // 创建时间起始值
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    // 创建时间终止值
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    // 表单编码
    @NameInMap("formUuid")
    public String formUuid;

    // 修改时间起始值
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    // 修改时间终止值
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    // 排序规则
    @NameInMap("orderConfigJson")
    public String orderConfigJson;

    // 表单提交人的钉钉userId
    @NameInMap("originatorId")
    public String originatorId;

    // 当前第几页
    @NameInMap("pageNumber")
    public Integer pageNumber;

    // 分页大小
    @NameInMap("pageSize")
    public Integer pageSize;

    // 用于检索表单实例数据的检索条件
    @NameInMap("searchCondition")
    public String searchCondition;

    // 宜搭应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
    @NameInMap("userId")
    public String userId;

    public static SearchFormDataSecondGenerationNoTableFieldRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataSecondGenerationNoTableFieldRequest self = new SearchFormDataSecondGenerationNoTableFieldRequest();
        return TeaModel.build(map, self);
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setOrderConfigJson(String orderConfigJson) {
        this.orderConfigJson = orderConfigJson;
        return this;
    }
    public String getOrderConfigJson() {
        return this.orderConfigJson;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setSearchCondition(String searchCondition) {
        this.searchCondition = searchCondition;
        return this;
    }
    public String getSearchCondition() {
        return this.searchCondition;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SearchFormDataSecondGenerationNoTableFieldRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
