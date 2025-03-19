<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryTeachSubjectsResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 333333
     *
     * @var int
     */
    public $classId;

    /**
     * @example dingding142523424
     *
     * @var string
     */
    public $corpId;

    /**
     * @example kindergarten
     *
     * @var string
     */
    public $periodCode;

    /**
     * @example cn_yuwen
     *
     * @var string
     */
    public $subjectCode;

    /**
     * @example 语文
     *
     * @var string
     */
    public $subjectName;

    /**
     * @example 李老师
     *
     * @var string
     */
    public $teacherName;

    /**
     * @example 50142345134
     *
     * @var string
     */
    public $teacherUserId;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'periodCode' => 'periodCode',
        'subjectCode' => 'subjectCode',
        'subjectName' => 'subjectName',
        'teacherName' => 'teacherName',
        'teacherUserId' => 'teacherUserId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->periodCode) {
            $res['periodCode'] = $this->periodCode;
        }
        if (null !== $this->subjectCode) {
            $res['subjectCode'] = $this->subjectCode;
        }
        if (null !== $this->subjectName) {
            $res['subjectName'] = $this->subjectName;
        }
        if (null !== $this->teacherName) {
            $res['teacherName'] = $this->teacherName;
        }
        if (null !== $this->teacherUserId) {
            $res['teacherUserId'] = $this->teacherUserId;
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
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['periodCode'])) {
            $model->periodCode = $map['periodCode'];
        }
        if (isset($map['subjectCode'])) {
            $model->subjectCode = $map['subjectCode'];
        }
        if (isset($map['subjectName'])) {
            $model->subjectName = $map['subjectName'];
        }
        if (isset($map['teacherName'])) {
            $model->teacherName = $map['teacherName'];
        }
        if (isset($map['teacherUserId'])) {
            $model->teacherUserId = $map['teacherUserId'];
        }

        return $model;
    }
}
