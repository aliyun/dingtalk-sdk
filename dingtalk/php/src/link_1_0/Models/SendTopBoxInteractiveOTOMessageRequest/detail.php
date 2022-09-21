<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\DetailUserIdPrivateDataMapValue;
use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\SendTopBoxInteractiveOTOMessageRequest\detail\cardData;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @description 卡片回调 URL 地址，不填则无回调
     *
     * @var string
     */
    public $callbackUrl;

    /**
     * @description 唯一标识一张卡片的ID，卡片幂等ID
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description 卡片数据
     *
     * @var cardData
     */
    public $cardData;

    /**
     * @description 卡片模板 ID
     *
     * @var string
     */
    public $cardTemplateId;

    /**
     * @description 失效时间，时间戳（毫秒），最长时间不超过 90 天
     *
     * @var int
     */
    public $expiredTime;

    /**
     * @description 接收人 userId
     *
     * @var string
     */
    public $userId;

    /**
     * @description 卡片用户差异化数据
     *
     * @var DetailUserIdPrivateDataMapValue[]
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'callbackUrl'          => 'callbackUrl',
        'cardBizId'            => 'cardBizId',
        'cardData'             => 'cardData',
        'cardTemplateId'       => 'cardTemplateId',
        'expiredTime'          => 'expiredTime',
        'userId'               => 'userId',
        'userIdPrivateDataMap' => 'userIdPrivateDataMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->callbackUrl) {
            $res['callbackUrl'] = $this->callbackUrl;
        }
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = null !== $this->cardData ? $this->cardData->toMap() : null;
        }
        if (null !== $this->cardTemplateId) {
            $res['cardTemplateId'] = $this->cardTemplateId;
        }
        if (null !== $this->expiredTime) {
            $res['expiredTime'] = $this->expiredTime;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userIdPrivateDataMap) {
            $res['userIdPrivateDataMap'] = [];
            if (null !== $this->userIdPrivateDataMap && \is_array($this->userIdPrivateDataMap)) {
                foreach ($this->userIdPrivateDataMap as $key => $val) {
                    $res['userIdPrivateDataMap'][$key] = null !== $val ? $val->toMap() : $val;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return detail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['callbackUrl'])) {
            $model->callbackUrl = $map['callbackUrl'];
        }
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = cardData::fromMap($map['cardData']);
        }
        if (isset($map['cardTemplateId'])) {
            $model->cardTemplateId = $map['cardTemplateId'];
        }
        if (isset($map['expiredTime'])) {
            $model->expiredTime = $map['expiredTime'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
