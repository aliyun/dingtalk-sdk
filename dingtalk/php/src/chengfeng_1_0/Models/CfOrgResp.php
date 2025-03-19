<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class CfOrgResp extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 01
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description This parameter is required.
     *
     * @example 一级部门
     *
     * @var string
     */
    public $deptName;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $level;

    /**
     * @description This parameter is required.
     *
     * @example 1/01
     *
     * @var string
     */
    public $organizationCodePath;

    /**
     * @description This parameter is required.
     *
     * @example 公司/一级部门
     *
     * @var string
     */
    public $organizationPath;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var string
     */
    public $parentDeptCode;
    protected $_name = [
        'deptCode' => 'deptCode',
        'deptName' => 'deptName',
        'level' => 'level',
        'organizationCodePath' => 'organizationCodePath',
        'organizationPath' => 'organizationPath',
        'parentDeptCode' => 'parentDeptCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->level) {
            $res['level'] = $this->level;
        }
        if (null !== $this->organizationCodePath) {
            $res['organizationCodePath'] = $this->organizationCodePath;
        }
        if (null !== $this->organizationPath) {
            $res['organizationPath'] = $this->organizationPath;
        }
        if (null !== $this->parentDeptCode) {
            $res['parentDeptCode'] = $this->parentDeptCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CfOrgResp
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['level'])) {
            $model->level = $map['level'];
        }
        if (isset($map['organizationCodePath'])) {
            $model->organizationCodePath = $map['organizationCodePath'];
        }
        if (isset($map['organizationPath'])) {
            $model->organizationPath = $map['organizationPath'];
        }
        if (isset($map['parentDeptCode'])) {
            $model->parentDeptCode = $map['parentDeptCode'];
        }

        return $model;
    }
}
