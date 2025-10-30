<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\GetTaskQueueResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $pendingCount;

    /**
     * @var int
     */
    public $processingCount;

    /**
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'pendingCount' => 'pendingCount',
        'processingCount' => 'processingCount',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->pendingCount) {
            $res['pendingCount'] = $this->pendingCount;
        }
        if (null !== $this->processingCount) {
            $res['processingCount'] = $this->processingCount;
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
        if (isset($map['pendingCount'])) {
            $model->pendingCount = $map['pendingCount'];
        }
        if (isset($map['processingCount'])) {
            $model->processingCount = $map['processingCount'];
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
