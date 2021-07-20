<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $userName;

    /**
     * @var int
     */
    public $classId;

    /**
     * @var int
     */
    public $subjectName;

    /**
     * @var float
     */
    public $courseHours;

    /**
     * @var int
     */
    public $courseCount;
    protected $_name = [
        'userId'      => 'userId',
        'userName'    => 'userName',
        'classId'     => 'classId',
        'subjectName' => 'subjectName',
        'courseHours' => 'courseHours',
        'courseCount' => 'courseCount',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->courseHours) {
            $res['courseHours'] = $this->courseHours;
        }
        if (null !== $this->courseCount) {
            $res['courseCount'] = $this->courseCount;
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
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['courseHours'])) {
            $model->courseHours = $map['courseHours'];
        }
        if (isset($map['courseCount'])) {
            $model->courseCount = $map['courseCount'];
        }

        return $model;
    }
}
