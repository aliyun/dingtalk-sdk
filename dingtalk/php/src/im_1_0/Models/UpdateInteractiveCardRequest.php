<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardRequest\cardData;
use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateInteractiveCardRequest\cardOptions;
use AlibabaCloud\Tea\Model;

class UpdateInteractiveCardRequest extends Model
{
    /**
     * @description 卡片公共主体部分数据
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 发送可交互卡片的一些功能选项
     *
     * @var cardOptions
     */
    public $cardOptions;

    /**
     * @description 唯一标识一张卡片的外部ID
     *
     * @var string
     */
    public $outTrackId;

    /**
     * @description 卡片用户私有差异部分数据（如卡片不同人显示不同按钮；key：用户userId；value：用户数据变量）
     *
     * @var PrivateDataValue[]
     */
    public $privateData;

    /**
     * @description 用户ID类型：1：userId模式【默认】；2：unionId模式；对应receiverUserIdList、privateData字段关于用户id的值填写方式
     *
     * @var int
     */
    public $userIdType;
    protected $_name = [
        'cardData'    => 'cardData',
        'cardOptions' => 'cardOptions',
        'outTrackId'  => 'outTrackId',
        'privateData' => 'privateData',
        'userIdType'  => 'userIdType',
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
        if (null !== $this->cardOptions) {
            $res['cardOptions'] = null !== $this->cardOptions ? $this->cardOptions->toMap() : null;
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
     * @return UpdateInteractiveCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardOptions'])) {
            $model->cardOptions = cardOptions::fromMap($map['cardOptions']);
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
