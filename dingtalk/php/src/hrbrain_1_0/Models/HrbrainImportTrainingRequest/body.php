<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportTrainingRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $certifCnt;

    /**
     * @var string
     */
    public $creditScore;

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
    public $postName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainEndDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainName;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $trainStartDate;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $workNo;
    protected $_name = [
        'certifCnt' => 'certifCnt',
        'creditScore' => 'creditScore',
        'deptName' => 'deptName',
        'deptNo' => 'deptNo',
        'extendInfo' => 'extendInfo',
        'jobCodeName' => 'jobCodeName',
        'jobLevel' => 'jobLevel',
        'name' => 'name',
        'postName' => 'postName',
        'trainEndDate' => 'trainEndDate',
        'trainName' => 'trainName',
        'trainStartDate' => 'trainStartDate',
        'workNo' => 'workNo',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->certifCnt) {
            $res['certifCnt'] = $this->certifCnt;
        }
        if (null !== $this->creditScore) {
            $res['creditScore'] = $this->creditScore;
        }
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
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->trainEndDate) {
            $res['trainEndDate'] = $this->trainEndDate;
        }
        if (null !== $this->trainName) {
            $res['trainName'] = $this->trainName;
        }
        if (null !== $this->trainStartDate) {
            $res['trainStartDate'] = $this->trainStartDate;
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
        if (isset($map['certifCnt'])) {
            $model->certifCnt = $map['certifCnt'];
        }
        if (isset($map['creditScore'])) {
            $model->creditScore = $map['creditScore'];
        }
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
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['trainEndDate'])) {
            $model->trainEndDate = $map['trainEndDate'];
        }
        if (isset($map['trainName'])) {
            $model->trainName = $map['trainName'];
        }
        if (isset($map['trainStartDate'])) {
            $model->trainStartDate = $map['trainStartDate'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
