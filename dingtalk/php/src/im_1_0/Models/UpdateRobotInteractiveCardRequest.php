<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\UpdateRobotInteractiveCardRequest\updateOptions;
use AlibabaCloud\Tea\Model;

class UpdateRobotInteractiveCardRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example cardXXXX01
     *
     * @var string
     */
    public $cardBizId;

    /**
     * @example 根据具体的cardTemplateId参考文档格式
     *
     * @var string
     */
    public $cardData;

    /**
     * @var string
     */
    public $unionIdPrivateDataMap;

    /**
     * @var updateOptions
     */
    public $updateOptions;

    /**
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
