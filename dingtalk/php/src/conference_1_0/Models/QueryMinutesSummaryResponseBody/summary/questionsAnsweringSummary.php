<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary;

use AlibabaCloud\Tea\Model;

class questionsAnsweringSummary extends Model
{
    /**
     * @var string
     */
    public $answer;

    /**
     * @var string
     */
    public $question;

    /**
     * @var int[]
     */
    public $sentenceIdsOfAnswer;

    /**
     * @var int[]
     */
    public $sentenceIdsOfQuestion;
    protected $_name = [
        'answer' => 'answer',
        'question' => 'question',
        'sentenceIdsOfAnswer' => 'sentenceIdsOfAnswer',
        'sentenceIdsOfQuestion' => 'sentenceIdsOfQuestion',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->answer) {
            $res['answer'] = $this->answer;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->sentenceIdsOfAnswer) {
            $res['sentenceIdsOfAnswer'] = $this->sentenceIdsOfAnswer;
        }
        if (null !== $this->sentenceIdsOfQuestion) {
            $res['sentenceIdsOfQuestion'] = $this->sentenceIdsOfQuestion;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return questionsAnsweringSummary
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['answer'])) {
            $model->answer = $map['answer'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['sentenceIdsOfAnswer'])) {
            if (!empty($map['sentenceIdsOfAnswer'])) {
                $model->sentenceIdsOfAnswer = $map['sentenceIdsOfAnswer'];
            }
        }
        if (isset($map['sentenceIdsOfQuestion'])) {
            if (!empty($map['sentenceIdsOfQuestion'])) {
                $model->sentenceIdsOfQuestion = $map['sentenceIdsOfQuestion'];
            }
        }

        return $model;
    }
}
