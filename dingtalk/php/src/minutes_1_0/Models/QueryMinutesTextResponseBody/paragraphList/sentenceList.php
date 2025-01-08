<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody\paragraphList;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody\paragraphList\sentenceList\wordList;
use AlibabaCloud\Tea\Model;

class sentenceList extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $sentence;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var wordList[]
     */
    public $wordList;
    protected $_name = [
        'endTime'   => 'endTime',
        'sentence'  => 'sentence',
        'startTime' => 'startTime',
        'wordList'  => 'wordList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->sentence) {
            $res['sentence'] = $this->sentence;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->wordList) {
            $res['wordList'] = [];
            if (null !== $this->wordList && \is_array($this->wordList)) {
                $n = 0;
                foreach ($this->wordList as $item) {
                    $res['wordList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sentenceList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['sentence'])) {
            $model->sentence = $map['sentence'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['wordList'])) {
            if (!empty($map['wordList'])) {
                $model->wordList = [];
                $n               = 0;
                foreach ($map['wordList'] as $item) {
                    $model->wordList[$n++] = null !== $item ? wordList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
