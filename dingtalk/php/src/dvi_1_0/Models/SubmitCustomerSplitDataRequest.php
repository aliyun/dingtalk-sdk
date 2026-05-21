<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\SubmitCustomerSplitDataRequest\splitParams;
use AlibabaCloud\Tea\Model;

class SubmitCustomerSplitDataRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var splitParams[]
     */
    public $splitParams;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'splitParams' => 'splitParams',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->splitParams) {
            $res['splitParams'] = [];
            if (null !== $this->splitParams && \is_array($this->splitParams)) {
                $n = 0;
                foreach ($this->splitParams as $item) {
                    $res['splitParams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SubmitCustomerSplitDataRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['splitParams'])) {
            if (!empty($map['splitParams'])) {
                $model->splitParams = [];
                $n = 0;
                foreach ($map['splitParams'] as $item) {
                    $model->splitParams[$n++] = null !== $item ? splitParams::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
