<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegularRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $deptName;

    /**
     * @var string
     */
    public $deptNo;

    /**
     * @var mixed[]
     */
    public $extendInfo;

    /**
     * @var string
     */
    public $jobCodeName;

    /**
     * @var string
     */
    public $jobLevel;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $planRegularDate;

    /**
     * @var string
     */
    public $postName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $regularDate;

    /**
     * @var string
     */
    public $superEmpId;

    /**
     * @var string
     */
    public $superName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'deptName' => 'deptName',
        'deptNo' => 'deptNo',
        'extendInfo' => 'extendInfo',
        'jobCodeName' => 'jobCodeName',
        'jobLevel' => 'jobLevel',
        'name' => 'name',
        'planRegularDate' => 'planRegularDate',
        'postName' => 'postName',
        'regularDate' => 'regularDate',
        'superEmpId' => 'superEmpId',
        'superName' => 'superName',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->jobCodeName) {
            $res['jobCodeName'] = $this->jobCodeName;
        }
        if (null !== $this->jobLevel) {
            $res['jobLevel'] = $this->jobLevel;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->planRegularDate) {
            $res['planRegularDate'] = $this->planRegularDate;
        }
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->regularDate) {
            $res['regularDate'] = $this->regularDate;
        }
        if (null !== $this->superEmpId) {
            $res['superEmpId'] = $this->superEmpId;
        }
        if (null !== $this->superName) {
            $res['superName'] = $this->superName;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
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
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['jobCodeName'])) {
            $model->jobCodeName = $map['jobCodeName'];
        }
        if (isset($map['jobLevel'])) {
            $model->jobLevel = $map['jobLevel'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['planRegularDate'])) {
            $model->planRegularDate = $map['planRegularDate'];
        }
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['regularDate'])) {
            $model->regularDate = $map['regularDate'];
        }
        if (isset($map['superEmpId'])) {
            $model->superEmpId = $map['superEmpId'];
        }
        if (isset($map['superName'])) {
            $model->superName = $map['superName'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
