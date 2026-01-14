// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkminutes_1_0.models;

import com.aliyun.tea.*;

public class ExportMinutesTaskResultResponseBody extends TeaModel {
    @NameInMap("minutesDocUrl")
    public String minutesDocUrl;

    public static ExportMinutesTaskResultResponseBody build(java.util.Map<String, ?> map) throws Exception {
        ExportMinutesTaskResultResponseBody self = new ExportMinutesTaskResultResponseBody();
        return TeaModel.build(map, self);
    }

    public ExportMinutesTaskResultResponseBody setMinutesDocUrl(String minutesDocUrl) {
        this.minutesDocUrl = minutesDocUrl;
        return this;
    }
    public String getMinutesDocUrl() {
        return this.minutesDocUrl;
    }

}
