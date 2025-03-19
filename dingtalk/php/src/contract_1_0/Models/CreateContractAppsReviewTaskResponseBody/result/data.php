<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\CreateContractAppsReviewTaskResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $reviewTaskId;
    protected $_name = [
        'reviewTaskId' => 'reviewTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->reviewTaskId) {
            $res['reviewTaskId'] = $this->reviewTaskId;
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
        if (isset($map['reviewTaskId'])) {
            $model->reviewTaskId = $map['reviewTaskId'];
        }

        return $model;
    }
}
