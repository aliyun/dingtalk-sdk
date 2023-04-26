<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vmicro_app_1_0\Models\AddAppRolesToMemberResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 123
     *
     * @var int
     */
    public $latestScopeVersion;

    /**
     * @example 123
     *
     * @var int
     */
    public $roleId;

    /**
     * @example userNoPrivilegeToManageApp
     *
     * @var string
     */
    public $subErrorCode;

    /**
     * @example 传入的角色范围数据版本号不合法
     *
     * @var string
     */
    public $subErrorMsg;

    /**
     * @example true
     *
     * @var bool
     */
    public $success;
    protected $_name = [
        'latestScopeVersion' => 'latestScopeVersion',
        'roleId'             => 'roleId',
        'subErrorCode'       => 'subErrorCode',
        'subErrorMsg'        => 'subErrorMsg',
        'success'            => 'success',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->latestScopeVersion) {
            $res['latestScopeVersion'] = $this->latestScopeVersion;
        }
        if (null !== $this->roleId) {
            $res['roleId'] = $this->roleId;
        }
        if (null !== $this->subErrorCode) {
            $res['subErrorCode'] = $this->subErrorCode;
        }
        if (null !== $this->subErrorMsg) {
            $res['subErrorMsg'] = $this->subErrorMsg;
        }
        if (null !== $this->success) {
            $res['success'] = $this->success;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['latestScopeVersion'])) {
            $model->latestScopeVersion = $map['latestScopeVersion'];
        }
        if (isset($map['roleId'])) {
            $model->roleId = $map['roleId'];
        }
        if (isset($map['subErrorCode'])) {
            $model->subErrorCode = $map['subErrorCode'];
        }
        if (isset($map['subErrorMsg'])) {
            $model->subErrorMsg = $map['subErrorMsg'];
        }
        if (isset($map['success'])) {
            $model->success = $map['success'];
        }

        return $model;
    }
}
