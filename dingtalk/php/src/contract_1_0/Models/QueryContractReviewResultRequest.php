<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryContractReviewResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $requestId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $reviewTaskId;
    protected $_name = [
        'requestId' => 'requestId',
        'reviewTaskId' => 'reviewTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->reviewTaskId) {
            $res['reviewTaskId'] = $this->reviewTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryContractReviewResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['reviewTaskId'])) {
            $model->reviewTaskId = $map['reviewTaskId'];
        }

        return $model;
    }
}
