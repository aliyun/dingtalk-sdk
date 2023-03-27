<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\GetOrgInfoResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 部门编码
     *
     * @var string
     */
    public $deptCode;

    /**
     * @description 部门名称
     *
     * @var string
     */
    public $deptName;

    /**
     * @description 部门人数
     *
     * @var string
     */
    public $deptNum;

    /**
     * @description 部门层级
     *
     * @var string
     */
    public $level;

    /**
     * @description 部门编码路径
     *
     * @var string
     */
    public $organizationCodePath;

    /**
     * @description 部门路径
     *
     * @var string
     */
    public $organizationPath;

    /**
     * @description 父级部门编码
     *
     * @var string
     */
    public $parentDeptCode;

    /**
     * @description 部门简称
     *
     * @var string
     */
    public $shortName;

    /**
     * @description 生效日期
     *
     * @var string
     */
    public $startDate;

    /**
     * @description 失效日期
     *
     * @var string
     */
    public $stopDate;
    protected $_name = [
        'deptCode'             => 'deptCode',
        'deptName'             => 'deptName',
        'deptNum'              => 'deptNum',
        'level'                => 'level',
        'organizationCodePath' => 'organizationCodePath',
        'organizationPath'     => 'organizationPath',
        'parentDeptCode'       => 'parentDeptCode',
        'shortName'            => 'shortName',
        'startDate'            => 'startDate',
        'stopDate'             => 'stopDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptCode) {
            $res['deptCode'] = $this->deptCode;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNum) {
            $res['deptNum'] = $this->deptNum;
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
        if (null !== $this->shortName) {
            $res['shortName'] = $this->shortName;
        }
        if (null !== $this->startDate) {
            $res['startDate'] = $this->startDate;
        }
        if (null !== $this->stopDate) {
            $res['stopDate'] = $this->stopDate;
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
        if (isset($map['deptCode'])) {
            $model->deptCode = $map['deptCode'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNum'])) {
            $model->deptNum = $map['deptNum'];
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
        if (isset($map['shortName'])) {
            $model->shortName = $map['shortName'];
        }
        if (isset($map['startDate'])) {
            $model->startDate = $map['startDate'];
        }
        if (isset($map['stopDate'])) {
            $model->stopDate = $map['stopDate'];
        }

        return $model;
    }
}
