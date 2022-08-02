<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeRemoveManagerRequest extends Model
{
    /**
     * @description 部门id
     *
     * @var int
     */
    public $deptId;

    /**
     * @description 是否强制移除
     *
     * @var bool
     */
    public $isForce;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'  => 'deptId',
        'isForce' => 'isForce',
        'userId'  => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->isForce) {
            $res['isForce'] = $this->isForce;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeRemoveManagerRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['isForce'])) {
            $model->isForce = $map['isForce'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
