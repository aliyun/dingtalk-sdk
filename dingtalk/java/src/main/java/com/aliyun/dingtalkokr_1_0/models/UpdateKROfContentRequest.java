// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfContentRequest extends TeaModel {
    @NameInMap("content")
    public java.io.InputStream content;

    @NameInMap("updateQuoteList")
    public java.util.List<java.io.InputStream> updateQuoteList;

    // A short description of struct
    @NameInMap("krId")
    public java.io.InputStream krId;

    @NameInMap("operatorUid")
    public java.io.InputStream operatorUid;

    public static UpdateKROfContentRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfContentRequest self = new UpdateKROfContentRequest();
        return TeaModel.build(map, self);
    }

    public UpdateKROfContentRequest setContent(java.io.InputStream content) {
        this.content = content;
        return this;
    }
    public java.io.InputStream getContent() {
        return this.content;
    }

    public UpdateKROfContentRequest setUpdateQuoteList(java.util.List<java.io.InputStream> updateQuoteList) {
        this.updateQuoteList = updateQuoteList;
        return this;
    }
    public java.util.List<java.io.InputStream> getUpdateQuoteList() {
        return this.updateQuoteList;
    }

    public UpdateKROfContentRequest setKrId(java.io.InputStream krId) {
        this.krId = krId;
        return this;
    }
    public java.io.InputStream getKrId() {
        return this.krId;
    }

    public UpdateKROfContentRequest setOperatorUid(java.io.InputStream operatorUid) {
        this.operatorUid = operatorUid;
        return this;
    }
    public java.io.InputStream getOperatorUid() {
        return this.operatorUid;
    }

}
