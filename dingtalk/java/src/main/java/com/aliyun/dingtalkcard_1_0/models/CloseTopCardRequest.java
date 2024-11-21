// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkcard_1_0.models;

import com.aliyun.tea.*;

public class CloseTopCardRequest extends TeaModel {
    /**
     * <strong>example:</strong>
     * <p>example_open_conversation_id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>example_out_track_id</p>
     */
    @NameInMap("outTrackId")
    public String outTrackId;

    public static CloseTopCardRequest build(java.util.Map<String, ?> map) throws Exception {
        CloseTopCardRequest self = new CloseTopCardRequest();
        return TeaModel.build(map, self);
    }

    public CloseTopCardRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public CloseTopCardRequest setOutTrackId(String outTrackId) {
        this.outTrackId = outTrackId;
        return this;
    }
    public String getOutTrackId() {
        return this.outTrackId;
    }

}
