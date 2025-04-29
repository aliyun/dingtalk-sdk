// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_1_0.models;

import com.aliyun.tea.*;

public class DocExportRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>markdown</p>
     */
    @NameInMap("targetFormat")
    public String targetFormat;

    public static DocExportRequest build(java.util.Map<String, ?> map) throws Exception {
        DocExportRequest self = new DocExportRequest();
        return TeaModel.build(map, self);
    }

    public DocExportRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
