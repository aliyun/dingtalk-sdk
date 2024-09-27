// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class GenerateFlashMinutesDocumentUrlResponseBody extends TeaModel {
    @NameInMap("minutesDocUrl")
    public String minutesDocUrl;

    public static GenerateFlashMinutesDocumentUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GenerateFlashMinutesDocumentUrlResponseBody self = new GenerateFlashMinutesDocumentUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GenerateFlashMinutesDocumentUrlResponseBody setMinutesDocUrl(String minutesDocUrl) {
        this.minutesDocUrl = minutesDocUrl;
        return this;
    }
    public String getMinutesDocUrl() {
        return this.minutesDocUrl;
    }

}
