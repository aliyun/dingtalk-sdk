// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalklive_1_0.models;

import com.aliyun.tea.*;

public class DeleteLiveRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("liveId")
    public String liveId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static DeleteLiveRequest build(java.util.Map<String, ?> map) throws Exception {
        DeleteLiveRequest self = new DeleteLiveRequest();
        return TeaModel.build(map, self);
    }

    public DeleteLiveRequest setLiveId(String liveId) {
        this.liveId = liveId;
        return this;
    }
    public String getLiveId() {
        return this.liveId;
    }

    public DeleteLiveRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
