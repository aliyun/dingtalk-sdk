<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class CollegeAddStudentResponseBody extends Model
{
    /**
     * @description 人员状态
     *
     * @var string
     */
    public $dingMemberStatus;

    /**
     * @description 账号是否激活
     *
     * @var bool
     */
    public $isActive;

    /**
     * @description 学生id
     *
     * @var int
     */
    public $studentId;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @description userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'dingMemberStatus' => 'dingMemberStatus',
        'isActive'         => 'isActive',
        'studentId'        => 'studentId',
        'unionId'          => 'unionId',
        'userId'           => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingMemberStatus) {
            $res['dingMemberStatus'] = $this->dingMemberStatus;
        }
        if (null !== $this->isActive) {
            $res['isActive'] = $this->isActive;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
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
     * @return CollegeAddStudentResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingMemberStatus'])) {
            $model->dingMemberStatus = $map['dingMemberStatus'];
        }
        if (isset($map['isActive'])) {
            $model->isActive = $map['isActive'];
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
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
