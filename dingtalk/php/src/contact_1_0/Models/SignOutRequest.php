<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class SignOutRequest extends Model
{
    /**
     * @var string
     */
    public $permissionCode;

    /**
     * @var string
     */
    public $reason;

    /**
     * @var string[]
     */
    public $reasonI18nForEmployee;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'permissionCode' => 'permissionCode',
        'reason' => 'reason',
        'reasonI18nForEmployee' => 'reasonI18nForEmployee',
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
        if (null !== $this->reasonI18nForEmployee) {
            $res['reasonI18nForEmployee'] = $this->reasonI18nForEmployee;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SignOutRequest
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
        if (isset($map['reasonI18nForEmployee'])) {
            $model->reasonI18nForEmployee = $map['reasonI18nForEmployee'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
