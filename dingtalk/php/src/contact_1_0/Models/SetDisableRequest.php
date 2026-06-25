<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SetDisableRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @example reasonYYY
     *
     * @var string
     */
    public $reason;

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
        'reason' => 'reason',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->permissionCode) {
            $res['permissionCode'] = $this->permissionCode;
        }
        if (null !== $this->reason) {
            $res['reason'] = $this->reason;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SetDisableRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['permissionCode'])) {
            $model->permissionCode = $map['permissionCode'];
        }
        if (isset($map['reason'])) {
            $model->reason = $map['reason'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
