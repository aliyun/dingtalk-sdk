<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeAddStudentRequest extends Model
{
    /**
     * @example 6235234
     *
     * @var int
     */
    public $deptId;

    /**
     * @example ”city“:"Beijing"
     *
     * @var string[]
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
     * @example 186xxxxxxxx
     *
     * @var string
     */
    public $mobile;

    /**
     * @example 2015
     *
     * @var string
     */
    public $startYear;

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
     * @example 0324124
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'deptId'        => 'deptId',
        'empExtension'  => 'empExtension',
        'gender'        => 'gender',
        'identifyId'    => 'identifyId',
        'mobile'        => 'mobile',
        'startYear'     => 'startYear',
        'studentName'   => 'studentName',
        'studentNumber' => 'studentNumber',
        'userId'        => 'userId',
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
        if (null !== $this->empExtension) {
            $res['empExtension'] = $this->empExtension;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->identifyId) {
            $res['identifyId'] = $this->identifyId;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->startYear) {
            $res['startYear'] = $this->startYear;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CollegeAddStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
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
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['startYear'])) {
            $model->startYear = $map['startYear'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
