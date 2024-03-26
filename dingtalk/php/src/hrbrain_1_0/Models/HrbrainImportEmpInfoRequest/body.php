<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainImportEmpInfoRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @var string
     */
    public $birthday;

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
    public $empSource;

    /**
     * @var string
     */
    public $empStatus;

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
    public $gender;

    /**
     * @var string
     */
    public $highestDegree;

    /**
     * @var string
     */
    public $highestEduName;

    /**
     * @var string
     */
    public $isDimission;

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
    public $lastSchoolName;

    /**
     * @var string
     */
    public $marriage;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $nation;

    /**
     * @var string
     */
    public $nationCtry;

    /**
     * @var string
     */
    public $politicalStatus;

    /**
     * @var string
     */
    public $postName;

    /**
     * @var string
     */
    public $registDate;

    /**
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
     * @var string
     */
    public $workEmail;

    /**
     * @var string
     */
    public $workLocAddr;

    /**
     * @var string
     */
    public $workLocCity;

    /**
     * @var string
     */
    public $workNo;
    protected $_name = [
        'birthday'        => 'birthday',
        'deptName'        => 'deptName',
        'deptNo'          => 'deptNo',
        'dimissionDate'   => 'dimissionDate',
        'empSource'       => 'empSource',
        'empStatus'       => 'empStatus',
        'empType'         => 'empType',
        'extendInfo'      => 'extendInfo',
        'gender'          => 'gender',
        'highestDegree'   => 'highestDegree',
        'highestEduName'  => 'highestEduName',
        'isDimission'     => 'isDimission',
        'jobCodeName'     => 'jobCodeName',
        'jobLevel'        => 'jobLevel',
        'lastSchoolName'  => 'lastSchoolName',
        'marriage'        => 'marriage',
        'name'            => 'name',
        'nation'          => 'nation',
        'nationCtry'      => 'nationCtry',
        'politicalStatus' => 'politicalStatus',
        'postName'        => 'postName',
        'registDate'      => 'registDate',
        'regularDate'     => 'regularDate',
        'superEmpId'      => 'superEmpId',
        'superName'       => 'superName',
        'workEmail'       => 'workEmail',
        'workLocAddr'     => 'workLocAddr',
        'workLocCity'     => 'workLocCity',
        'workNo'          => 'workNo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->birthday) {
            $res['birthday'] = $this->birthday;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->dimissionDate) {
            $res['dimissionDate'] = $this->dimissionDate;
        }
        if (null !== $this->empSource) {
            $res['empSource'] = $this->empSource;
        }
        if (null !== $this->empStatus) {
            $res['empStatus'] = $this->empStatus;
        }
        if (null !== $this->empType) {
            $res['empType'] = $this->empType;
        }
        if (null !== $this->extendInfo) {
            $res['extendInfo'] = $this->extendInfo;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->highestDegree) {
            $res['highestDegree'] = $this->highestDegree;
        }
        if (null !== $this->highestEduName) {
            $res['highestEduName'] = $this->highestEduName;
        }
        if (null !== $this->isDimission) {
            $res['isDimission'] = $this->isDimission;
        }
        if (null !== $this->jobCodeName) {
            $res['jobCodeName'] = $this->jobCodeName;
        }
        if (null !== $this->jobLevel) {
            $res['jobLevel'] = $this->jobLevel;
        }
        if (null !== $this->lastSchoolName) {
            $res['lastSchoolName'] = $this->lastSchoolName;
        }
        if (null !== $this->marriage) {
            $res['marriage'] = $this->marriage;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->nation) {
            $res['nation'] = $this->nation;
        }
        if (null !== $this->nationCtry) {
            $res['nationCtry'] = $this->nationCtry;
        }
        if (null !== $this->politicalStatus) {
            $res['politicalStatus'] = $this->politicalStatus;
        }
        if (null !== $this->postName) {
            $res['postName'] = $this->postName;
        }
        if (null !== $this->registDate) {
            $res['registDate'] = $this->registDate;
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
        if (null !== $this->workEmail) {
            $res['workEmail'] = $this->workEmail;
        }
        if (null !== $this->workLocAddr) {
            $res['workLocAddr'] = $this->workLocAddr;
        }
        if (null !== $this->workLocCity) {
            $res['workLocCity'] = $this->workLocCity;
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
        if (isset($map['birthday'])) {
            $model->birthday = $map['birthday'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['dimissionDate'])) {
            $model->dimissionDate = $map['dimissionDate'];
        }
        if (isset($map['empSource'])) {
            $model->empSource = $map['empSource'];
        }
        if (isset($map['empStatus'])) {
            $model->empStatus = $map['empStatus'];
        }
        if (isset($map['empType'])) {
            $model->empType = $map['empType'];
        }
        if (isset($map['extendInfo'])) {
            $model->extendInfo = $map['extendInfo'];
        }
        if (isset($map['gender'])) {
            $model->gender = $map['gender'];
        }
        if (isset($map['highestDegree'])) {
            $model->highestDegree = $map['highestDegree'];
        }
        if (isset($map['highestEduName'])) {
            $model->highestEduName = $map['highestEduName'];
        }
        if (isset($map['isDimission'])) {
            $model->isDimission = $map['isDimission'];
        }
        if (isset($map['jobCodeName'])) {
            $model->jobCodeName = $map['jobCodeName'];
        }
        if (isset($map['jobLevel'])) {
            $model->jobLevel = $map['jobLevel'];
        }
        if (isset($map['lastSchoolName'])) {
            $model->lastSchoolName = $map['lastSchoolName'];
        }
        if (isset($map['marriage'])) {
            $model->marriage = $map['marriage'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['nation'])) {
            $model->nation = $map['nation'];
        }
        if (isset($map['nationCtry'])) {
            $model->nationCtry = $map['nationCtry'];
        }
        if (isset($map['politicalStatus'])) {
            $model->politicalStatus = $map['politicalStatus'];
        }
        if (isset($map['postName'])) {
            $model->postName = $map['postName'];
        }
        if (isset($map['registDate'])) {
            $model->registDate = $map['registDate'];
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
        if (isset($map['workEmail'])) {
            $model->workEmail = $map['workEmail'];
        }
        if (isset($map['workLocAddr'])) {
            $model->workLocAddr = $map['workLocAddr'];
        }
        if (isset($map['workLocCity'])) {
            $model->workLocCity = $map['workLocCity'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }

        return $model;
    }
}
