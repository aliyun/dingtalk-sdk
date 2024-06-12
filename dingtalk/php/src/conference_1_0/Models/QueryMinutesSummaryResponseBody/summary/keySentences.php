<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryMinutesSummaryResponseBody\summary;

use AlibabaCloud\Tea\Model;

class keySentences extends Model
{
    /**
     * @var int
     */
    public $end;

    /**
     * @var int
     */
    public $id;

    /**
     * @var int
     */
    public $sentenceId;

    /**
     * @var int
     */
    public $start;

    /**
     * @var string
     */
    public $text;
    protected $_name = [
        'end'        => 'end',
        'id'         => 'id',
        'sentenceId' => 'sentenceId',
        'start'      => 'start',
        'text'       => 'text',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->end) {
            $res['end'] = $this->end;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->sentenceId) {
            $res['sentenceId'] = $this->sentenceId;
        }
        if (null !== $this->start) {
            $res['start'] = $this->start;
        }
        if (null !== $this->text) {
            $res['text'] = $this->text;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return keySentences
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['end'])) {
            $model->end = $map['end'];
        }
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['sentenceId'])) {
            $model->sentenceId = $map['sentenceId'];
        }
        if (isset($map['start'])) {
            $model->start = $map['start'];
        }
        if (isset($map['text'])) {
            $model->text = $map['text'];
        }

        return $model;
    }
}
