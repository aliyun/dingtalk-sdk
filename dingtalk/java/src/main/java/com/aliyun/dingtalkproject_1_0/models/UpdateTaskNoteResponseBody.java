// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.dingtalkproject_1_0.models;

import com.aliyun.tea.*;

public class UpdateTaskNoteResponseBody extends TeaModel {
    /**
     * <p>结果</p>
     */
    @NameInMap("result")
    public UpdateTaskNoteResponseBodyResult result;

    public static UpdateTaskNoteResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateTaskNoteResponseBody self = new UpdateTaskNoteResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateTaskNoteResponseBody setResult(UpdateTaskNoteResponseBodyResult result) {
        this.result = result;
        return this;
    }
    public UpdateTaskNoteResponseBodyResult getResult() {
        return this.result;
    }

    public static class UpdateTaskNoteResponseBodyResult extends TeaModel {
        /**
         * <p>任务备注。</p>
         */
        @NameInMap("note")
        public String note;

        /**
         * <p>更新时间。</p>
         */
        @NameInMap("updated")
        public String updated;

        public static UpdateTaskNoteResponseBodyResult build(java.util.Map<String, ?> map) throws Exception {
            UpdateTaskNoteResponseBodyResult self = new UpdateTaskNoteResponseBodyResult();
            return TeaModel.build(map, self);
        }

        public UpdateTaskNoteResponseBodyResult setNote(String note) {
            this.note = note;
            return this;
        }
        public String getNote() {
            return this.note;
        }

        public UpdateTaskNoteResponseBodyResult setUpdated(String updated) {
            this.updated = updated;
            return this;
        }
        public String getUpdated() {
            return this.updated;
        }

    }

}
