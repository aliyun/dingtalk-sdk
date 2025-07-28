<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardWithDelegateRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardWithDelegateRequest\cardUpdateOptions;
use AlibabaCloud\Tea\Model;

class UpdateCardWithDelegateRequest extends Model
{
    /**
     * @var cardData
     */
    public $cardData;

    /**
     * @var cardUpdateOptions
     */
    public $cardUpdateOptions;

    /**
     * @description This parameter is required.
     *
     * @example 123
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'cardData' => 'cardData',
        'cardUpdateOptions' => 'cardUpdateOptions',
        'outTrackId' => 'outTrackId',
        'privateData' => 'privateData',
        'userIdType' => 'userIdType',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->cardUpdateOptions) {
            $res['cardUpdateOptions'] = null !== $this->cardUpdateOptions ? $this->cardUpdateOptions->toMap() : null;
        }
        if (null !== $this->outTrackId) {
            $res['outTrackId'] = $this->outTrackId;
        }
        if (null !== $this->privateData) {
            $res['privateData'] = [];
            if (null !== $this->privateData && \is_array($this->privateData)) {
                foreach ($this->privateData as $key => $val) {
                    $res['privateData'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }
        if (null !== $this->userIdType) {
            $res['userIdType'] = $this->userIdType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateCardWithDelegateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardUpdateOptions'])) {
            $model->cardUpdateOptions = cardUpdateOptions::fromMap($map['cardUpdateOptions']);
        }
        if (isset($map['outTrackId'])) {
            $model->outTrackId = $map['outTrackId'];
        }
        if (isset($map['privateData'])) {
            $model->privateData = $map['privateData'];
        }
        if (isset($map['userIdType'])) {
            $model->userIdType = $map['userIdType'];
        }

        return $model;
    }
}
