<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryContractExtractResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $extractTaskId;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $requestId;
    protected $_name = [
        'extractTaskId' => 'extractTaskId',
        'requestId' => 'requestId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->extractTaskId) {
            $res['extractTaskId'] = $this->extractTaskId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryContractExtractResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['extractTaskId'])) {
            $model->extractTaskId = $map['extractTaskId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}
