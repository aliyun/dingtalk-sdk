// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetUuidByIdOrUrlResponseBody extends TeaModel {
    @NameInMap("dentryUuid")
    public String dentryUuid;

    public static GetUuidByIdOrUrlResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetUuidByIdOrUrlResponseBody self = new GetUuidByIdOrUrlResponseBody();
        return TeaModel.build(map, self);
    }

    public GetUuidByIdOrUrlResponseBody setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

}
