<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetEnableRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @description This parameter is required.
     *
     * @example userIdXXX
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'permissionCode' => 'permissionCode',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetEnableRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
