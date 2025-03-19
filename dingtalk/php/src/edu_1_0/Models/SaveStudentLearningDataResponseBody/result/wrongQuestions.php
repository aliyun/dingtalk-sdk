<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataResponseBody\result;

use AlibabaCloud\Tea\Model;

class wrongQuestions extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $questionNo;

    /**
     * @var string[]
     */
    public $questionUploadUrlList;

    /**
     * @var string[]
     */
    public $standardAnswerUploadUrlList;

    /**
     * @var string[]
     */
    public $userAnswerUploadUrlList;
    protected $_name = [
        'questionNo' => 'questionNo',
        'questionUploadUrlList' => 'questionUploadUrlList',
        'standardAnswerUploadUrlList' => 'standardAnswerUploadUrlList',
        'userAnswerUploadUrlList' => 'userAnswerUploadUrlList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->questionNo) {
            $res['questionNo'] = $this->questionNo;
        }
        if (null !== $this->questionUploadUrlList) {
            $res['questionUploadUrlList'] = $this->questionUploadUrlList;
        }
        if (null !== $this->standardAnswerUploadUrlList) {
            $res['standardAnswerUploadUrlList'] = $this->standardAnswerUploadUrlList;
        }
        if (null !== $this->userAnswerUploadUrlList) {
            $res['userAnswerUploadUrlList'] = $this->userAnswerUploadUrlList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return wrongQuestions
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['questionNo'])) {
            $model->questionNo = $map['questionNo'];
        }
        if (isset($map['questionUploadUrlList'])) {
            if (!empty($map['questionUploadUrlList'])) {
                $model->questionUploadUrlList = $map['questionUploadUrlList'];
            }
        }
        if (isset($map['standardAnswerUploadUrlList'])) {
            if (!empty($map['standardAnswerUploadUrlList'])) {
                $model->standardAnswerUploadUrlList = $map['standardAnswerUploadUrlList'];
            }
        }
        if (isset($map['userAnswerUploadUrlList'])) {
            if (!empty($map['userAnswerUploadUrlList'])) {
                $model->userAnswerUploadUrlList = $map['userAnswerUploadUrlList'];
            }
        }

        return $model;
    }
}
