<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdiot_1_0\Models\QueryEventResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $eventId;

    /**
     * @var string
     */
    public $eventName;

    /**
     * @var int
     */
    public $eventStatus;

    /**
     * @var string
     */
    public $eventType;

    /**
     * @var string
     */
    public $msg;

    /**
     * @var int
     */
    public $occurrenceTime;

    /**
     * @var string[]
     */
    public $picUrls;
    protected $_name = [
        'eventId'        => 'eventId',
        'eventName'      => 'eventName',
        'eventStatus'    => 'eventStatus',
        'eventType'      => 'eventType',
        'msg'            => 'msg',
        'occurrenceTime' => 'occurrenceTime',
        'picUrls'        => 'picUrls',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventId) {
            $res['eventId'] = $this->eventId;
        }
        if (null !== $this->eventName) {
            $res['eventName'] = $this->eventName;
        }
        if (null !== $this->eventStatus) {
            $res['eventStatus'] = $this->eventStatus;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->msg) {
            $res['msg'] = $this->msg;
        }
        if (null !== $this->occurrenceTime) {
            $res['occurrenceTime'] = $this->occurrenceTime;
        }
        if (null !== $this->picUrls) {
            $res['picUrls'] = $this->picUrls;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventId'])) {
            $model->eventId = $map['eventId'];
        }
        if (isset($map['eventName'])) {
            $model->eventName = $map['eventName'];
        }
        if (isset($map['eventStatus'])) {
            $model->eventStatus = $map['eventStatus'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['msg'])) {
            $model->msg = $map['msg'];
        }
        if (isset($map['occurrenceTime'])) {
            $model->occurrenceTime = $map['occurrenceTime'];
        }
        if (isset($map['picUrls'])) {
            if (!empty($map['picUrls'])) {
                $model->picUrls = $map['picUrls'];
            }
        }

        return $model;
    }
}
