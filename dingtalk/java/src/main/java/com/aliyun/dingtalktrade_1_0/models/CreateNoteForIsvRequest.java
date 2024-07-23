// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalktrade_1_0.models;

import com.aliyun.tea.*;

public class CreateNoteForIsvRequest extends TeaModel {
    @NameInMap("contactName")
    public String contactName;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("contactPhoneNum")
    public String contactPhoneNum;

    @NameInMap("contactTitle")
    public String contactTitle;

    /**
     * <p>This parameter is required.</p>
     * 
     * <strong>if can be null:</strong>
     * <p>false</p>
     */
    @NameInMap("content")
    public String content;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("corpId")
    public String corpId;

    /**
     * <p>This parameter is required.</p>
     */
    @NameInMap("inputPhoneNum")
    public String inputPhoneNum;

    public static CreateNoteForIsvRequest build(java.util.Map<String, ?> map) throws Exception {
        CreateNoteForIsvRequest self = new CreateNoteForIsvRequest();
        return TeaModel.build(map, self);
    }

    public CreateNoteForIsvRequest setContactName(String contactName) {
        this.contactName = contactName;
        return this;
    }
    public String getContactName() {
        return this.contactName;
    }

    public CreateNoteForIsvRequest setContactPhoneNum(String contactPhoneNum) {
        this.contactPhoneNum = contactPhoneNum;
        return this;
    }
    public String getContactPhoneNum() {
        return this.contactPhoneNum;
    }

    public CreateNoteForIsvRequest setContactTitle(String contactTitle) {
        this.contactTitle = contactTitle;
        return this;
    }
    public String getContactTitle() {
        return this.contactTitle;
    }

    public CreateNoteForIsvRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public CreateNoteForIsvRequest setCorpId(String corpId) {
        this.corpId = corpId;
        return this;
    }
    public String getCorpId() {
        return this.corpId;
    }

    public CreateNoteForIsvRequest setInputPhoneNum(String inputPhoneNum) {
        this.inputPhoneNum = inputPhoneNum;
        return this;
    }
    public String getInputPhoneNum() {
        return this.inputPhoneNum;
    }

}
