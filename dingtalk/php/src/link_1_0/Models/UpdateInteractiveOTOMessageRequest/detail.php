<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageRequest;

use AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models\UpdateInteractiveOTOMessageRequest\detail\updateOptions;
use AlibabaCloud\Tea\Model;

class detail extends Model
{
    /**
     * @var string
     */
    public $cardBizId;

    /**
     * @var string
     */
    public $cardData;

    /**
     * @var updateOptions
     */
    public $updateOptions;

    /**
     * @var string
     */
    public $userIdPrivateDataMap;
    protected $_name = [
        'cardBizId'            => 'cardBizId',
        'cardData'             => 'cardData',
        'updateOptions'        => 'updateOptions',
        'userIdPrivateDataMap' => 'userIdPrivateDataMap',
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
     * @return detail
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
        if (isset($map['updateOptions'])) {
            $model->updateOptions = updateOptions::fromMap($map['updateOptions']);
        }
        if (isset($map['userIdPrivateDataMap'])) {
            $model->userIdPrivateDataMap = $map['userIdPrivateDataMap'];
        }

        return $model;
    }
}
