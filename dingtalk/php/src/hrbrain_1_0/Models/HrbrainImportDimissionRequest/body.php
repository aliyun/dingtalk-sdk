<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportDimissionRequest;

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
     * @var string
     */
    public $dimissionDate;

    /**
     * @var string
     */
    public $dimissionReaasonDesc;

    /**
     * @var string
     */
    public $dimissionReason;

    /**
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
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $postName;

    /**
     * @var string
     */
    public $superName;

    /**
     * @var string
     */
    public $workLocAddr;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'deptName'             => 'deptName',
        'deptNo'               => 'deptNo',
        'dimissionDate'        => 'dimissionDate',
        'dimissionReaasonDesc' => 'dimissionReaasonDesc',
        'dimissionReason'      => 'dimissionReason',
        'empType'              => 'empType',
        'extendInfo'           => 'extendInfo',
        'jobCodeName'          => 'jobCodeName',
        'jobLevel'             => 'jobLevel',
        'name'                 => 'name',
        'postName'             => 'postName',
        'superName'            => 'superName',
        'workLocAddr'          => 'workLocAddr',
        'workNo'               => 'workNo',
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
        if (null !== $this->dimissionDate) {
            $res['dimissionDate'] = $this->dimissionDate;
        }
        if (null !== $this->dimissionReaasonDesc) {
            $res['dimissionReaasonDesc'] = $this->dimissionReaasonDesc;
        }
        if (null !== $this->dimissionReason) {
            $res['dimissionReason'] = $this->dimissionReason;
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
        if (isset($map['dimissionDate'])) {
            $model->dimissionDate = $map['dimissionDate'];
        }
        if (isset($map['dimissionReaasonDesc'])) {
            $model->dimissionReaasonDesc = $map['dimissionReaasonDesc'];
        }
        if (isset($map['dimissionReason'])) {
            $model->dimissionReason = $map['dimissionReason'];
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
