<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\PremiumRedirectTasksByManagerResponseBody\result\redirectResults;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description This parameter is required.
     *
     * @example 1
     *
     * @var int
     */
    public $failCount;

    /**
     * @description This parameter is required.
     *
     * @var redirectResults[]
     */
    public $redirectResults;

    /**
     * @description This parameter is required.
     *
     * @example 20
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'failCount' => 'failCount',
        'redirectResults' => 'redirectResults',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->failCount) {
            $res['failCount'] = $this->failCount;
        }
        if (null !== $this->redirectResults) {
            $res['redirectResults'] = [];
            if (null !== $this->redirectResults && \is_array($this->redirectResults)) {
                $n = 0;
                foreach ($this->redirectResults as $item) {
                    $res['redirectResults'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failCount'])) {
            $model->failCount = $map['failCount'];
        }
        if (isset($map['redirectResults'])) {
            if (!empty($map['redirectResults'])) {
                $model->redirectResults = [];
                $n = 0;
                foreach ($map['redirectResults'] as $item) {
                    $model->redirectResults[$n++] = null !== $item ? redirectResults::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
