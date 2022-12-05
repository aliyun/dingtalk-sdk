<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\operationRecords\attachments;
use AlibabaCloud\Tea\Model;

class operationRecords extends Model
{
    /**
     * @description 评论附件列表。
     *
     * @var attachments[]
     */
    public $attachments;

    /**
     * @description 抄送人userIds列表
     *
     * @var string[]
     */
    public $ccUserIds;

    /**
     * @description 操作时间。
     *
     * @var string
     */
    public $date;

    /**
     * @description 评论内容。  审批操作附带评论时才返回该字段。
     *
     * @var string
     */
    public $remark;

    /**
     * @description 操作结果：  AGREE：同意  REFUSE：拒绝  NONE
     *
     * @var string
     */
    public $result;

    /**
     * @description 操作类型：  EXECUTE_TASK_NORMAL：正常执行任务  EXECUTE_TASK_AGENT：代理人执行任务  APPEND_TASK_BEFORE：前加签任务  APPEND_TASK_AFTER：后加签任务  REDIRECT_TASK：转交任务  START_PROCESS_INSTANCE：发起流程实例  TERMINATE_PROCESS_INSTANCE：终止(撤销)流程实例  FINISH_PROCESS_INSTANCE：结束流程实例  ADD_REMARK：添加评论  REDIRECT_PROCESS：审批退回  PROCESS_CC：抄送
     *
     * @var string
     */
    public $type;

    /**
     * @description 操作人userid。
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'attachments' => 'attachments',
        'ccUserIds'   => 'ccUserIds',
        'date'        => 'date',
        'remark'      => 'remark',
        'result'      => 'result',
        'type'        => 'type',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attachments) {
            $res['attachments'] = [];
            if (null !== $this->attachments && \is_array($this->attachments)) {
                $n = 0;
                foreach ($this->attachments as $item) {
                    $res['attachments'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->ccUserIds) {
            $res['ccUserIds'] = $this->ccUserIds;
        }
        if (null !== $this->date) {
            $res['date'] = $this->date;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return operationRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attachments'])) {
            if (!empty($map['attachments'])) {
                $model->attachments = [];
                $n                  = 0;
                foreach ($map['attachments'] as $item) {
                    $model->attachments[$n++] = null !== $item ? attachments::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['ccUserIds'])) {
            if (!empty($map['ccUserIds'])) {
                $model->ccUserIds = $map['ccUserIds'];
            }
        }
        if (isset($map['date'])) {
            $model->date = $map['date'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
