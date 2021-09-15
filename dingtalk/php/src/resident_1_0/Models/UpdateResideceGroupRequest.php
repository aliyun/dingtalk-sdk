<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vresident_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateResideceGroupRequest extends Model
{
    /**
     * @description 组长userid
     *
     * @var string
     */
    public $managerUserId;

    /**
     * @description 组名字
     *
     * @var string
     */
    public $name;

    /**
     * @description 组id
     *
     * @var int
     */
    public $departmentId;
    protected $_name = [
        'managerUserId' => 'managerUserId',
        'name'          => 'name',
        'departmentId'  => 'departmentId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->managerUserId) {
            $res['managerUserId'] = $this->managerUserId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->departmentId) {
            $res['departmentId'] = $this->departmentId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateResideceGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['managerUserId'])) {
            $model->managerUserId = $map['managerUserId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['departmentId'])) {
            $model->departmentId = $map['departmentId'];
        }

        return $model;
    }
}
