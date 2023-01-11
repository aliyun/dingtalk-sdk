// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkyida_1_0.models;

import com.aliyun.tea.*;

public class GetFormListInAppRequest extends TeaModel {
    /**
     * <p>应用编码。应用唯一标识。如：APP_XXX</p>
     */
    @NameInMap("appType")
    public String appType;

    /**
     * <p>支持两种表单类型。</p>
     * <p>receipt :  普通单据表单</p>
     * <p>process ： 流程表单</p>
     * <p>如需查询多种类型，可用英文逗号分隔。</p>
     * <p>不传时默认单据和流程均返回。</p>
     */
    @NameInMap("formTypes")
    public String formTypes;

    /**
     * <p>页码，不填默认为1。</p>
     */
    @NameInMap("pageNumber")
    public Integer pageNumber;

    /**
     * <p>单页返回的条目数，最大值100。</p>
     * <p>不填默认为100。</p>
     */
    @NameInMap("pageSize")
    public Integer pageSize;

    /**
     * <p>应用秘钥。在应用设置-部署运维-应用密钥中获取。</p>
     */
    @NameInMap("systemToken")
    public String systemToken;

    /**
     * <p>操作人userId。</p>
     */
    @NameInMap("userId")
    public String userId;

    public static GetFormListInAppRequest build(java.util.Map<String, ?> map) throws Exception {
        GetFormListInAppRequest self = new GetFormListInAppRequest();
        return TeaModel.build(map, self);
    }

    public GetFormListInAppRequest setAppType(String appType) {
        this.appType = appType;
        return this;
    }
    public String getAppType() {
        return this.appType;
    }

    public GetFormListInAppRequest setFormTypes(String formTypes) {
        this.formTypes = formTypes;
        return this;
    }
    public String getFormTypes() {
        return this.formTypes;
    }

    public GetFormListInAppRequest setPageNumber(Integer pageNumber) {
        this.pageNumber = pageNumber;
        return this;
    }
    public Integer getPageNumber() {
        return this.pageNumber;
    }

    public GetFormListInAppRequest setPageSize(Integer pageSize) {
        this.pageSize = pageSize;
        return this;
    }
    public Integer getPageSize() {
        return this.pageSize;
    }

    public GetFormListInAppRequest setSystemToken(String systemToken) {
        this.systemToken = systemToken;
        return this;
    }
    public String getSystemToken() {
        return this.systemToken;
    }

    public GetFormListInAppRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
