// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskNoteRequest extends TeaModel {
    /**
     * <p>任务备注。</p>
     */
    @NameInMap("note")
    public String note;

    public static UpdateTaskNoteRequest build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskNoteRequest self = new UpdateTaskNoteRequest();
        return TeaModel.build(map, self);
    }

    public UpdateTaskNoteRequest setNote(String note) {
        this.note = note;
        return this;
    }
    public String getNote() {
        return this.note;
    }

}
