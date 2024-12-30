<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractCompareTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $compareTaskId;
    protected $_name = [
        'compareTaskId' => 'compareTaskId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->compareTaskId) {
            $res['compareTaskId'] = $this->compareTaskId;
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
        if (isset($map['compareTaskId'])) {
            $model->compareTaskId = $map['compareTaskId'];
        }

        return $model;
    }
}
