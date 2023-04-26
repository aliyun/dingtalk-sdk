<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\DIgitalStoreMessagePushRequest;

use AlibabaCloud\Tea\Model;

class messageDataList extends Model
{
    /**
     * @example xxxxcallback
     *
     * @var string
     */
    public $callbackKey;

    /**
     * @example {"key":"value"}
     *
     * @var string
     */
    public $content;

    /**
     * @example true
     *
     * @var bool
     */
    public $newCard;

    /**
     * @example ysn138dh1712dsa
     *
     * @var string
     */
    public $outTraceId;

    /**
     * @example StoreOrder
     *
     * @var string
     */
    public $sceneCardCode;

    /**
     * @example 54774321
     *
     * @var int
     */
    public $sceneScope;

    /**
     * @example true
     *
     * @var bool
     */
    public $sendNow;
    protected $_name = [
        'callbackKey'   => 'callbackKey',
        'content'       => 'content',
        'newCard'       => 'newCard',
        'outTraceId'    => 'outTraceId',
        'sceneCardCode' => 'sceneCardCode',
        'sceneScope'    => 'sceneScope',
        'sendNow'       => 'sendNow',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackKey) {
            $res['callbackKey'] = $this->callbackKey;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->newCard) {
            $res['newCard'] = $this->newCard;
        }
        if (null !== $this->outTraceId) {
            $res['outTraceId'] = $this->outTraceId;
        }
        if (null !== $this->sceneCardCode) {
            $res['sceneCardCode'] = $this->sceneCardCode;
        }
        if (null !== $this->sceneScope) {
            $res['sceneScope'] = $this->sceneScope;
        }
        if (null !== $this->sendNow) {
            $res['sendNow'] = $this->sendNow;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return messageDataList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackKey'])) {
            $model->callbackKey = $map['callbackKey'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['newCard'])) {
            $model->newCard = $map['newCard'];
        }
        if (isset($map['outTraceId'])) {
            $model->outTraceId = $map['outTraceId'];
        }
        if (isset($map['sceneCardCode'])) {
            $model->sceneCardCode = $map['sceneCardCode'];
        }
        if (isset($map['sceneScope'])) {
            $model->sceneScope = $map['sceneScope'];
        }
        if (isset($map['sendNow'])) {
            $model->sendNow = $map['sendNow'];
        }

        return $model;
    }
}
