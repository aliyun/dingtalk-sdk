// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkmicro_app_1_0.models;

import com.aliyun.tea.*;

public class PublishInnerAppVersionRequest extends TeaModel {
    /**
     * <p>小程序版本id，用于唯一标识小程序版本信息。</p>
     */
    @NameInMap("appVersionId")
    public Long appVersionId;

    /**
     * <p>小程序是否在PC端发布，true表示发布移动端和PC端，false表示只发布移动端</p>
     */
    @NameInMap("miniAppOnPc")
    public Boolean miniAppOnPc;

    /**
     * <p>操作人unionId</p>
     */
    @NameInMap("opUnionId")
    public String opUnionId;

    /**
     * <p>小程序发布类型，”online“表示发布线上版本，”experience“表示发布体验版本</p>
     */
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
