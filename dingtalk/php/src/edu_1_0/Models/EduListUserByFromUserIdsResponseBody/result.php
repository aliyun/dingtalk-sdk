<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\EduListUserByFromUserIdsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 666666
     *
     * @var int
     */
    public $campusId;

    /**
     * @example 123456
     *
     * @var int
     */
    public $classId;

    /**
     * @example 555555
     *
     * @var int
     */
    public $gradeId;

    /**
     * @example 叔大
     *
     * @var string
     */
    public $name;

    /**
     * @example 444444
     *
     * @var int
     */
    public $periodId;

    /**
     * @var string
     */
    public $role;

    /**
     * @example 111111
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'campusId' => 'campusId',
        'classId' => 'classId',
        'gradeId' => 'gradeId',
        'name' => 'name',
        'periodId' => 'periodId',
        'role' => 'role',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->campusId) {
            $res['campusId'] = $this->campusId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->gradeId) {
            $res['gradeId'] = $this->gradeId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->periodId) {
            $res['periodId'] = $this->periodId;
        }
        if (null !== $this->role) {
            $res['role'] = $this->role;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
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
        if (isset($map['campusId'])) {
            $model->campusId = $map['campusId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['gradeId'])) {
            $model->gradeId = $map['gradeId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['periodId'])) {
            $model->periodId = $map['periodId'];
        }
        if (isset($map['role'])) {
            $model->role = $map['role'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
