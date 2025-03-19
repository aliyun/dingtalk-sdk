<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbizfinance_2_0\Models;

use AlibabaCloud\Tea\Model;

class LinkCommonInvokeRequest extends Model
{
    /**
     * @example TEST
     *
     * @var string
     */
    public $bizType;

    /**
     * @example "{\"key\":\"value\"}"
     *
     * @var string
     */
    public $data;

    /**
     * @example INOVKE_XXX
     *
     * @var string
     */
    public $invokeId;

    /**
     * @example abc
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'bizType' => 'bizType',
        'data' => 'data',
        'invokeId' => 'invokeId',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->data) {
            $res['data'] = $this->data;
        }
        if (null !== $this->invokeId) {
            $res['invokeId'] = $this->invokeId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LinkCommonInvokeRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['data'])) {
            $model->data = $map['data'];
        }
        if (isset($map['invokeId'])) {
            $model->invokeId = $map['invokeId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
