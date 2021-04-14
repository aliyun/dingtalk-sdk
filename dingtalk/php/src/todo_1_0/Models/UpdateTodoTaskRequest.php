<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vtodo_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTodoTaskRequest extends Model
{
    /**
     * @description 待办标题
     *
     * @var string
     */
    public $sucject;

    /**
     * @description 待办描述备注
     *
     * @var string
     */
    public $description;

    /**
     * @description 截止时间
     *
     * @var int
     */
    public $dueTime;

    /**
     * @description 完成状态
     *
     * @var bool
     */
    public $done;

    /**
     * @description 执行者列表
     *
     * @var string[]
     */
    public $executorIds;

    /**
     * @description 参与者列表
     *
     * @var string[]
     */
    public $participantIds;

    /**
     * @description 当前操作者id
     *
     * @var string
     */
    public $operatorId;
    protected $_name = [
        'sucject'        => 'sucject',
        'description'    => 'description',
        'dueTime'        => 'dueTime',
        'done'           => 'done',
        'executorIds'    => 'executorIds',
        'participantIds' => 'participantIds',
        'operatorId'     => 'operatorId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sucject) {
            $res['sucject'] = $this->sucject;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->dueTime) {
            $res['dueTime'] = $this->dueTime;
        }
        if (null !== $this->done) {
            $res['done'] = $this->done;
        }
        if (null !== $this->executorIds) {
            $res['executorIds'] = $this->executorIds;
        }
        if (null !== $this->participantIds) {
            $res['participantIds'] = $this->participantIds;
        }
        if (null !== $this->operatorId) {
            $res['operatorId'] = $this->operatorId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTodoTaskRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sucject'])) {
            $model->sucject = $map['sucject'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['dueTime'])) {
            $model->dueTime = $map['dueTime'];
        }
        if (isset($map['done'])) {
            $model->done = $map['done'];
        }
        if (isset($map['executorIds'])) {
            if (!empty($map['executorIds'])) {
                $model->executorIds = $map['executorIds'];
            }
        }
        if (isset($map['participantIds'])) {
            if (!empty($map['participantIds'])) {
                $model->participantIds = $map['participantIds'];
            }
        }
        if (isset($map['operatorId'])) {
            $model->operatorId = $map['operatorId'];
        }

        return $model;
    }
}
