// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TranslateFileRequest extends TeaModel {
    /**
     * <p>key为钉盘文件mediaId，#号开头。只支持xlsx，xls，csv，txt文件。 value为文件名，包含文件扩展名。 不超过20个文件，可以调用单步文件上传接口获取。</p>
     */
    @NameInMap("medias")
    public java.util.Map<String, String> medias;

    /**
     * <p>若medias中文件个数大于1，则该字段必填。 转译完打包的文件名，不需带后缀。钉钉后台会打包成zip压缩文件，并自动拼接上.zip后缀。</p>
     */
    @NameInMap("outputFileName")
    public String outputFileName;

    /**
     * <p>unionId</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static TranslateFileRequest build(java.util.Map<String, ?> map) throws Exception {
        TranslateFileRequest self = new TranslateFileRequest();
        return TeaModel.build(map, self);
    }

    public TranslateFileRequest setMedias(java.util.Map<String, String> medias) {
        this.medias = medias;
        return this;
    }
    public java.util.Map<String, String> getMedias() {
        return this.medias;
    }

    public TranslateFileRequest setOutputFileName(String outputFileName) {
        this.outputFileName = outputFileName;
        return this;
    }
    public String getOutputFileName() {
        return this.outputFileName;
    }

    public TranslateFileRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
