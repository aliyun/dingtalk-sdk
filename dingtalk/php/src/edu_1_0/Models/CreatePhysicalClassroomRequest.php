<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreatePhysicalClassroomRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 主楼
     *
     * @var string
     */
    public $classroomBuilding;

    /**
     * @description This parameter is required.
     *
     * @example 主校区
     *
     * @var string
     */
    public $classroomCampus;

    /**
     * @description This parameter is required.
     *
     * @example 2层
     *
     * @var string
     */
    public $classroomFloor;

    /**
     * @description This parameter is required.
     *
     * @example 实验室
     *
     * @var string
     */
    public $classroomName;

    /**
     * @description This parameter is required.
     *
     * @example 201
     *
     * @var string
     */
    public $classroomNumber;

    /**
     * @description This parameter is required.
     *
     * @example Y
     *
     * @var string
     */
    public $directBroadcast;

    /**
     * @example {}
     *
     * @var string
     */
    public $ext;

    /**
     * @description This parameter is required.
     *
     * @example manger1234
     *
     * @var string
     */
    public $opUserId;
    protected $_name = [
        'classroomBuilding' => 'classroomBuilding',
        'classroomCampus'   => 'classroomCampus',
        'classroomFloor'    => 'classroomFloor',
        'classroomName'     => 'classroomName',
        'classroomNumber'   => 'classroomNumber',
        'directBroadcast'   => 'directBroadcast',
        'ext'               => 'ext',
        'opUserId'          => 'opUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->classroomBuilding) {
            $res['classroomBuilding'] = $this->classroomBuilding;
        }
        if (null !== $this->classroomCampus) {
            $res['classroomCampus'] = $this->classroomCampus;
        }
        if (null !== $this->classroomFloor) {
            $res['classroomFloor'] = $this->classroomFloor;
        }
        if (null !== $this->classroomName) {
            $res['classroomName'] = $this->classroomName;
        }
        if (null !== $this->classroomNumber) {
            $res['classroomNumber'] = $this->classroomNumber;
        }
        if (null !== $this->directBroadcast) {
            $res['directBroadcast'] = $this->directBroadcast;
        }
        if (null !== $this->ext) {
            $res['ext'] = $this->ext;
        }
        if (null !== $this->opUserId) {
            $res['opUserId'] = $this->opUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreatePhysicalClassroomRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classroomBuilding'])) {
            $model->classroomBuilding = $map['classroomBuilding'];
        }
        if (isset($map['classroomCampus'])) {
            $model->classroomCampus = $map['classroomCampus'];
        }
        if (isset($map['classroomFloor'])) {
            $model->classroomFloor = $map['classroomFloor'];
        }
        if (isset($map['classroomName'])) {
            $model->classroomName = $map['classroomName'];
        }
        if (isset($map['classroomNumber'])) {
            $model->classroomNumber = $map['classroomNumber'];
        }
        if (isset($map['directBroadcast'])) {
            $model->directBroadcast = $map['directBroadcast'];
        }
        if (isset($map['ext'])) {
            $model->ext = $map['ext'];
        }
        if (isset($map['opUserId'])) {
            $model->opUserId = $map['opUserId'];
        }

        return $model;
    }
}
