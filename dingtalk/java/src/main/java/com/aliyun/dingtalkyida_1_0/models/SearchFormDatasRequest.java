// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDatasRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_PBKT0MFBEBTDO8T7SLVP</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>2018-01-01</p>
     */
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>2018-02-01</p>
     */
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("currentPage")
    public Integer currentPage;

    /**
     * <strong>example:</strong>
     * <p>{&quot;numberField_1ac&quot;:&quot;+&quot;}, 表示按照字段numberField_1ac升序排列</p>
     */
    @NameInMap("dynamicOrder")
    public String dynamicOrder;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-EF6Y4G8WO2FN0SUB43TDQ3CGC3FMFQ1G9400RCJ3</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>zh_CN</p>
     */
    @NameInMap("language")
    public String language;

    /**
     * <strong>example:</strong>
     * <p>2018-01-01</p>
     */
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>2018-02-01</p>
     */
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    @NameInMap("originatorId")
    public String originatorId;

    /**
     * <strong>example:</strong>
     * <p>10</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>{&quot;textField_jcr0069m&quot;:&quot;danhang&quot;,&quot;textareaField_jcr0069n&quot;:&quot;duohang&quot;,&quot;numberField_jcr0069o&quot;:[&quot;1&quot;,&quot;10&quot;],&quot;radioField_jcr0069p&quot;:&quot;选项一&quot;,&quot;selectField_jcr0069q&quot;:&quot;选项一&quot;,&quot;checkboxField_jcr0069r&quot;:[&quot;选项二&quot;],&quot;multiSelectField_jcr0069s&quot;:[&quot;选项二&quot;,&quot;选项三&quot;],&quot;dateField_jcr0069t&quot;:[1514736000000,1517414399000],&quot;cascadeDate_jcr0069u&quot;:[[1514736000000,1517414399000],[1514736000000,1517414399000]],&quot;employeeField_jcr0069x&quot;:[&quot;xxxxx&quot;],&quot;citySelectField_jcr0069y&quot;:[&quot;110000&quot;,&quot;110100&quot;,&quot;110101&quot;],&quot;departmentField_jcr0069z&quot;:1123456,&quot;cascadeSelectField_jcr006a0&quot;:[&quot;part&quot;,&quot;part_b&quot;],&quot;tableField_jcr006a1&quot;:&quot;明细数据&quot;}</p>
     */
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>hexxx</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>173112212211</p>
     */
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
