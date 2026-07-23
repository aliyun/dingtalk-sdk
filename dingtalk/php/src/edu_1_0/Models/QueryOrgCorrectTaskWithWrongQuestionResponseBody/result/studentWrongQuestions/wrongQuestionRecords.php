<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QueryOrgCorrectTaskWithWrongQuestionResponseBody\result\studentWrongQuestions;

use AlibabaCloud\Tea\Model;

class wrongQuestionRecords extends Model
{
    /**
     * @var string
     */
    public $questionCutUrl;

    /**
     * @var string
     */
    public $questionId;
    protected $_name = [
        'questionCutUrl' => 'questionCutUrl',
        'questionId' => 'questionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->questionCutUrl) {
            $res['questionCutUrl'] = $this->questionCutUrl;
        }
        if (null !== $this->questionId) {
            $res['questionId'] = $this->questionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return wrongQuestionRecords
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['questionCutUrl'])) {
            $model->questionCutUrl = $map['questionCutUrl'];
        }
        if (isset($map['questionId'])) {
            $model->questionId = $map['questionId'];
        }

        return $model;
    }
}
