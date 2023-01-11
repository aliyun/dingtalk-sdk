// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkconv_file_1_0.models;

import com.aliyun.tea.*;

public class SendLinkRequest extends TeaModel {
    /**
     * <p>文件id</p>
     */
    @NameInMap("dentryId")
    public String dentryId;

    /**
     * <p>目标会话id</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    /**
     * <p>文件所在空间id</p>
     */
    @NameInMap("spaceId")
    public String spaceId;

    /**
     * <p>用户id</p>
     */
    @NameInMap("unionId")
    public String unionId;

    public static SendLinkRequest build(java.util.Map<String, ?> map) throws Exception {
        SendLinkRequest self = new SendLinkRequest();
        return TeaModel.build(map, self);
    }

    public SendLinkRequest setDentryId(String dentryId) {
        this.dentryId = dentryId;
        return this;
    }
    public String getDentryId() {
        return this.dentryId;
    }

    public SendLinkRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public SendLinkRequest setSpaceId(String spaceId) {
        this.spaceId = spaceId;
        return this;
    }
    public String getSpaceId() {
        return this.spaceId;
    }

    public SendLinkRequest setUnionId(String unionId) {
        this.unionId = unionId;
        return this;
    }
    public String getUnionId() {
        return this.unionId;
    }

}
