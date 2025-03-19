<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByShanhuiKeyResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vflashmeeting_1_0\Models\GetShanhuiByShanhuiKeyResponseBody\result\topics;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 1685332800000
     *
     * @var int
     */
    public $endTime;

    /**
     * @example 2kms47sjhb882
     *
     * @var string
     */
    public $eventId;

    /**
     * @example 8K4ny9P9No06sjhk
     *
     * @var string
     */
    public $flashmeetingKey;

    /**
     * @example false
     *
     * @var bool
     */
    public $hasSummary;

    /**
     * @example 1685318400000
     *
     * @var int
     */
    public $startTime;

    /**
     * @example 2Hj32Uio28fjmMiu9Klsk
     *
     * @var string
     */
    public $summaryDocKey;

    /**
     * @example 测试闪会
     *
     * @var string
     */
    public $title;

    /**
     * @var topics[]
     */
    public $topics;
    protected $_name = [
        'endTime' => 'endTime',
        'eventId' => 'eventId',
        'flashmeetingKey' => 'flashmeetingKey',
        'hasSummary' => 'hasSummary',
        'startTime' => 'startTime',
        'summaryDocKey' => 'summaryDocKey',
        'title' => 'title',
        'topics' => 'topics',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->flashmeetingKey) {
            $res['flashmeetingKey'] = $this->flashmeetingKey;
        }
        if (null !== $this->hasSummary) {
            $res['hasSummary'] = $this->hasSummary;
        }
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->summaryDocKey) {
            $res['summaryDocKey'] = $this->summaryDocKey;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->topics) {
            $res['topics'] = [];
            if (null !== $this->topics && \is_array($this->topics)) {
                $n = 0;
                foreach ($this->topics as $item) {
                    $res['topics'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['flashmeetingKey'])) {
            $model->flashmeetingKey = $map['flashmeetingKey'];
        }
        if (isset($map['hasSummary'])) {
            $model->hasSummary = $map['hasSummary'];
        }
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['summaryDocKey'])) {
            $model->summaryDocKey = $map['summaryDocKey'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['topics'])) {
            if (!empty($map['topics'])) {
                $model->topics = [];
                $n = 0;
                foreach ($map['topics'] as $item) {
                    $model->topics[$n++] = null !== $item ? topics::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
