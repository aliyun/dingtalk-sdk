// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDocContentForELMRequest extends TeaModel {
    @NameInMap("targetFormat")
    public String targetFormat;

    public static GetDocContentForELMRequest build(java.util.Map<String, ?> map) throws Exception {
        GetDocContentForELMRequest self = new GetDocContentForELMRequest();
        return TeaModel.build(map, self);
    }

    public GetDocContentForELMRequest setTargetFormat(String targetFormat) {
        this.targetFormat = targetFormat;
        return this;
    }
    public String getTargetFormat() {
        return this.targetFormat;
    }

}
