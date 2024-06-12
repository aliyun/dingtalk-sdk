// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalksmart_device_1_0.models;

import com.aliyun.tea.*;

public class TextToImageRequest extends TeaModel {
    @NameInMap("modelId")
    public String modelId;

    @NameInMap("pictureNum")
    public Long pictureNum;

    @NameInMap("pictureSize")
    public String pictureSize;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("query")
    public String query;

    public static TextToImageRequest build(java.util.Map<String, ?> map) throws Exception {
        TextToImageRequest self = new TextToImageRequest();
        return TeaModel.build(map, self);
    }

    public TextToImageRequest setModelId(String modelId) {
        this.modelId = modelId;
        return this;
    }
    public String getModelId() {
        return this.modelId;
    }

    public TextToImageRequest setPictureNum(Long pictureNum) {
        this.pictureNum = pictureNum;
        return this;
    }
    public Long getPictureNum() {
        return this.pictureNum;
    }

    public TextToImageRequest setPictureSize(String pictureSize) {
        this.pictureSize = pictureSize;
        return this;
    }
    public String getPictureSize() {
        return this.pictureSize;
    }

    public TextToImageRequest setQuery(String query) {
        this.query = query;
        return this;
    }
    public String getQuery() {
        return this.query;
    }

}
