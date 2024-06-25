// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class SearchFormDataSecondGenerationRequest extends TeaModel {
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
     * <p>例如按照创建时间升序按照文本组件值升序排序则填{&quot;gmt_create&quot;:&quot;+&quot;,&quot;textField_1234&quot;:&quot;+&quot;}。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#CQro8">https://www.yuque.com/yida/support/agb8im#CQro8</a></p>
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
     * <p>[{&quot;key&quot;:&quot;currentNodeName&quot;,&quot;value&quot;:&quot;当前审批节点名称&quot;,&quot;type&quot;:&quot;TEXT&quot;,&quot;operator&quot;:&quot;like&quot;,&quot;componentName&quot;:&quot;TextField&quot;}]。详情参考 <a href="https://www.yuque.com/yida/support/agb8im#F4S8e">https://www.yuque.com/yida/support/agb8im#F4S8e</a></p>
     */
    @NameInMap("searchCondition")
    public String searchCondition;

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
