<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\QueryMinutesTextResponseBody\paragraphList\sentenceList;
use AlibabaCloud\Tea\Model;

class paragraphList extends Model
{
    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string
     */
    public $nickName;

    /**
     * @var string
     */
    public $paragraph;

    /**
     * @var int
     */
    public $paragraphId;

    /**
     * @var int
     */
    public $recordId;

    /**
     * @var sentenceList[]
     */
    public $sentenceList;

    /**
     * @var int
     */
    public $startTime;

    /**
     * @var string
     */
    public $unionId;
    protected $_name = [
        'endTime'      => 'endTime',
        'nickName'     => 'nickName',
        'paragraph'    => 'paragraph',
        'paragraphId'  => 'paragraphId',
        'recordId'     => 'recordId',
        'sentenceList' => 'sentenceList',
        'startTime'    => 'startTime',
        'unionId'      => 'unionId',
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
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = $this->paragraph;
        }
        if (null !== $this->paragraphId) {
            $res['paragraphId'] = $this->paragraphId;
        }
        if (null !== $this->recordId) {
            $res['recordId'] = $this->recordId;
        }
        if (null !== $this->sentenceList) {
            $res['sentenceList'] = [];
            if (null !== $this->sentenceList && \is_array($this->sentenceList)) {
                $n = 0;
                foreach ($this->sentenceList as $item) {
                    $res['sentenceList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return paragraphList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = $map['paragraph'];
        }
        if (isset($map['paragraphId'])) {
            $model->paragraphId = $map['paragraphId'];
        }
        if (isset($map['recordId'])) {
            $model->recordId = $map['recordId'];
        }
        if (isset($map['sentenceList'])) {
            if (!empty($map['sentenceList'])) {
                $model->sentenceList = [];
                $n                   = 0;
                foreach ($map['sentenceList'] as $item) {
                    $model->sentenceList[$n++] = null !== $item ? sentenceList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
