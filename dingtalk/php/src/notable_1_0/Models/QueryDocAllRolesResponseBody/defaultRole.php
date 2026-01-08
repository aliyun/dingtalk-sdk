<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vnotable_1_0\Models\QueryDocAllRolesResponseBody;

use AlibabaCloud\Tea\Model;

class defaultRole extends Model
{
    /**
     * @var int
     */
    public $mode;

    /**
     * @var int
     */
    public $roleId;
    protected $_name = [
        'mode' => 'mode',
        'roleId' => 'roleId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mode) {
            $res['mode'] = $this->mode;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return defaultRole
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mode'])) {
            $model->mode = $map['mode'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }

        return $model;
    }
}
