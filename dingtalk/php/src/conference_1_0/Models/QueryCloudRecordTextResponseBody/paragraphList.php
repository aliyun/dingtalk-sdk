<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\QueryCloudRecordTextResponseBody\paragraphList\sentenceList;
use AlibabaCloud\Tea\Model;

class paragraphList extends Model
{
    /**
     * @example 7940
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 1631172045153000
     *
     * @var int
     */
    public $nextTtoken;

    /**
     * @example 小钉
     *
     * @var string
     */
    public $nickName;

    /**
     * @example 嘿！你好，这里是小钉
     *
     * @var string
     */
    public $paragraph;

    /**
     * @example 44444
     *
     * @var int
     */
    public $recordId;

    /**
     * @var sentenceList[]
     */
    public $sentenceList;

    /**
     * @example 7940
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 1
     *
     * @var int
     */
    public $status;

    /**
     * @example WFBkgJvt0xxxxSaA1jK4sgiEiE
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'endTime'      => 'endTime',
        'nextTtoken'   => 'nextTtoken',
        'nickName'     => 'nickName',
        'paragraph'    => 'paragraph',
        'recordId'     => 'recordId',
        'sentenceList' => 'sentenceList',
        'startTime'    => 'startTime',
        'status'       => 'status',
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
        if (null !== $this->nextTtoken) {
            $res['nextTtoken'] = $this->nextTtoken;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = $this->paragraph;
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
        if (null !== $this->status) {
            $res['status'] = $this->status;
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
        if (isset($map['nextTtoken'])) {
            $model->nextTtoken = $map['nextTtoken'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = $map['paragraph'];
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
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
