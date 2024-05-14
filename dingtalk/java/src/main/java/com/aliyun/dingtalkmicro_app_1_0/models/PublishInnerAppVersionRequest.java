// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PublishInnerAppVersionRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("appVersionId")
    public Long appVersionId;

    @NameInMap("miniAppOnPc")
    public Boolean miniAppOnPc;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    @NameInMap("publishType")
    public String publishType;

    public static PublishInnerAppVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        PublishInnerAppVersionRequest self = new PublishInnerAppVersionRequest();
        return TeaModel.build(map, self);
    }

    public PublishInnerAppVersionRequest setAppVersionId(Long appVersionId) {
        this.appVersionId = appVersionId;
        return this;
    }
    public Long getAppVersionId() {
        return this.appVersionId;
    }

    public PublishInnerAppVersionRequest setMiniAppOnPc(Boolean miniAppOnPc) {
        this.miniAppOnPc = miniAppOnPc;
        return this;
    }
    public Boolean getMiniAppOnPc() {
        return this.miniAppOnPc;
    }

    public PublishInnerAppVersionRequest setOpUnionId(String opUnionId) {
        this.opUnionId = opUnionId;
        return this;
    }
    public String getOpUnionId() {
        return this.opUnionId;
    }

    public PublishInnerAppVersionRequest setPublishType(String publishType) {
        this.publishType = publishType;
        return this;
    }
    public String getPublishType() {
        return this.publishType;
    }

}
