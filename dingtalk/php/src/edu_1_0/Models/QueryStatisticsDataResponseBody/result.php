<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryStatisticsDataResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 2345
     *
     * @var int
     */
    public $classId;

    /**
     * @example 6
     *
     * @var int
     */
    public $courseCount;

    /**
     * @example 9
     *
     * @var float
     */
    public $courseHours;

    /**
     * @example cn_shuxue
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @example 语文
     *
     * @var int
     */
    public $subjectName;

    /**
     * @example 2352345345
     *
     * @var string
     */
    public $userId;

    /**
     * @example 李老师
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'classId' => 'classId',
        'courseCount' => 'courseCount',
        'courseHours' => 'courseHours',
        'subjectCode' => 'subjectCode',
        'subjectName' => 'subjectName',
        'userId' => 'userId',
        'userName' => 'userName',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->courseCount) {
            $res['courseCount'] = $this->courseCount;
        }
        if (null !== $this->courseHours) {
            $res['courseHours'] = $this->courseHours;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
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
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['courseCount'])) {
            $model->courseCount = $map['courseCount'];
        }
        if (isset($map['courseHours'])) {
            $model->courseHours = $map['courseHours'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}
