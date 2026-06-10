<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListSeniorSettingsRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $seniorStaffId;
    protected $_name = [
        'permissionCode' => 'permissionCode',
        'seniorStaffId' => 'seniorStaffId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->seniorStaffId) {
            $res['seniorStaffId'] = $this->seniorStaffId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListSeniorSettingsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['seniorStaffId'])) {
            $model->seniorStaffId = $map['seniorStaffId'];
        }

        return $model;
    }
}
