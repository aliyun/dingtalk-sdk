<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody\paragraphList\sentenceList;

use AlibabaCloud\Tea\Model;

class wordList extends Model
{
    /**
     * @example 7940
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 7940
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 这里
     *
     * @var string
     */
    public $word;

    /**
     * @example 1631172050535000#0
     *
     * @var string
     */
    public $wordId;
    protected $_name = [
        'endTime' => 'endTime',
        'startTime' => 'startTime',
        'word' => 'word',
        'wordId' => 'wordId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->word) {
            $res['word'] = $this->word;
        }
        if (null !== $this->wordId) {
            $res['wordId'] = $this->wordId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return wordList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['word'])) {
            $model->word = $map['word'];
        }
        if (isset($map['wordId'])) {
            $model->wordId = $map['wordId'];
        }

        return $model;
    }
}
