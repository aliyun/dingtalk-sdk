<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryPurchaseInfoResponseBody extends Model
{
    /**
     * @example dingding123
     *
     * @var string
     */
    public $corpId;

    /**
     * @example 300001
     *
     * @var string
     */
    public $merchantId;

    /**
     * @example 小明
     *
     * @var string
     */
    public $name;

    /**
     * @example 1视频通话
     *
     * @var int
     */
    public $scene;

    /**
     * @example 10、已订购；11、未订购（包含已过期）；12、取消
     *
     * @var int
     */
    public $status;

    /**
     * @example 200001
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'     => 'corpId',
        'merchantId' => 'merchantId',
        'name'       => 'name',
        'scene'      => 'scene',
        'status'     => 'status',
        'userId'     => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->merchantId) {
            $res['merchantId'] = $this->merchantId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->scene) {
            $res['scene'] = $this->scene;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryPurchaseInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['merchantId'])) {
            $model->merchantId = $map['merchantId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['scene'])) {
            $model->scene = $map['scene'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
