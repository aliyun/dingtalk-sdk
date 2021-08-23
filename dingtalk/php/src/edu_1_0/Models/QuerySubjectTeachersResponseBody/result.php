<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 老师名称
     *
     * @var string
     */
    public $teacherName;

    /**
     * @description 学科名称
     *
     * @var string
     */
    public $subjectName;

    /**
     * @description 学科code
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @description 学段code
     *
     * @var string
     */
    public $periodCode;

    /**
     * @description 学校corpId
     *
     * @var string
     */
    public $corpId;

    /**
     * @description 老师Userid
     *
     * @var string
     */
    public $teacherUserId;

    /**
     * @description 班级id
     *
     * @var int
     */
    public $classId;
    protected $_name = [
        'teacherName'   => 'teacherName',
        'subjectName'   => 'subjectName',
        'subjectCode'   => 'subjectCode',
        'periodCode'    => 'periodCode',
        'corpId'        => 'corpId',
        'teacherUserId' => 'teacherUserId',
        'classId'       => 'classId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
        }
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
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
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }

        return $model;
    }
}
