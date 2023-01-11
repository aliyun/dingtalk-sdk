// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkfinance_1_0.models;

import com.aliyun.tea.*;

public class UploadRegisterImageRequest extends TeaModel {
    /**
     * <p>图片内容</p>
     */
    @NameInMap("imageContent")
    public String imageContent;

    /**
     * <p>图片名称</p>
     */
    @NameInMap("imageName")
    public String imageName;

    /**
     * <p>图片类型</p>
     */
    @NameInMap("imageType")
    public String imageType;

    /**
     * <p>主机构id</p>
     */
    @NameInMap("instId")
    public String instId;

    /**
     * <p>进件渠道</p>
     */
    @NameInMap("payChannel")
    public String payChannel;

    public static UploadRegisterImageRequest build(java.util.Map<String, ?> map) throws Exception {
        UploadRegisterImageRequest self = new UploadRegisterImageRequest();
        return TeaModel.build(map, self);
    }

    public UploadRegisterImageRequest setImageContent(String imageContent) {
        this.imageContent = imageContent;
        return this;
    }
    public String getImageContent() {
        return this.imageContent;
    }

    public UploadRegisterImageRequest setImageName(String imageName) {
        this.imageName = imageName;
        return this;
    }
    public String getImageName() {
        return this.imageName;
    }

    public UploadRegisterImageRequest setImageType(String imageType) {
        this.imageType = imageType;
        return this;
    }
    public String getImageType() {
        return this.imageType;
    }

    public UploadRegisterImageRequest setInstId(String instId) {
        this.instId = instId;
        return this;
    }
    public String getInstId() {
        return this.instId;
    }

    public UploadRegisterImageRequest setPayChannel(String payChannel) {
        this.payChannel = payChannel;
        return this;
    }
    public String getPayChannel() {
        return this.payChannel;
    }

}
