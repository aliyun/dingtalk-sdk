<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class IsvCardEventPushRequest extends Model
{
    /**
     * @description ISV用户iD
     *
     * @var string
     */
    public $isvUid;

    /**
     * @description ISV名片ID
     *
     * @var string
     */
    public $isvCardId;

    /**
     * @description ISV用户TOKEN
     *
     * @var string
     */
    public $isvToken;

    /**
     * @description 事件类型
     *
     * @var string
     */
    public $eventType;

    /**
     * @description 事件参数
     *
     * @var mixed[]
     */
    public $eventParams;
    protected $_name = [
        'isvUid'      => 'isvUid',
        'isvCardId'   => 'isvCardId',
        'isvToken'    => 'isvToken',
        'eventType'   => 'eventType',
        'eventParams' => 'eventParams',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->isvUid) {
            $res['isvUid'] = $this->isvUid;
        }
        if (null !== $this->isvCardId) {
            $res['isvCardId'] = $this->isvCardId;
        }
        if (null !== $this->isvToken) {
            $res['isvToken'] = $this->isvToken;
        }
        if (null !== $this->eventType) {
            $res['eventType'] = $this->eventType;
        }
        if (null !== $this->eventParams) {
            $res['eventParams'] = $this->eventParams;
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
        if (isset($map['isvUid'])) {
            $model->isvUid = $map['isvUid'];
        }
        if (isset($map['isvCardId'])) {
            $model->isvCardId = $map['isvCardId'];
        }
        if (isset($map['isvToken'])) {
            $model->isvToken = $map['isvToken'];
        }
        if (isset($map['eventType'])) {
            $model->eventType = $map['eventType'];
        }
        if (isset($map['eventParams'])) {
            $model->eventParams = $map['eventParams'];
        }

        return $model;
    }
}
