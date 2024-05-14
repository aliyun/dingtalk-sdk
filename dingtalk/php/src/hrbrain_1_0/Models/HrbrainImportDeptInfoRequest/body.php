<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDeptInfoRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $createDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deptName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $deptNo;

    /**
     * @var string
     */
    public $effectiveDate;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $isEffective;

    /**
     * @var string
     */
    public $superDeptName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $superDeptNo;

    /**
     * @var string
     */
    public $superEmpId;

    /**
     * @var string
     */
    public $superName;
    protected $_name = [
        'createDate'    => 'createDate',
        'deptName'      => 'deptName',
        'deptNo'        => 'deptNo',
        'effectiveDate' => 'effectiveDate',
        'extendInfo'    => 'extendInfo',
        'isEffective'   => 'isEffective',
        'superDeptName' => 'superDeptName',
        'superDeptNo'   => 'superDeptNo',
        'superEmpId'    => 'superEmpId',
        'superName'     => 'superName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createDate) {
            $res['createDate'] = $this->createDate;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->effectiveDate) {
            $res['effectiveDate'] = $this->effectiveDate;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->isEffective) {
            $res['isEffective'] = $this->isEffective;
        }
        if (null !== $this->superDeptName) {
            $res['superDeptName'] = $this->superDeptName;
        }
        if (null !== $this->superDeptNo) {
            $res['superDeptNo'] = $this->superDeptNo;
        }
        if (null !== $this->superEmpId) {
            $res['superEmpId'] = $this->superEmpId;
        }
        if (null !== $this->superName) {
            $res['superName'] = $this->superName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createDate'])) {
            $model->createDate = $map['createDate'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['effectiveDate'])) {
            $model->effectiveDate = $map['effectiveDate'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['isEffective'])) {
            $model->isEffective = $map['isEffective'];
        }
        if (isset($map['superDeptName'])) {
            $model->superDeptName = $map['superDeptName'];
        }
        if (isset($map['superDeptNo'])) {
            $model->superDeptNo = $map['superDeptNo'];
        }
        if (isset($map['superEmpId'])) {
            $model->superEmpId = $map['superEmpId'];
        }
        if (isset($map['superName'])) {
            $model->superName = $map['superName'];
        }

        return $model;
    }
}
