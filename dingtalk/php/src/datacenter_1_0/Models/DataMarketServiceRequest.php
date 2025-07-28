<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdatacenter_1_0\Models;

use AlibabaCloud\Tea\Model;

class DataMarketServiceRequest extends Model
{
    /**
     * @var string
     */
    public $apiId;

    /**
     * @var string
     */
    public $args;
    protected $_name = [
        'apiId' => 'apiId',
        'args' => 'args',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->apiId) {
            $res['apiId'] = $this->apiId;
        }
        if (null !== $this->args) {
            $res['args'] = $this->args;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DataMarketServiceRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['apiId'])) {
            $model->apiId = $map['apiId'];
        }
        if (isset($map['args'])) {
            $model->args = $map['args'];
        }

        return $model;
    }
}
