<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportRegistRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
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
     * @description This parameter is required.
     *
     * @var string
     */
    public $empSource;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $empType;

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
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $postName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $registDate;

    /**
     * @var string
     */
    public $superName;

    /**
     * @var string
     */
    public $workLocAddr;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'deptName'    => 'deptName',
        'deptNo'      => 'deptNo',
        'empSource'   => 'empSource',
        'empType'     => 'empType',
        'extendInfo'  => 'extendInfo',
        'jobCodeName' => 'jobCodeName',
        'jobLevel'    => 'jobLevel',
        'name'        => 'name',
        'postName'    => 'postName',
        'registDate'  => 'registDate',
        'superName'   => 'superName',
        'workLocAddr' => 'workLocAddr',
        'workNo'      => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->empSource) {
            $res['empSource'] = $this->empSource;
        }
        if (null !== $this->empType) {
            $res['empType'] = $this->empType;
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
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->registDate) {
            $res['registDate'] = $this->registDate;
        }
        if (null !== $this->superName) {
            $res['superName'] = $this->superName;
        }
        if (null !== $this->workLocAddr) {
            $res['workLocAddr'] = $this->workLocAddr;
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
        if (isset($map['empSource'])) {
            $model->empSource = $map['empSource'];
        }
        if (isset($map['empType'])) {
            $model->empType = $map['empType'];
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
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['registDate'])) {
            $model->registDate = $map['registDate'];
        }
        if (isset($map['superName'])) {
            $model->superName = $map['superName'];
        }
        if (isset($map['workLocAddr'])) {
            $model->workLocAddr = $map['workLocAddr'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
