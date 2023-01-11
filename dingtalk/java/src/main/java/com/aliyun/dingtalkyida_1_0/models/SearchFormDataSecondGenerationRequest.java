// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationRequest extends TeaModel {
    /**
     * <p>宜搭应用编码</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>创建时间起始值</p>
     */
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    /**
     * <p>创建时间终止值</p>
     */
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    /**
     * <p>表单编码</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <p>修改时间起始值</p>
     */
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    /**
     * <p>修改时间终止值</p>
     */
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    /**
     * <p>排序规则</p>
     */
    @NameInMap("orderConfigJson")
    public String orderConfigJson;

    /**
     * <p>表单提交人的钉钉userId</p>
     */
    @NameInMap("originatorId")
    public String originatorId;

    /**
     * <p>当前第几页</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>分页大小</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>用于检索表单实例数据的检索条件</p>
     */
    @NameInMap("searchCondition")
    public String searchCondition;

    /**
     * <p>宜搭应用秘钥</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>钉钉userId</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SearchFormDataSecondGenerationRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataSecondGenerationRequest self = new SearchFormDataSecondGenerationRequest();
        return TeaModel.build(map, self);
    }

    public SearchFormDataSecondGenerationRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SearchFormDataSecondGenerationRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public SearchFormDataSecondGenerationRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public SearchFormDataSecondGenerationRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SearchFormDataSecondGenerationRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public SearchFormDataSecondGenerationRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public SearchFormDataSecondGenerationRequest setOrderConfigJson(String orderConfigJson) {
        this.orderConfigJson = orderConfigJson;
        return this;
    }
    public String getOrderConfigJson() {
        return this.orderConfigJson;
    }

    public SearchFormDataSecondGenerationRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public SearchFormDataSecondGenerationRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataSecondGenerationRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public SearchFormDataSecondGenerationRequest setSearchCondition(String searchCondition) {
        this.searchCondition = searchCondition;
        return this;
    }
    public String getSearchCondition() {
        return this.searchCondition;
    }

    public SearchFormDataSecondGenerationRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SearchFormDataSecondGenerationRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
