<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryContractAppsReviewResultRequest extends Model
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

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'requestId' => 'requestId',
        'reviewTaskId' => 'reviewTaskId',
        'unionId' => 'unionId',
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
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryContractAppsReviewResultRequest
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
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
