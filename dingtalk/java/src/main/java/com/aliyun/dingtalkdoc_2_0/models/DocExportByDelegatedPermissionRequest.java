// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class DocExportByDelegatedPermissionRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>false</p>
     */
    @NameInMap("generateCp")
    public Boolean generateCp;

    /**
     * <strong>example:</strong>
     * <p>markdown</p>
     */
    @NameInMap("targetFormat")
    public String targetFormat;

    public static DocExportByDelegatedPermissionRequest build(java.util.Map<String, ?> map) throws Exception {
        DocExportByDelegatedPermissionRequest self = new DocExportByDelegatedPermissionRequest();
        return TeaModel.build(map, self);
    }

    public DocExportByDelegatedPermissionRequest setGenerateCp(Boolean generateCp) {
        this.generateCp = generateCp;
        return this;
    }
    public Boolean getGenerateCp() {
        return this.generateCp;
    }

    public DocExportByDelegatedPermissionRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
