<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeQueryStudentInfoByDeptResponseBody extends Model
{
    /**
     * @example 01123
     *
     * @var int
     */
    public $deptId;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $dingMemberStatus;

    /**
     * @example ”city“:"Beijing"
     *
     * @var mixed[]
     */
    public $empExtension;

    /**
     * @example male
     *
     * @var string
     */
    public $gender;

    /**
     * @example 11019xxxxxx0001
     *
     * @var string
     */
    public $identifyId;

    /**
     * @example true
     *
     * @var bool
     */
    public $isActive;

    /**
     * @example 2015
     *
     * @var string
     */
    public $startYear;

    /**
     * @example 1111111
     *
     * @var int
     */
    public $studentId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $studentName;

    /**
     * @example mf1922051
     *
     * @var string
     */
    public $studentNumber;

    /**
     * @example 11111111
     *
     * @var string
     */
    public $unionId;

    /**
     * @example 0324124
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'           => 'deptId',
        'dingMemberStatus' => 'dingMemberStatus',
        'empExtension'     => 'empExtension',
        'gender'           => 'gender',
        'identifyId'       => 'identifyId',
        'isActive'         => 'isActive',
        'startYear'        => 'startYear',
        'studentId'        => 'studentId',
        'studentName'      => 'studentName',
        'studentNumber'    => 'studentNumber',
        'unionId'          => 'unionId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->dingMemberStatus) {
            $res['dingMemberStatus'] = $this->dingMemberStatus;
        }
        if (null !== $this->empExtension) {
            $res['empExtension'] = $this->empExtension;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->identifyId) {
            $res['identifyId'] = $this->identifyId;
        }
        if (null !== $this->isActive) {
            $res['isActive'] = $this->isActive;
        }
        if (null !== $this->startYear) {
            $res['startYear'] = $this->startYear;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeQueryStudentInfoByDeptResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['dingMemberStatus'])) {
            $model->dingMemberStatus = $map['dingMemberStatus'];
        }
        if (isset($map['empExtension'])) {
            $model->empExtension = $map['empExtension'];
        }
        if (isset($map['gender'])) {
            $model->gender = $map['gender'];
        }
        if (isset($map['identifyId'])) {
            $model->identifyId = $map['identifyId'];
        }
        if (isset($map['isActive'])) {
            $model->isActive = $map['isActive'];
        }
        if (isset($map['startYear'])) {
            $model->startYear = $map['startYear'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
