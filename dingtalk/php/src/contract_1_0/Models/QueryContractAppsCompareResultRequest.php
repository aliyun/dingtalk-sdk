<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryContractAppsCompareResultRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $compareTaskId;

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
    public $unionId;
    protected $_name = [
        'compareTaskId' => 'compareTaskId',
        'requestId' => 'requestId',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->compareTaskId) {
            $res['compareTaskId'] = $this->compareTaskId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryContractAppsCompareResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['compareTaskId'])) {
            $model->compareTaskId = $map['compareTaskId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}
