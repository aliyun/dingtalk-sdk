<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryPhysicalClassroomResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 主楼
     *
     * @var string
     */
    public $classroomBuilding;

    /**
     * @example 主校区
     *
     * @var string
     */
    public $classroomCampus;

    /**
     * @example 3层
     *
     * @var string
     */
    public $classroomFloor;

    /**
     * @description This parameter is required.
     *
     * @example 10001
     *
     * @var int
     */
    public $classroomId;

    /**
     * @example 实验教室
     *
     * @var string
     */
    public $classroomName;

    /**
     * @example 301
     *
     * @var string
     */
    public $classroomNumber;

    /**
     * @example Y
     *
     * @var string
     */
    public $directBroadcast;
    protected $_name = [
        'classroomBuilding' => 'classroomBuilding',
        'classroomCampus' => 'classroomCampus',
        'classroomFloor' => 'classroomFloor',
        'classroomId' => 'classroomId',
        'classroomName' => 'classroomName',
        'classroomNumber' => 'classroomNumber',
        'directBroadcast' => 'directBroadcast',
    ];

    public function validate() {}

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
        if (null !== $this->classroomId) {
            $res['classroomId'] = $this->classroomId;
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
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
        if (isset($map['classroomId'])) {
            $model->classroomId = $map['classroomId'];
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

        return $model;
    }
}
