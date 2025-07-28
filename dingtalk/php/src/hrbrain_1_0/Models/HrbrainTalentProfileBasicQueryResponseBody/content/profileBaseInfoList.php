<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainTalentProfileBasicQueryResponseBody\content;

use AlibabaCloud\Tea\Model;

class profileBaseInfoList extends Model
{
    /**
     * @var string
     */
    public $age;

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
    public $gender;

    /**
     * @var string
     */
    public $jobLevel;

    /**
     * @var string
     */
    public $jobcode;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $position;

    /**
     * @var string
     */
    public $seniorityYears;

    /**
     * @var string
     */
    public $superName;

    /**
     * @var string
     */
    public $superWorkNo;

    /**
     * @var string
     */
    public $workNo;

    /**
     * @var string
     */
    public $workPlace;
    protected $_name = [
        'age' => 'age',
        'birthday' => 'birthday',
        'deptName' => 'deptName',
        'deptNo' => 'deptNo',
        'gender' => 'gender',
        'jobLevel' => 'jobLevel',
        'jobcode' => 'jobcode',
        'name' => 'name',
        'position' => 'position',
        'seniorityYears' => 'seniorityYears',
        'superName' => 'superName',
        'superWorkNo' => 'superWorkNo',
        'workNo' => 'workNo',
        'workPlace' => 'workPlace',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->age) {
            $res['age'] = $this->age;
        }
        if (null !== $this->birthday) {
            $res['birthday'] = $this->birthday;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->deptNo) {
            $res['deptNo'] = $this->deptNo;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->jobLevel) {
            $res['jobLevel'] = $this->jobLevel;
        }
        if (null !== $this->jobcode) {
            $res['jobcode'] = $this->jobcode;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->position) {
            $res['position'] = $this->position;
        }
        if (null !== $this->seniorityYears) {
            $res['seniorityYears'] = $this->seniorityYears;
        }
        if (null !== $this->superName) {
            $res['superName'] = $this->superName;
        }
        if (null !== $this->superWorkNo) {
            $res['superWorkNo'] = $this->superWorkNo;
        }
        if (null !== $this->workNo) {
            $res['workNo'] = $this->workNo;
        }
        if (null !== $this->workPlace) {
            $res['workPlace'] = $this->workPlace;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return profileBaseInfoList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['age'])) {
            $model->age = $map['age'];
        }
        if (isset($map['birthday'])) {
            $model->birthday = $map['birthday'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['deptNo'])) {
            $model->deptNo = $map['deptNo'];
        }
        if (isset($map['gender'])) {
            $model->gender = $map['gender'];
        }
        if (isset($map['jobLevel'])) {
            $model->jobLevel = $map['jobLevel'];
        }
        if (isset($map['jobcode'])) {
            $model->jobcode = $map['jobcode'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['position'])) {
            $model->position = $map['position'];
        }
        if (isset($map['seniorityYears'])) {
            $model->seniorityYears = $map['seniorityYears'];
        }
        if (isset($map['superName'])) {
            $model->superName = $map['superName'];
        }
        if (isset($map['superWorkNo'])) {
            $model->superWorkNo = $map['superWorkNo'];
        }
        if (isset($map['workNo'])) {
            $model->workNo = $map['workNo'];
        }
        if (isset($map['workPlace'])) {
            $model->workPlace = $map['workPlace'];
        }

        return $model;
    }
}
