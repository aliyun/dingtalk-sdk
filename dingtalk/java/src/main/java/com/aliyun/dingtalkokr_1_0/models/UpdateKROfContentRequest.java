// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkokr_1_0.models;

import com.aliyun.tea.*;

public class UpdateKROfContentRequest extends TeaModel {
    // KR的内容。
    @NameInMap("content")
    public String content;

    // 待更新的划词 ID 列表。
    @NameInMap("updateQuoteList")
    public java.util.List<String> updateQuoteList;

    // 当前 KR ID。
    @NameInMap("krId")
    public String krId;

    // 当前用户的userId。
    @NameInMap("userId")
    public String userId;

    public static UpdateKROfContentRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateKROfContentRequest self = new UpdateKROfContentRequest();
        return TeaModel.build(map, self);
    }

    public UpdateKROfContentRequest setContent(String content) {
        this.content = content;
        return this;
    }
    public String getContent() {
        return this.content;
    }

    public UpdateKROfContentRequest setUpdateQuoteList(java.util.List<String> updateQuoteList) {
        this.updateQuoteList = updateQuoteList;
        return this;
    }
    public java.util.List<String> getUpdateQuoteList() {
        return this.updateQuoteList;
    }

    public UpdateKROfContentRequest setKrId(String krId) {
        this.krId = krId;
        return this;
    }
    public String getKrId() {
        return this.krId;
    }

    public UpdateKROfContentRequest setUserId(String userId) {
        this.userId = userId;
        return this;
    }
    public String getUserId() {
        return this.userId;
    }

}
