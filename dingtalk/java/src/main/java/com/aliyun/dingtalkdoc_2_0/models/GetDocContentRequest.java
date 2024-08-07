// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDocContentRequest extends TeaModel {
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

    public static GetDocContentRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDocContentRequest self = new GetDocContentRequest();
        return TeaModel.build(map, self);
    }

    public GetDocContentRequest setGenerateCp(Boolean generateCp) {
        this.generateCp = generateCp;
        return this;
    }
    public Boolean getGenerateCp() {
        return this.generateCp;
    }

    public GetDocContentRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
