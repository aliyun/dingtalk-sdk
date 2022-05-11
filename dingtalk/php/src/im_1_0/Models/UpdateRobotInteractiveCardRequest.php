<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInteractiveCardRequest\updateOptions;
use AlibabaCloud\Tea\Model;

class UpdateRobotInteractiveCardRequest extends Model
{
    /**
     * @description 唯一标识一张卡片的外部ID（卡片幂等ID，可用于更新或重复发送同一卡片到多个群会话）【备注：同一个outTrackId重复创建，卡片数据不覆盖更新】
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @description 卡片模板-文本内容参数（卡片json结构体）
     *
     * @var string
     */
    public $cardData;

    /**
     * @description 卡片模板-userId差异用户参数（json结构体）
     *
     * @var string
     */
    public $unionIdPrivateDataMap;

    /**
     * @description 互动卡片更新选项
     *
     * @var updateOptions
     */
    public $updateOptions;

    /**
     * @description 卡片模板-userId差异用户参数（json结构体）
     *
     * @var string
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'cardBizId'             => 'cardBizId',
        'cardData'              => 'cardData',
        'unionIdPrivateDataMap' => 'unionIdPrivateDataMap',
        'updateOptions'         => 'updateOptions',
        'userIdPrivateDataMap'  => 'userIdPrivateDataMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->cardBizId) {
            $res['cardBizId'] = $this->cardBizId;
        }
        if (null !== $this->cardData) {
            $res['cardData'] = $this->cardData;
        }
        if (null !== $this->unionIdPrivateDataMap) {
            $res['unionIdPrivateDataMap'] = $this->unionIdPrivateDataMap;
        }
        if (null !== $this->updateOptions) {
            $res['updateOptions'] = null !== $this->updateOptions ? $this->updateOptions->toMap() : null;
        }
        if (null !== $this->userIdPrivateDataMap) {
            $res['userIdPrivateDataMap'] = $this->userIdPrivateDataMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateRobotInteractiveCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['cardBizId'])) {
            $model->cardBizId = $map['cardBizId'];
        }
        if (isset($map['cardData'])) {
            $model->cardData = $map['cardData'];
        }
        if (isset($map['unionIdPrivateDataMap'])) {
            $model->unionIdPrivateDataMap = $map['unionIdPrivateDataMap'];
        }
        if (isset($map['updateOptions'])) {
            $model->updateOptions = updateOptions::fromMap($map['updateOptions']);
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
