<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateWorkTimeApproveRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $workTimeIds;
    protected $_name = [
        'workTimeIds' => 'workTimeIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->workTimeIds) {
            $res['workTimeIds'] = $this->workTimeIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateWorkTimeApproveRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['workTimeIds'])) {
            if (!empty($map['workTimeIds'])) {
                $model->workTimeIds = $map['workTimeIds'];
            }
        }

        return $model;
    }
}
