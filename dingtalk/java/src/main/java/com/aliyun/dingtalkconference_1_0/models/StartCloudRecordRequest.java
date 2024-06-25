// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconference_1_0.models;

import com.aliyun.tea.*;

public class StartCloudRecordRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>演讲</p>
     */
    @NameInMap("mode")
    public String mode;

    /**
     * <strong>example:</strong>
     * <p>左上</p>
     */
    @NameInMap("smallWindowPosition")
    public String smallWindowPosition;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>27SaQ3iiHLN0uwqcPisedfreNwiEiE</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static StartCloudRecordRequest build(java.util.Map<String, ?> map) throws Exception {
        StartCloudRecordRequest self = new StartCloudRecordRequest();
        return TeaModel.build(map, self);
    }

    public StartCloudRecordRequest setMode(String mode) {
        this.mode = mode;
        return this;
    }
    public String getMode() {
        return this.mode;
    }

    public StartCloudRecordRequest setSmallWindowPosition(String smallWindowPosition) {
        this.smallWindowPosition = smallWindowPosition;
        return this;
    }
    public String getSmallWindowPosition() {
        return this.smallWindowPosition;
    }

    public StartCloudRecordRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
