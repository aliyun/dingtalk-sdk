<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateCollegeAlumniUserInfoRequest extends Model
{
    /**
     * @var string
     */
    public $address;

    /**
     * @description This parameter is required.
     *
     * @var int[]
     */
    public $deptIds;

    /**
     * @var string
     */
    public $email;

    /**
     * @var string
     */
    public $intake;

    /**
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $operator;

    /**
     * @var string
     */
    public $outtake;

    /**
     * @var string
     */
    public $studentNumber;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'address' => 'address',
        'deptIds' => 'deptIds',
        'email' => 'email',
        'intake' => 'intake',
        'name' => 'name',
        'operator' => 'operator',
        'outtake' => 'outtake',
        'studentNumber' => 'studentNumber',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->address) {
            $res['address'] = $this->address;
        }
        if (null !== $this->deptIds) {
            $res['deptIds'] = $this->deptIds;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->intake) {
            $res['intake'] = $this->intake;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->operator) {
            $res['operator'] = $this->operator;
        }
        if (null !== $this->outtake) {
            $res['outtake'] = $this->outtake;
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
     * @return UpdateCollegeAlumniUserInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['address'])) {
            $model->address = $map['address'];
        }
        if (isset($map['deptIds'])) {
            if (!empty($map['deptIds'])) {
                $model->deptIds = $map['deptIds'];
            }
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['intake'])) {
            $model->intake = $map['intake'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['operator'])) {
            $model->operator = $map['operator'];
        }
        if (isset($map['outtake'])) {
            $model->outtake = $map['outtake'];
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
