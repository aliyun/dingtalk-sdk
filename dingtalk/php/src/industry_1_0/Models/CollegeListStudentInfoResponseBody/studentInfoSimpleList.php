<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\CollegeListStudentInfoResponseBody;

use AlibabaCloud\Tea\Model;

class studentInfoSimpleList extends Model
{
    /**
     * @description 学生id
     *
     * @var int
     */
    public $studentId;

    /**
     * @description 学生姓名
     *
     * @var string
     */
    public $studentName;

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
        'studentId'   => 'studentId',
        'studentName' => 'studentName',
        'unionId'     => 'unionId',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
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
     * @return studentInfoSimpleList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
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
