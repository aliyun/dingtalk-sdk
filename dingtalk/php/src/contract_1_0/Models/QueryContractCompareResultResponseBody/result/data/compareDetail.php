<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareResultResponseBody\result\data;

use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareResultResponseBody\result\data\compareDetail\details;
use AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\QueryContractCompareResultResponseBody\result\data\compareDetail\differenceCount;
use AlibabaCloud\Tea\Model;

class compareDetail extends Model
{
    /**
     * @var details[]
     */
    public $details;

    /**
     * @var differenceCount
     */
    public $differenceCount;
    protected $_name = [
        'details' => 'details',
        'differenceCount' => 'differenceCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->details) {
            $res['details'] = [];
            if (null !== $this->details && \is_array($this->details)) {
                $n = 0;
                foreach ($this->details as $item) {
                    $res['details'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->differenceCount) {
            $res['differenceCount'] = null !== $this->differenceCount ? $this->differenceCount->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return compareDetail
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['details'])) {
            if (!empty($map['details'])) {
                $model->details = [];
                $n = 0;
                foreach ($map['details'] as $item) {
                    $model->details[$n++] = null !== $item ? details::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['differenceCount'])) {
            $model->differenceCount = differenceCount::fromMap($map['differenceCount']);
        }

        return $model;
    }
}
