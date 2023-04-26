<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetProcessInstanceResponseBody\result\operationRecords\attachments;
use AlibabaCloud\Tea\Model;

class operationRecords extends Model
{
    /**
     * @var attachments[]
     */
    public $attachments;

    /**
     * @var string[]
     */
    public $ccUserIds;

    /**
     * @example 2022-08-31T11:52Z
     *
     * @var string
     */
    public $date;

    /**
     * @example 评论
     *
     * @var string
     */
    public $remark;

    /**
     * @example AGREE
     *
     * @var string
     */
    public $result;

    /**
     * @example EXECUTE_TASK_NORMAL
     *
     * @var string
     */
    public $type;

    /**
     * @example manager1
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
