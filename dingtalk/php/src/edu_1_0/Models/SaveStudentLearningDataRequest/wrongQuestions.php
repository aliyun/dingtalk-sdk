<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\SaveStudentLearningDataRequest;

use AlibabaCloud\Tea\Model;

class wrongQuestions extends Model
{
    /**
     * @var string[]
     */
    public $knowledgePoints;

    /**
     * @example 1
     *
     * @var string
     */
    public $questionNo;

    /**
     * @example 1
     *
     * @var int
     */
    public $questionPictureNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $standardAnswerPictureNum;

    /**
     * @example 1
     *
     * @var int
     */
    public $userAnswerPictureNum;
    protected $_name = [
        'knowledgePoints' => 'knowledgePoints',
        'questionNo' => 'questionNo',
        'questionPictureNum' => 'questionPictureNum',
        'standardAnswerPictureNum' => 'standardAnswerPictureNum',
        'userAnswerPictureNum' => 'userAnswerPictureNum',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->knowledgePoints) {
            $res['knowledgePoints'] = $this->knowledgePoints;
        }
        if (null !== $this->questionNo) {
            $res['questionNo'] = $this->questionNo;
        }
        if (null !== $this->questionPictureNum) {
            $res['questionPictureNum'] = $this->questionPictureNum;
        }
        if (null !== $this->standardAnswerPictureNum) {
            $res['standardAnswerPictureNum'] = $this->standardAnswerPictureNum;
        }
        if (null !== $this->userAnswerPictureNum) {
            $res['userAnswerPictureNum'] = $this->userAnswerPictureNum;
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
        if (isset($map['knowledgePoints'])) {
            if (!empty($map['knowledgePoints'])) {
                $model->knowledgePoints = $map['knowledgePoints'];
            }
        }
        if (isset($map['questionNo'])) {
            $model->questionNo = $map['questionNo'];
        }
        if (isset($map['questionPictureNum'])) {
            $model->questionPictureNum = $map['questionPictureNum'];
        }
        if (isset($map['standardAnswerPictureNum'])) {
            $model->standardAnswerPictureNum = $map['standardAnswerPictureNum'];
        }
        if (isset($map['userAnswerPictureNum'])) {
            $model->userAnswerPictureNum = $map['userAnswerPictureNum'];
        }

        return $model;
    }
}
