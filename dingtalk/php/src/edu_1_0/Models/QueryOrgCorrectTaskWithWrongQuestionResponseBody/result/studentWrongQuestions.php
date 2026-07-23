<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskWithWrongQuestionResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskWithWrongQuestionResponseBody\result\studentWrongQuestions\wrongQuestionRecords;
use AlibabaCloud\Tea\Model;

class studentWrongQuestions extends Model
{
    /**
     * @var string[]
     */
    public $assignmentPicUrlList;

    /**
     * @var string
     */
    public $studentId;

    /**
     * @var string
     */
    public $studentName;

    /**
     * @var wrongQuestionRecords[]
     */
    public $wrongQuestionRecords;
    protected $_name = [
        'assignmentPicUrlList' => 'assignmentPicUrlList',
        'studentId' => 'studentId',
        'studentName' => 'studentName',
        'wrongQuestionRecords' => 'wrongQuestionRecords',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->assignmentPicUrlList) {
            $res['assignmentPicUrlList'] = $this->assignmentPicUrlList;
        }
        if (null !== $this->studentId) {
            $res['studentId'] = $this->studentId;
        }
        if (null !== $this->studentName) {
            $res['studentName'] = $this->studentName;
        }
        if (null !== $this->wrongQuestionRecords) {
            $res['wrongQuestionRecords'] = [];
            if (null !== $this->wrongQuestionRecords && \is_array($this->wrongQuestionRecords)) {
                $n = 0;
                foreach ($this->wrongQuestionRecords as $item) {
                    $res['wrongQuestionRecords'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return studentWrongQuestions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['assignmentPicUrlList'])) {
            if (!empty($map['assignmentPicUrlList'])) {
                $model->assignmentPicUrlList = $map['assignmentPicUrlList'];
            }
        }
        if (isset($map['studentId'])) {
            $model->studentId = $map['studentId'];
        }
        if (isset($map['studentName'])) {
            $model->studentName = $map['studentName'];
        }
        if (isset($map['wrongQuestionRecords'])) {
            if (!empty($map['wrongQuestionRecords'])) {
                $model->wrongQuestionRecords = [];
                $n = 0;
                foreach ($map['wrongQuestionRecords'] as $item) {
                    $model->wrongQuestionRecords[$n++] = null !== $item ? wrongQuestionRecords::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
