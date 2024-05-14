// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkresident_1_0.models;

import com.aliyun.tea.*;

public class CreateResidentBlackBoardRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("context")
    public String context;

    @NameInMap("mediaId")
    public String mediaId;

    @NameInMap("sendTime")
    public String sendTime;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("title")
    public String title;

    public static CreateResidentBlackBoardRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateResidentBlackBoardRequest self = new CreateResidentBlackBoardRequest();
        return TeaModel.build(map, self);
    }

    public CreateResidentBlackBoardRequest setContext(String context) {
        this.context = context;
        return this;
    }
    public String getContext() {
        return this.context;
    }

    public CreateResidentBlackBoardRequest setMediaId(String mediaId) {
        this.mediaId = mediaId;
        return this;
    }
    public String getMediaId() {
        return this.mediaId;
    }

    public CreateResidentBlackBoardRequest setSendTime(String sendTime) {
        this.sendTime = sendTime;
        return this;
    }
    public String getSendTime() {
        return this.sendTime;
    }

    public CreateResidentBlackBoardRequest setTitle(String title) {
        this.title = title;
        return this;
    }
    public String getTitle() {
        return this.title;
    }

}
