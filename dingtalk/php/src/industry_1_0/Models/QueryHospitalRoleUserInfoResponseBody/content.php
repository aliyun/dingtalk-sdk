<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryHospitalRoleUserInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 2021-12-22 15:30:31
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @example 2021-12-22 15:30:31
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example 2783939
     *
     * @var string
     */
    public $jobNumber;

    /**
     * @example sys_admin
     *
     * @var string
     */
    public $roleCode;

    /**
     * @example 管理员
     *
     * @var string
     */
    public $roleName;

    /**
     * @var int
     */
    public $status;

    /**
     * @example 7424792
     *
     * @var string
     */
    public $userCode;

    /**
     * @example 张三
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'gmtCreate'   => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'jobNumber'   => 'jobNumber',
        'roleCode'    => 'roleCode',
        'roleName'    => 'roleName',
        'status'      => 'status',
        'userCode'    => 'userCode',
        'userName'    => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->jobNumber) {
            $res['jobNumber'] = $this->jobNumber;
        }
        if (null !== $this->roleCode) {
            $res['roleCode'] = $this->roleCode;
        }
        if (null !== $this->roleName) {
            $res['roleName'] = $this->roleName;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userCode) {
            $res['userCode'] = $this->userCode;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['jobNumber'])) {
            $model->jobNumber = $map['jobNumber'];
        }
        if (isset($map['roleCode'])) {
            $model->roleCode = $map['roleCode'];
        }
        if (isset($map['roleName'])) {
            $model->roleName = $map['roleName'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userCode'])) {
            $model->userCode = $map['userCode'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
