<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateUniversityStudentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var int
     */
    public $classId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $gender;

    /**
     * @var string
     */
    public $identityNumber;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $mobile;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $studentNumber;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'classId' => 'classId',
        'gender' => 'gender',
        'identityNumber' => 'identityNumber',
        'mobile' => 'mobile',
        'name' => 'name',
        'studentNumber' => 'studentNumber',
        'opUserId' => 'opUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->gender) {
            $res['gender'] = $this->gender;
        }
        if (null !== $this->identityNumber) {
            $res['identityNumber'] = $this->identityNumber;
        }
        if (null !== $this->mobile) {
            $res['mobile'] = $this->mobile;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->studentNumber) {
            $res['studentNumber'] = $this->studentNumber;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateUniversityStudentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['gender'])) {
            $model->gender = $map['gender'];
        }
        if (isset($map['identityNumber'])) {
            $model->identityNumber = $map['identityNumber'];
        }
        if (isset($map['mobile'])) {
            $model->mobile = $map['mobile'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['studentNumber'])) {
            $model->studentNumber = $map['studentNumber'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
