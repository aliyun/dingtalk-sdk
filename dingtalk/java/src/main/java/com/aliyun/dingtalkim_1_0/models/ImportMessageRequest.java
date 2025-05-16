// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkim_1_0.models;

import com.aliyun.tea.*;

public class ImportMessageRequest extends TeaModel {
    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>{&quot;content&quot;:&quot;月会通知&lt;@all&gt; &quot;,&quot;at&quot;:{&quot;atUserIds&quot;:[],&quot;isAtAll&quot;:true}}</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("createTime")
    public Long createTime;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>axcf*-<em><strong><strong>-</strong></strong></em>-23da*</p>
     */
    @NameInMap("importUuid")
    public String importUuid;

    @NameInMap("msgReadStatusSetting")
    public Boolean msgReadStatusSetting;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>text</p>
     */
    @NameInMap("msgType")
    public String msgType;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>cidt*****Xa4K10w==</p>
     */
    @NameInMap("openConversationId")
    public String openConversationId;

    @NameInMap("receivers")
    public java.util.List<String> receivers;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>example:</strong>
     * <p>013*****21312</p>
     */
    @NameInMap("senderId")
    public String senderId;

    public static ImportMessageRequest build(java.util.Map<String, ?> map) throws Exception {
        ImportMessageRequest self = new ImportMessageRequest();
        return TeaModel.build(map, self);
    }

    public ImportMessageRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public ImportMessageRequest setCreateTime(Long createTime) {
        this.createTime = createTime;
        return this;
    }
    public Long getCreateTime() {
        return this.createTime;
    }

    public ImportMessageRequest setImportUuid(String importUuid) {
        this.importUuid = importUuid;
        return this;
    }
    public String getImportUuid() {
        return this.importUuid;
    }

    public ImportMessageRequest setMsgReadStatusSetting(Boolean msgReadStatusSetting) {
        this.msgReadStatusSetting = msgReadStatusSetting;
        return this;
    }
    public Boolean getMsgReadStatusSetting() {
        return this.msgReadStatusSetting;
    }

    public ImportMessageRequest setMsgType(String msgType) {
        this.msgType = msgType;
        return this;
    }
    public String getMsgType() {
        return this.msgType;
    }

    public ImportMessageRequest setOpenConversationId(String openConversationId) {
        this.openConversationId = openConversationId;
        return this;
    }
    public String getOpenConversationId() {
        return this.openConversationId;
    }

    public ImportMessageRequest setReceivers(java.util.List<String> receivers) {
        this.receivers = receivers;
        return this;
    }
    public java.util.List<String> getReceivers() {
        return this.receivers;
    }

    public ImportMessageRequest setSenderId(String senderId) {
        this.senderId = senderId;
        return this;
    }
    public String getSenderId() {
        return this.senderId;
    }

}
