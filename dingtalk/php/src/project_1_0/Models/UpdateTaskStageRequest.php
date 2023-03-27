<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateTaskStageRequest extends Model
{
    /**
     * @description 任务列表Id。
     *
     * @var string
     */
    public $stageId;
    protected $_name = [
        'stageId' => 'stageId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->stageId) {
            $res['stageId'] = $this->stageId;
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
        if (isset($map['stageId'])) {
            $model->stageId = $map['stageId'];
        }

        return $model;
    }
}
