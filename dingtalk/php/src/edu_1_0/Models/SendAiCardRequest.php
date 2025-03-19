<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendAiCardRequest extends Model
{
    /**
     * @example aaa_event
     *
     * @var string
     */
    public $actionType;

    /**
     * @var string
     */
    public $bizData;

    /**
     * @example AI_MANAGER_PRINCIPAL
     *
     * @var string
     */
    public $cardChannel;

    /**
     * @example ding23423
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 234234234
     *
     * @var string
     */
    public $identifier;

    /**
     * @example XIWO
     *
     * @var string
     */
    public $isvCode;
    protected $_name = [
        'actionType' => 'actionType',
        'bizData' => 'bizData',
        'cardChannel' => 'cardChannel',
        'corpId' => 'corpId',
        'identifier' => 'identifier',
        'isvCode' => 'isvCode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionType) {
            $res['actionType'] = $this->actionType;
        }
        if (null !== $this->bizData) {
            $res['bizData'] = $this->bizData;
        }
        if (null !== $this->cardChannel) {
            $res['cardChannel'] = $this->cardChannel;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->identifier) {
            $res['identifier'] = $this->identifier;
        }
        if (null !== $this->isvCode) {
            $res['isvCode'] = $this->isvCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendAiCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionType'])) {
            $model->actionType = $map['actionType'];
        }
        if (isset($map['bizData'])) {
            $model->bizData = $map['bizData'];
        }
        if (isset($map['cardChannel'])) {
            $model->cardChannel = $map['cardChannel'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['identifier'])) {
            $model->identifier = $map['identifier'];
        }
        if (isset($map['isvCode'])) {
            $model->isvCode = $map['isvCode'];
        }

        return $model;
    }
}
