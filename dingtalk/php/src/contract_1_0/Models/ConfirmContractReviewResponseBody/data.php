<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ConfirmContractReviewResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\ConfirmContractReviewResponseBody\data\recommended;
use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var recommended
     */
    public $recommended;

    /**
     * @var string
     */
    public $reviewId;

    /**
     * @var string
     */
    public $status;
    protected $_name = [
        'recommended' => 'recommended',
        'reviewId' => 'review_id',
        'status' => 'status',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->recommended) {
            $res['recommended'] = null !== $this->recommended ? $this->recommended->toMap() : null;
        }
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['recommended'])) {
            $model->recommended = recommended::fromMap($map['recommended']);
        }
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }

        return $model;
    }
}
