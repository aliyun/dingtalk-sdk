// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataRemovalTableDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <strong>example:</strong>
     * <p>2021-05-01</p>
     */
    @NameInMap("createFromTimeGMT")
    public String createFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>2021-05-01</p>
     */
    @NameInMap("createToTimeGMT")
    public String createToTimeGMT;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA</p>
     */
    @NameInMap("formUuid")
    public String formUuid;

    /**
     * <strong>example:</strong>
     * <p>2021-05-01</p>
     */
    @NameInMap("modifiedFromTimeGMT")
    public String modifiedFromTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>2021-09-10</p>
     */
    @NameInMap("modifiedToTimeGMT")
    public String modifiedToTimeGMT;

    /**
     * <strong>example:</strong>
     * <p>示例: 按照创建时间和文本组件值做升序排序则填写 {&quot;gmt_create&quot;:&quot;+&quot;,&quot;textField_1234&quot;:&quot;+&quot;}。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#CQro8">https://www.yuque.com/yida/support/agb8im#CQro8</a></p>
     */
    @NameInMap("orderConfigJson")
    public String orderConfigJson;

    /**
     * <strong>example:</strong>
     * <p>manager123</p>
     */
    @NameInMap("originatorId")
    public String originatorId;

    /**
     * <strong>example:</strong>
     * <p>1</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <strong>example:</strong>
     * <p>100</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <strong>example:</strong>
     * <p>支持2种检索规则{&quot;numberField_l0c1cwiu&quot;:1}或者[{&quot;key&quot;:&quot;currentNodeName&quot;,&quot;value&quot;:&quot;步凡&quot;,&quot;type&quot;:&quot;TEXT&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;componentName&quot;:&quot;TextField&quot;}], 前一种规则仅仅做模糊匹配无法设置精确匹配, 第二种可以设置精确匹配条件。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#F4S8e">https://www.yuque.com/yida/support/agb8im#F4S8e</a></p>
     */
    @NameInMap("searchFieldJson")
    public String searchFieldJson;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>ding173982232112232</p>
     */
    @NameInMap("userId")
    public String userId;

    public static SearchFormDataRemovalTableDataRequest build(java.util.Map<String, ?> map) throws Exception {
        SearchFormDataRemovalTableDataRequest self = new SearchFormDataRemovalTableDataRequest();
        return TeaModel.build(map, self);
    }

    public SearchFormDataRemovalTableDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public SearchFormDataRemovalTableDataRequest setCreateFromTimeGMT(String createFromTimeGMT) {
        this.createFromTimeGMT = createFromTimeGMT;
        return this;
    }
    public String getCreateFromTimeGMT() {
        return this.createFromTimeGMT;
    }

    public SearchFormDataRemovalTableDataRequest setCreateToTimeGMT(String createToTimeGMT) {
        this.createToTimeGMT = createToTimeGMT;
        return this;
    }
    public String getCreateToTimeGMT() {
        return this.createToTimeGMT;
    }

    public SearchFormDataRemovalTableDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public SearchFormDataRemovalTableDataRequest setModifiedFromTimeGMT(String modifiedFromTimeGMT) {
        this.modifiedFromTimeGMT = modifiedFromTimeGMT;
        return this;
    }
    public String getModifiedFromTimeGMT() {
        return this.modifiedFromTimeGMT;
    }

    public SearchFormDataRemovalTableDataRequest setModifiedToTimeGMT(String modifiedToTimeGMT) {
        this.modifiedToTimeGMT = modifiedToTimeGMT;
        return this;
    }
    public String getModifiedToTimeGMT() {
        return this.modifiedToTimeGMT;
    }

    public SearchFormDataRemovalTableDataRequest setOrderConfigJson(String orderConfigJson) {
        this.orderConfigJson = orderConfigJson;
        return this;
    }
    public String getOrderConfigJson() {
        return this.orderConfigJson;
    }

    public SearchFormDataRemovalTableDataRequest setOriginatorId(String originatorId) {
        this.originatorId = originatorId;
        return this;
    }
    public String getOriginatorId() {
        return this.originatorId;
    }

    public SearchFormDataRemovalTableDataRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public SearchFormDataRemovalTableDataRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public SearchFormDataRemovalTableDataRequest setSearchFieldJson(String searchFieldJson) {
        this.searchFieldJson = searchFieldJson;
        return this;
    }
    public String getSearchFieldJson() {
        return this.searchFieldJson;
    }

    public SearchFormDataRemovalTableDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public SearchFormDataRemovalTableDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
