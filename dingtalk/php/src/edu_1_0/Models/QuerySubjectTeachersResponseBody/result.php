<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySubjectTeachersResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $teacherName;

    /**
     * @var string
     */
    public $subjectName;

    /**
     * @var string
     */
    public $subjectCode;

    /**
     * @var string
     */
    public $periodCode;

    /**
     * @var int
     */
    public $orgId;

    /**
     * @var int
     */
    public $teacherUid;

    /**
     * @var int
     */
    public $classId;
    protected $_name = [
        'teacherName' => 'teacherName',
        'subjectName' => 'subjectName',
        'subjectCode' => 'subjectCode',
        'periodCode'  => 'periodCode',
        'orgId'       => 'orgId',
        'teacherUid'  => 'teacherUid',
        'classId'     => 'classId',
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
        if (null !== $this->orgId) {
            $res['orgId'] = $this->orgId;
        }
        if (null !== $this->teacherUid) {
            $res['teacherUid'] = $this->teacherUid;
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
        if (isset($map['orgId'])) {
            $model->orgId = $map['orgId'];
        }
        if (isset($map['teacherUid'])) {
            $model->teacherUid = $map['teacherUid'];
        }
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }

        return $model;
    }
}
