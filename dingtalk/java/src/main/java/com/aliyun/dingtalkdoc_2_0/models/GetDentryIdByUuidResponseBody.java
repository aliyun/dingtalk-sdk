// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkdoc_2_0.models;

import com.aliyun.tea.*;

public class GetDentryIdByUuidResponseBody extends TeaModel {
    @NameInMap("dentryId")
    public String dentryId;

    @NameInMap("dentryUuid")
    public String dentryUuid;

    @NameInMap("spaceId")
    public String spaceId;

    public static GetDentryIdByUuidResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetDentryIdByUuidResponseBody self = new GetDentryIdByUuidResponseBody();
        return TeaModel.build(map, self);
    }

    public GetDentryIdByUuidResponseBody setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public GetDentryIdByUuidResponseBody setDentryUuid(String dentryUuid) {
        this.dentryUuid = dentryUuid;
        return this;
    }
    public String getDentryUuid() {
        return this.dentryUuid;
    }

    public GetDentryIdByUuidResponseBody setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

}
