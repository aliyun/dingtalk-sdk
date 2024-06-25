// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartMinutesRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>左上</p>
     */
    @NameInMap("ownerUnionId")
    public String ownerUnionId;

    /**
     * <strong>example:</strong>
     * <p>true</p>
     */
    @NameInMap("recordAudio")
    public Boolean recordAudio;

    /**
     * <strong>example:</strong>
     * <p>27SaQ3iiHLN0uwqcPisedfreNwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static StartMinutesRequest build(java.util.Map<String, ?> map) throws Exception {
        StartMinutesRequest self = new StartMinutesRequest();
        return TeaModel.build(map, self);
    }

    public StartMinutesRequest setOwnerUnionId(String ownerUnionId) {
        this.ownerUnionId = ownerUnionId;
        return this;
    }
    public String getOwnerUnionId() {
        return this.ownerUnionId;
    }

    public StartMinutesRequest setRecordAudio(Boolean recordAudio) {
        this.recordAudio = recordAudio;
        return this;
    }
    public Boolean getRecordAudio() {
        return this.recordAudio;
    }

    public StartMinutesRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
