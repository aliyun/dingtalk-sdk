// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class CreateOrUpdateFormDataRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>APP_XCE0EVXS6DYG3YDYC5RD</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;countrySelectField_l0c1cwiu&quot;:[{&quot;value&quot;:&quot;US&quot;}]}</p>
     */
    @NameInMap("formDataJson")
    public String formDataJson;

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
     * <p>false</p>
     */
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    /**
     * <p>This parameter is required.</p>
     * 
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

    public static CreateOrUpdateFormDataRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateOrUpdateFormDataRequest self = new CreateOrUpdateFormDataRequest();
        return TeaModel.build(map, self);
    }

    public CreateOrUpdateFormDataRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public CreateOrUpdateFormDataRequest setFormDataJson(String formDataJson) {
        this.formDataJson = formDataJson;
        return this;
    }
    public String getFormDataJson() {
        return this.formDataJson;
    }

    public CreateOrUpdateFormDataRequest setFormUuid(String formUuid) {
        this.formUuid = formUuid;
        return this;
    }
    public String getFormUuid() {
        return this.formUuid;
    }

    public CreateOrUpdateFormDataRequest setNoExecuteExpression(Boolean noExecuteExpression) {
        this.noExecuteExpression = noExecuteExpression;
        return this;
    }
    public Boolean getNoExecuteExpression() {
        return this.noExecuteExpression;
    }

    public CreateOrUpdateFormDataRequest setSearchCondition(String searchCondition) {
        this.searchCondition = searchCondition;
        return this;
    }
    public String getSearchCondition() {
        return this.searchCondition;
    }

    public CreateOrUpdateFormDataRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public CreateOrUpdateFormDataRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
