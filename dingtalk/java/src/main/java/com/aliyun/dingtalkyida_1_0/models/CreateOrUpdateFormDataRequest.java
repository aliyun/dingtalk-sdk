// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class CreateOrUpdateFormDataRequest extends TeaModel {
    // 宜搭应用编码
    @NameInMap("appType")
    public String appType;

    // 宜搭表单实例数据 json格式，如果存在满足检索条件的表单实例数据则用此值增量更新满足检索条件的的表单实例数据，否则用此值创建一条表单实例。表单实例数据的结构请参考 https://www.yuque.com/yida/support/agb8im#f26a51f429f9f19aa0b5b3ee847ac556_h3_31
    @NameInMap("formDataJson")
    public String formDataJson;

    // 表单编码
    @NameInMap("formUuid")
    public String formUuid;

    // 是否不触发校验规则、关联业务规则和第三方服务回调
    @NameInMap("noExecuteExpression")
    public Boolean noExecuteExpression;

    // 用于检索表单实例数据的检索条件
    @NameInMap("searchCondition")
    public String searchCondition;

    // 宜搭应用秘钥
    @NameInMap("systemToken")
    public String systemToken;

    // 钉钉userId
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
