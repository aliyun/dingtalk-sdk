<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vokr_1_0\Models;

use AlibabaCloud\Tea\Model;

class OkrObjectivesBatchRequest extends Model
{
    /**
     * @example dingOKR
     *
     * @var string
     */
    public $goodsCode;

    /**
     * @var string[]
     */
    public $objectiveIds;
    protected $_name = [
        'goodsCode'    => 'goodsCode',
        'objectiveIds' => 'objectiveIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->goodsCode) {
            $res['goodsCode'] = $this->goodsCode;
        }
        if (null !== $this->objectiveIds) {
            $res['objectiveIds'] = $this->objectiveIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OkrObjectivesBatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['goodsCode'])) {
            $model->goodsCode = $map['goodsCode'];
        }
        if (isset($map['objectiveIds'])) {
            if (!empty($map['objectiveIds'])) {
                $model->objectiveIds = $map['objectiveIds'];
            }
        }

        return $model;
    }
}
