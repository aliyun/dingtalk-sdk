// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcontact_1_0.models;

import com.aliyun.tea.*;

public class TranslateFileRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;#iAEHAqRmaWxlA6h5dW5kaXNrMAT&quot;:&quot;导出.xlsx&quot;}</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("medias")
    public java.util.Map<String, String> medias;

    /**
     * <strong>example:</strong>
     * <p>学习手册</p>
     */
    @NameInMap("outputFileName")
    public String outputFileName;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>fXRUNiSlgfK3e1hzFUSciiJwiEiE</p>
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
