<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models\UpdateCardRequest\cardUpdateOptions;
use AlibabaCloud\Tea\Model;

class UpdateCardRequest extends Model
{
    /**
     * @description 卡片数据
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片更新选项
     *
     * @var cardUpdateOptions
     */
    public $cardUpdateOptions;

    /**
     * @description 【必填】外部卡片实例Id
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 用户的私有数据。
     * ● value：用户私有数据（cardData）
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'cardData'          => 'cardData',
        'cardUpdateOptions' => 'cardUpdateOptions',
        'outTrackId'        => 'outTrackId',
        'privateData'       => 'privateData',
        'userIdType'        => 'userIdType',
    ];

    public function validate()
    {
    }

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
     * @return UpdateCardRequest
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
