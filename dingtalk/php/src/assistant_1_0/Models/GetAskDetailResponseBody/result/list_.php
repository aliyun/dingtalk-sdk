<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAskDetailResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetAskDetailResponseBody\result\list_\references;
use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var string
     */
    public $answer;

    /**
     * @var string
     */
    public $answerResult;

    /**
     * @var string[]
     */
    public $commentTags;

    /**
     * @var bool
     */
    public $isMarkResolved;

    /**
     * @var string
     */
    public $nick;

    /**
     * @var string
     */
    public $question;

    /**
     * @var references[]
     */
    public $references;

    /**
     * @var int
     */
    public $time;
    protected $_name = [
        'answer'         => 'answer',
        'answerResult'   => 'answerResult',
        'commentTags'    => 'commentTags',
        'isMarkResolved' => 'isMarkResolved',
        'nick'           => 'nick',
        'question'       => 'question',
        'references'     => 'references',
        'time'           => 'time',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->answer) {
            $res['answer'] = $this->answer;
        }
        if (null !== $this->answerResult) {
            $res['answerResult'] = $this->answerResult;
        }
        if (null !== $this->commentTags) {
            $res['commentTags'] = $this->commentTags;
        }
        if (null !== $this->isMarkResolved) {
            $res['isMarkResolved'] = $this->isMarkResolved;
        }
        if (null !== $this->nick) {
            $res['nick'] = $this->nick;
        }
        if (null !== $this->question) {
            $res['question'] = $this->question;
        }
        if (null !== $this->references) {
            $res['references'] = [];
            if (null !== $this->references && \is_array($this->references)) {
                $n = 0;
                foreach ($this->references as $item) {
                    $res['references'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->time) {
            $res['time'] = $this->time;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['answer'])) {
            $model->answer = $map['answer'];
        }
        if (isset($map['answerResult'])) {
            $model->answerResult = $map['answerResult'];
        }
        if (isset($map['commentTags'])) {
            if (!empty($map['commentTags'])) {
                $model->commentTags = $map['commentTags'];
            }
        }
        if (isset($map['isMarkResolved'])) {
            $model->isMarkResolved = $map['isMarkResolved'];
        }
        if (isset($map['nick'])) {
            $model->nick = $map['nick'];
        }
        if (isset($map['question'])) {
            $model->question = $map['question'];
        }
        if (isset($map['references'])) {
            if (!empty($map['references'])) {
                $model->references = [];
                $n                 = 0;
                foreach ($map['references'] as $item) {
                    $model->references[$n++] = null !== $item ? references::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['time'])) {
            $model->time = $map['time'];
        }

        return $model;
    }
}
