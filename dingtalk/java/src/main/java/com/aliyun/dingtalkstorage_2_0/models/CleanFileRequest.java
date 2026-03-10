// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkstorage_2_0.models;

import com.aliyun.tea.*;

public class CleanFileRequest extends TeaModel {
    @NameInMap("cleanReason")
    public String cleanReason;

    @NameInMap("dentryId")
    public Long dentryId;

    @NameInMap("operatorId")
    public String operatorId;

    @NameInMap("spaceId")
    public Long spaceId;

    public static CleanFileRequest build(java.util.Map<String, ?> map) throws Exception {
        CleanFileRequest self = new CleanFileRequest();
        return TeaModel.build(map, self);
    }

    public CleanFileRequest setCleanReason(String cleanReason) {
        this.cleanReason = cleanReason;
        return this;
    }
    public String getCleanReason() {
        return this.cleanReason;
    }

    public CleanFileRequest setDentryId(Long dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public Long getDentryId() {
        return this.dentryId;
    }

    public CleanFileRequest setOperatorId(String operatorId) {
        this.operatorId = operatorId;
        return this;
    }
    public String getOperatorId() {
        return this.operatorId;
    }

    public CleanFileRequest setSpaceId(Long spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public Long getSpaceId() {
        return this.spaceId;
    }

}
