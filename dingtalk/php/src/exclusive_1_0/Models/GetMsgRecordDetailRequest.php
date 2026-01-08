<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMsgRecordDetailRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example pushkxQ2b2DTDAb0qkTjNdKLmwiEiE
     *
     * @var string
     */
    public $taskId;

    /**
     * @description This parameter is required.
     *
     * @example jYdrJoCmTo0iE
     *
     * @var string
     */
    public $unionid;
    protected $_name = [
        'taskId' => 'task_id',
        'unionid' => 'unionid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskId) {
            $res['task_id'] = $this->taskId;
        }
        if (null !== $this->unionid) {
            $res['unionid'] = $this->unionid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMsgRecordDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['task_id'])) {
            $model->taskId = $map['task_id'];
        }
        if (isset($map['unionid'])) {
            $model->unionid = $map['unionid'];
        }

        return $model;
    }
}
