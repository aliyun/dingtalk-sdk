<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsvCardEventPushRequest extends Model
{
    /**
     * @var mixed[]
     */
    public $eventParams;

    /**
     * @var string
     */
    public $eventType;

    /**
     * @var string
     */
    public $isvCardId;

    /**
     * @var string
     */
    public $isvToken;

    /**
     * @var string
     */
    public $isvUid;
    protected $_name = [
        'eventParams' => 'eventParams',
        'eventType'   => 'eventType',
        'isvCardId'   => 'isvCardId',
        'isvToken'    => 'isvToken',
        'isvUid'      => 'isvUid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->eventParams) {
            $res['eventParams'] = $this->eventParams;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->isvCardId) {
            $res['isvCardId'] = $this->isvCardId;
        }
        if (null !== $this->isvToken) {
            $res['isvToken'] = $this->isvToken;
        }
        if (null !== $this->isvUid) {
            $res['isvUid'] = $this->isvUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return IsvCardEventPushRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['eventParams'])) {
            $model->eventParams = $map['eventParams'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['isvCardId'])) {
            $model->isvCardId = $map['isvCardId'];
        }
        if (isset($map['isvToken'])) {
            $model->isvToken = $map['isvToken'];
        }
        if (isset($map['isvUid'])) {
            $model->isvUid = $map['isvUid'];
        }

        return $model;
    }
}
