<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result\list_;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumGetProcessInstancesResponseBody\result\list_\operationRecords\attachments;
use AlibabaCloud\Tea\Model;

class operationRecords extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;

    /**
     * @example EXECUTE_TASK_NORMAL（正常执行任务），EXECUTE_TASK_AGENT（代理人执行任务），APPEND_TASK_BEFORE（前加签任务），APPEND_TASK_AFTER（后加签任务），REDIRECT_TASK（转交任务），START_PROCESS_INSTANCE（发起流程实例），TERMINATE_PROCESS_INSTANCE（终止(撤销)流程实例），FINISH_PROCESS_INSTANCE（结束流程实例），ADD_REMARK（添加评论）
     *
     * @var string
     */
    public $operationType;

    /**
     * @example 同意
     *
     * @var string
     */
    public $remark;

    /**
     * @example AGREE（同意），REFUSE（拒绝），NONE（未知）
     *
     * @var string
     */
    public $result;

    /**
     * @example 1657522271000
     *
     * @var int
     */
    public $timestamp;

    /**
     * @example manager1
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'attachments'   => 'attachments',
        'operationType' => 'operationType',
        'remark'        => 'remark',
        'result'        => 'result',
        'timestamp'     => 'timestamp',
        'userId'        => 'userId',
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
        if (null !== $this->operationType) {
            $res['operationType'] = $this->operationType;
        }
        if (null !== $this->remark) {
            $res['remark'] = $this->remark;
        }
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->timestamp) {
            $res['timestamp'] = $this->timestamp;
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
        if (isset($map['operationType'])) {
            $model->operationType = $map['operationType'];
        }
        if (isset($map['remark'])) {
            $model->remark = $map['remark'];
        }
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['timestamp'])) {
            $model->timestamp = $map['timestamp'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
