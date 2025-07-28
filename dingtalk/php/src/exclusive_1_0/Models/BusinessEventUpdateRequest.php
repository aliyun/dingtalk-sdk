<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class BusinessEventUpdateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var mixed[]
     */
    public $businessData;

    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $eventType;

    /**
     * @description This parameter is required.
     *
     * @example cidxxx
     *
     * @var string
     */
    public $openConversationId;

    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $updateByKey;
    protected $_name = [
        'businessData' => 'businessData',
        'eventType' => 'eventType',
        'openConversationId' => 'openConversationId',
        'updateByKey' => 'updateByKey',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessData) {
            $res['businessData'] = $this->businessData;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->openConversationId) {
            $res['openConversationId'] = $this->openConversationId;
        }
        if (null !== $this->updateByKey) {
            $res['updateByKey'] = $this->updateByKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BusinessEventUpdateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessData'])) {
            $model->businessData = $map['businessData'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['openConversationId'])) {
            $model->openConversationId = $map['openConversationId'];
        }
        if (isset($map['updateByKey'])) {
            $model->updateByKey = $map['updateByKey'];
        }

        return $model;
    }
}
