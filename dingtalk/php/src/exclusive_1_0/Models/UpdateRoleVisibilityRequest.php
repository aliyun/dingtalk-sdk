<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateRoleVisibilityRequest extends Model
{
    /**
     * @example 0.0.5
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @example 1312312
     *
     * @var int
     */
    public $labelId;

    /**
     * @example 500000003
     *
     * @var string[]
     */
    public $userIds;
    protected $_name = [
        'deptIds' => 'deptIds',
        'labelId' => 'labelId',
        'userIds' => 'userIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->labelId) {
            $res['labelId'] = $this->labelId;
        }
        if (null !== $this->userIds) {
            $res['userIds'] = $this->userIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRoleVisibilityRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['labelId'])) {
            $model->labelId = $map['labelId'];
        }
        if (isset($map['userIds'])) {
            if (!empty($map['userIds'])) {
                $model->userIds = $map['userIds'];
            }
        }

        return $model;
    }
}
