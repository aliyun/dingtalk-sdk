<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetContractReviewStatusRequest extends Model
{
    /**
     * @var string
     */
    public $reviewId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $sessionId;
    protected $_name = [
        'reviewId' => 'review_id',
        'sessionId' => 'session_id',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->reviewId) {
            $res['review_id'] = $this->reviewId;
        }
        if (null !== $this->sessionId) {
            $res['session_id'] = $this->sessionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetContractReviewStatusRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['review_id'])) {
            $model->reviewId = $map['review_id'];
        }
        if (isset($map['session_id'])) {
            $model->sessionId = $map['session_id'];
        }

        return $model;
    }
}
