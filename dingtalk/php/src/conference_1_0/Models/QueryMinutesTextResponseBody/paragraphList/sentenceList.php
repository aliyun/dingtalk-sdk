<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesTextResponseBody\paragraphList;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesTextResponseBody\paragraphList\sentenceList\wordList;
use AlibabaCloud\Tea\Model;

class sentenceList extends Model
{
    /**
     * @example 7940
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 这里是小钉
     *
     * @var string
     */
    public $sentence;

    /**
     * @example 7940
     *
     * @var int
     */
    public $startTime;

    /**
     * @example WFBkgJvt0xxxxSaA1jK4sgiEiE
     *
     * @var string
     */
    public $unionId;

    /**
     * @var wordList[]
     */
    public $wordList;
    protected $_name = [
        'endTime' => 'endTime',
        'sentence' => 'sentence',
        'startTime' => 'startTime',
        'unionId' => 'unionId',
        'wordList' => 'wordList',
    ];

    public function validate() {}

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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['wordList'])) {
            if (!empty($map['wordList'])) {
                $model->wordList = [];
                $n = 0;
                foreach ($map['wordList'] as $item) {
                    $model->wordList[$n++] = null !== $item ? wordList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
