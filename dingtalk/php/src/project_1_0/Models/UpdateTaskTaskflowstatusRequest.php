<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskTaskflowstatusRequest extends Model
{
    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $taskflowStatusId;

    /**
     * @example 说明。
     *
     * @var string
     */
    public $taskflowStatusUpdateNote;
    protected $_name = [
        'taskflowStatusId' => 'taskflowStatusId',
        'taskflowStatusUpdateNote' => 'taskflowStatusUpdateNote',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskflowStatusId) {
            $res['taskflowStatusId'] = $this->taskflowStatusId;
        }
        if (null !== $this->taskflowStatusUpdateNote) {
            $res['taskflowStatusUpdateNote'] = $this->taskflowStatusUpdateNote;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskTaskflowstatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskflowStatusId'])) {
            $model->taskflowStatusId = $map['taskflowStatusId'];
        }
        if (isset($map['taskflowStatusUpdateNote'])) {
            $model->taskflowStatusUpdateNote = $map['taskflowStatusUpdateNote'];
        }

        return $model;
    }
}
