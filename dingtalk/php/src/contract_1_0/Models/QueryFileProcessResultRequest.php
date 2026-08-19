<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryFileProcessResultRequest extends Model
{
    /**
     * @var string
     */
    public $renderTaskId;
    protected $_name = [
        'renderTaskId' => 'renderTaskId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->renderTaskId) {
            $res['renderTaskId'] = $this->renderTaskId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryFileProcessResultRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['renderTaskId'])) {
            $model->renderTaskId = $map['renderTaskId'];
        }

        return $model;
    }
}
