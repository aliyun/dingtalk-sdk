<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTimerCardRequest extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $actionTime;

    /**
     * @var string
     */
    public $bizData;

    /**
     * @example CARD_EVENT
     *
     * @var string
     */
    public $bizType;

    /**
     * @example ding13424
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 20241213123213
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

    /**
     * @var string
     */
    public $memo;
    protected $_name = [
        'actionTime' => 'actionTime',
        'bizData'    => 'bizData',
        'bizType'    => 'bizType',
        'corpId'     => 'corpId',
        'identifier' => 'identifier',
        'isvCode'    => 'isvCode',
        'memo'       => 'memo',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->actionTime) {
            $res['actionTime'] = $this->actionTime;
        }
        if (null !== $this->bizData) {
            $res['bizData'] = $this->bizData;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
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
        if (null !== $this->memo) {
            $res['memo'] = $this->memo;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTimerCardRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['actionTime'])) {
            $model->actionTime = $map['actionTime'];
        }
        if (isset($map['bizData'])) {
            $model->bizData = $map['bizData'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
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
        if (isset($map['memo'])) {
            $model->memo = $map['memo'];
        }

        return $model;
    }
}
