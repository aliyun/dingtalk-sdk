<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskStageRequest extends Model
{
    /**
     * @example 64ba333e4206372f3f5cxxxx
     *
     * @var string
     */
    public $taskStageId;
    protected $_name = [
        'taskStageId' => 'taskStageId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->taskStageId) {
            $res['taskStageId'] = $this->taskStageId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateTaskStageRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['taskStageId'])) {
            $model->taskStageId = $map['taskStageId'];
        }

        return $model;
    }
}
