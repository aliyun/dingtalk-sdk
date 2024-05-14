// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class UpdateResidentBlackBoardRequest extends TeaModel {
    @NameInMap("blackboardId")
    public String blackboardId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("context")
    public String context;

    @NameInMap("mediaId")
    public String mediaId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static UpdateResidentBlackBoardRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateResidentBlackBoardRequest self = new UpdateResidentBlackBoardRequest();
        return TeaModel.build(map, self);
    }

    public UpdateResidentBlackBoardRequest setBlackboardId(String blackboardId) {
        this.blackboardId = blackboardId;
        return this;
    }
    public String getBlackboardId() {
        return this.blackboardId;
    }

    public UpdateResidentBlackBoardRequest setContext(String context) {
        this.context = context;
        return this;
    }
    public String getContext() {
        return this.context;
    }

    public UpdateResidentBlackBoardRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public UpdateResidentBlackBoardRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
