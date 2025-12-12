<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vshangou_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddCateringCommentRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $commentId;

    /**
     * @var string
     */
    public $orderId;

    /**
     * @var string
     */
    public $rateContent;

    /**
     * @var int
     */
    public $ratedAt;

    /**
     * @var int
     */
    public $rating;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $shopId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $source;

    /**
     * @var int
     */
    public $status;
    protected $_name = [
        'commentId' => 'commentId',
        'orderId' => 'orderId',
        'rateContent' => 'rateContent',
        'ratedAt' => 'ratedAt',
        'rating' => 'rating',
        'shopId' => 'shopId',
        'source' => 'source',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commentId) {
            $res['commentId'] = $this->commentId;
        }
        if (null !== $this->orderId) {
            $res['orderId'] = $this->orderId;
        }
        if (null !== $this->rateContent) {
            $res['rateContent'] = $this->rateContent;
        }
        if (null !== $this->ratedAt) {
            $res['ratedAt'] = $this->ratedAt;
        }
        if (null !== $this->rating) {
            $res['rating'] = $this->rating;
        }
        if (null !== $this->shopId) {
            $res['shopId'] = $this->shopId;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddCateringCommentRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commentId'])) {
            $model->commentId = $map['commentId'];
        }
        if (isset($map['orderId'])) {
            $model->orderId = $map['orderId'];
        }
        if (isset($map['rateContent'])) {
            $model->rateContent = $map['rateContent'];
        }
        if (isset($map['ratedAt'])) {
            $model->ratedAt = $map['ratedAt'];
        }
        if (isset($map['rating'])) {
            $model->rating = $map['rating'];
        }
        if (isset($map['shopId'])) {
            $model->shopId = $map['shopId'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
